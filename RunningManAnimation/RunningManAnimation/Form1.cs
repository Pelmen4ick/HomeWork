using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningManAnimation
{
    public partial class Form1 : Form
    {
        private int d = 1; // Направление и скорость (положительное - вправо, отрицательное - влево)
        private Image leftImage; // Изображение для движения влево
        private Image rightImage; // Изображение для движения вправо

        public Form1()
        {
            InitializeComponent();
            LoadImages();
            SetupControls();
        }

        private void LoadImages()
        {
            try
            {
                // Загрузка изображений (поместите файлы в папку с исполняемым файлом)
                leftImage = Image.FromFile("Ris1.jpg");  // Человечек бежит влево
                rightImage = Image.FromFile("Ris2.jpg"); // Человечек бежит вправо
                pictureBox1.Image = rightImage; // Начальное изображение
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображений: {ex.Message}");
                Environment.Exit(1);
            }
        }

        private void SetupControls()
        {
            // Настройка PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Настройка TrackBar
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 50;
            trackBar1.TickFrequency = 5;
            trackBar1.Value = 1;

            // Настройка Timer
            timer1.Interval = 10;
            timer1.Enabled = false;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Освобождение ресурсов
            leftImage?.Dispose();
            rightImage?.Dispose();
            base.OnFormClosing(e);
        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            d = Math.Sign(d) * trackBar1.Value;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            pictureBox1.Left += d;

       
            if (pictureBox1.Right >= ClientSize.Width || pictureBox1.Left <= 0)
            {
              
                d = -d;
                pictureBox1.Image = d > 0 ? rightImage : leftImage;
            }
        }
    }
}

