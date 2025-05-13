using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace FileFinderExample
{
    public partial class Form1 : Form
    {
       

        

        void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private class FileSearchInfo
        {
            public long FilesTotalCount { get; set; }
            public long FilesProcessedCount { get; set; }
            public string SearchDirectory { get; set; }
            public long FilesFound { get; set; }
            public string FileNameMask { get; set; }
            public List<string> FoundFiles { get; } = new List<string>();
        }

        private enum BackgroundWorkerMode
        {
            Estimate,
            Search
        }

        private bool IsSearchRunning { get; set; }
        private readonly FileSearchInfo _fileSearchInfo = new FileSearchInfo();

        public Form1()
        {
            InitializeComponent();
            SetupControls();
            LoadAvailableDrivesInfo();
        }

        private void SetupControls()
        {
            // Настройка BackgroundWorker
            BackgroundWorkerEstimateSearchTime.WorkerReportsProgress = true;
            BackgroundWorkerEstimateSearchTime.WorkerSupportsCancellation = true;
            BackgroundWorkerSearchFiles.WorkerReportsProgress = true;
            BackgroundWorkerSearchFiles.WorkerSupportsCancellation = true;

            // Привязка событий
            BackgroundWorkerEstimateSearchTime.DoWork += BackgroundWorkerEstimateSearchTime_DoWork;
            BackgroundWorkerEstimateSearchTime.ProgressChanged += BackgroundWorkerEstimateSearchTime_ProgressChanged;
            BackgroundWorkerEstimateSearchTime.RunWorkerCompleted += BackgroundWorkerEstimateSearchTime_RunWorkerCompleted;

            BackgroundWorkerSearchFiles.DoWork += BackgroundWorkerSearchFiles_DoWork;
            BackgroundWorkerSearchFiles.ProgressChanged += BackgroundWorkerSearchFiles_ProgressChanged;
            BackgroundWorkerSearchFiles.RunWorkerCompleted += BackgroundWorkerSearchFiles_RunWorkerCompleted;

            ButtonStartSearch.Click += ButtonStartSearch_Click;
            ButtonSelectSearchDirectory.Click += ButtonSelectSearchDirectory_Click;
            ListViewFoundFiles.DoubleClick += ListViewFoundFiles_DoubleClick;
            ComboBoxDrives.SelectedIndexChanged += ComboBoxDrives_SelectedIndexChanged;
            TextBoxFileName.TextChanged += TextBoxFileName_TextChanged;

            // Начальные настройки
            ProgressBarMain.Visible = false;
            LabelFilesCount.Visible = false;
            LabelProgress.Visible = false;
            this.DoubleBuffered = true;
        }

        private void LoadAvailableDrivesInfo()
        {
            try
            {
                ComboBoxDrives.Items.Clear();
                foreach (var drive in DriveInfo.GetDrives().Where(d => d.IsReady))
                {
                    ComboBoxDrives.Items.Add(new DriveInfoItem(drive));
                }
                ComboBoxDrives.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке дисков: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateFilesCountRecursively(string parentDirectory, BackgroundWorkerMode workerMode,
                                                    FileSearchInfo fileInfoHolder, BackgroundWorker worker)
        {
            if (worker.CancellationPending) return;

            try
            {
                // Обработка файлов в текущей директории
                var files = Directory.GetFiles(parentDirectory);
                if (workerMode == BackgroundWorkerMode.Estimate)
                {
                    fileInfoHolder.FilesTotalCount += files.Length;
                    worker.ReportProgress(10);
                }
                else
                {
                    foreach (var file in files)
                    {
                        if (worker.CancellationPending) return;

                        if (Path.GetFileName(file).IndexOf(fileInfoHolder.FileNameMask, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            fileInfoHolder.FoundFiles.Add(file);
                            fileInfoHolder.FilesFound++;
                        }
                        fileInfoHolder.FilesProcessedCount++;
                    }

                    int progress = fileInfoHolder.FilesTotalCount > 0
                        ? (int)((double)fileInfoHolder.FilesProcessedCount / fileInfoHolder.FilesTotalCount * 100)
                        : 0;

                    worker.ReportProgress(progress, fileInfoHolder.FoundFiles.ToList());
                    fileInfoHolder.FoundFiles.Clear();
                }

                // Рекурсивный обход поддиректорий
                foreach (var dir in Directory.GetDirectories(parentDirectory))
                {
                    if (worker.CancellationPending) return;
                    CalculateFilesCountRecursively(dir, workerMode, fileInfoHolder, worker);
                }
            }
            catch (UnauthorizedAccessException) { }
            catch (DirectoryNotFoundException) { }
            catch (Exception) { }
        }

        #region Event Handlers

        private void BackgroundWorkerEstimateSearchTime_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is FileSearchInfo info)
            {
                CalculateFilesCountRecursively(info.SearchDirectory, BackgroundWorkerMode.Estimate,
                    info, BackgroundWorkerEstimateSearchTime);
            }
        }

        private void BackgroundWorkerSearchFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is FileSearchInfo info)
            {
                CalculateFilesCountRecursively(info.SearchDirectory, BackgroundWorkerMode.Search,
                    info, BackgroundWorkerSearchFiles);
            }
        }

        private void BackgroundWorkerEstimateSearchTime_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LabelFilesCount.Text = _fileSearchInfo.FilesTotalCount.ToString();
            LabelFilesCount.Visible = true;
        }

        private void BackgroundWorkerSearchFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarMain.Value = e.ProgressPercentage;
            if (e.UserState is List<string> foundFiles)
            {
                foreach (var file in foundFiles)
                {
                    var fileInfo = new FileInfo(file);
                    ListViewFoundFiles.Items.Add(new ListViewItem(new[]
                    {
                        file,
                        fileInfo.Length.ToString("N0")
                    }));
                }
            }
        }

        private void BackgroundWorkerEstimateSearchTime_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ResetSearchState("Оценка времени поиска прервана");
            }
            else
            {
                StartFileSearch();
            }
        }

        private void BackgroundWorkerSearchFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ResetSearchState("Поиск прерван");
            }
            else
            {
                LabelProgress.Text = $"Поиск завершен. Найдено файлов: {_fileSearchInfo.FilesFound}";
                LabelFilesCount.Text = _fileSearchInfo.FilesFound.ToString();
                ProgressBarMain.Value = 100;
            }
            SetIsSearchRunning(false);
        }

        private void ButtonStartSearch_Click(object sender, EventArgs e)
        {
            if (IsSearchRunning)
            {
                BackgroundWorkerEstimateSearchTime.CancelAsync();
                BackgroundWorkerSearchFiles.CancelAsync();
                ButtonStartSearch.Enabled = false;
            }
            else
            {
                StartSearchProcess();
            }
        }

        private void ButtonSelectSearchDirectory_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialogSelectSearchDirectory.ShowDialog() == DialogResult.OK)
            {
                string path = FolderBrowserDialogSelectSearchDirectory.SelectedPath;
                if (!path.EndsWith(Path.DirectorySeparatorChar.ToString()))
                    path += Path.DirectorySeparatorChar;

                _fileSearchInfo.SearchDirectory = path;
                TextBoxSearchPath.Text = path;
                SelectDriveByPath(path);
            }
        }

        private void ListViewFoundFiles_DoubleClick(object sender, EventArgs e)
        {
            if (ListViewFoundFiles.SelectedItems.Count > 0)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = ListViewFoundFiles.SelectedItems[0].Text,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ComboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDrives.SelectedItem is DriveInfoItem drive)
            {
                _fileSearchInfo.SearchDirectory = drive.DriveName;
                TextBoxSearchPath.Text = drive.DriveName;
            }
        }

        private void TextBoxFileName_TextChanged(object sender, EventArgs e)
        {
            ButtonStartSearch.Enabled = !string.IsNullOrWhiteSpace(TextBoxFileName.Text);
        }

        #endregion

        #region Helper Methods

        private void StartSearchProcess()
        {
            _fileSearchInfo.FileNameMask = TextBoxFileName.Text.Trim();
            _fileSearchInfo.FilesFound = 0;
            _fileSearchInfo.FilesProcessedCount = 0;
            _fileSearchInfo.FoundFiles.Clear();
            ListViewFoundFiles.Items.Clear();
            ProgressBarMain.Visible = true;
            LabelProgress.Visible = true;
            LabelFilesCount.Visible = true;

            if (_fileSearchInfo.FilesTotalCount == 0)
            {
                ProgressBarMain.Style = ProgressBarStyle.Marquee;
                LabelProgress.Text = "Подсчет файлов...";
                BackgroundWorkerEstimateSearchTime.RunWorkerAsync(_fileSearchInfo);
            }
            else
            {
                ProgressBarMain.Style = ProgressBarStyle.Continuous;
                LabelProgress.Text = "Поиск файлов...";
                BackgroundWorkerSearchFiles.RunWorkerAsync(_fileSearchInfo);
            }

            SetIsSearchRunning(true);
        }

        private void StartFileSearch()
        {
            ProgressBarMain.Style = ProgressBarStyle.Continuous;
            ProgressBarMain.Value = 0;
            LabelProgress.Text = "Поиск файлов...";
            BackgroundWorkerSearchFiles.RunWorkerAsync(_fileSearchInfo);
        }

        private void ResetSearchState(string message)
        {
            LabelProgress.Text = message;
            ProgressBarMain.Visible = false;
            LabelFilesCount.Visible = false;
            _fileSearchInfo.FilesTotalCount = 0;
            SetIsSearchRunning(false);
        }

        private void SetIsSearchRunning(bool isRunning)
        {
            IsSearchRunning = isRunning;
            ButtonStartSearch.Text = isRunning ? "&Прервать" : "&Начать поиск";
            ButtonSelectSearchDirectory.Enabled = !isRunning;
            ComboBoxDrives.Enabled = !isRunning;
            TextBoxFileName.Enabled = !isRunning;
        }

        private void SelectDriveByPath(string path)
        {
            string driveLetter = Path.GetPathRoot(path);
            foreach (var item in ComboBoxDrives.Items)
            {
                if (item is DriveInfoItem drive && drive.DriveName.Equals(driveLetter, StringComparison.OrdinalIgnoreCase))
                {
                    ComboBoxDrives.SelectedItem = item;
                    break;
                }
            }
        }

        #endregion

    }
}

