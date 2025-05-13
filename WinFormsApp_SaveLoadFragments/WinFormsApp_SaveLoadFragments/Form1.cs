using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_SaveLoadFragments
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Arraypicture _arr_pictures;
        private int _selectedFragment = -1;

        public Form1()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            // Создаем тестовое изображение программно
            Bitmap testImage = new Bitmap(800, 600);
            using (Graphics g = Graphics.FromImage(testImage))
            {
                g.Clear(Color.LightGray);
                using (Font font = new Font("Arial", 40))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    g.DrawString("Load your image", font, brush, 100, 250);
                }
            }

            _arr_pictures = new Arraypicture(
                pictureBox,
                testImage,
                new Size(pictureBox.Width, pictureBox.Height),
                3,
                4
            );

            AssignPictureClickHandlers();
        }

        private void AssignPictureClickHandlers()
        {
            foreach (PictureBox pic in _arr_pictures.Get_Pictures())
            {
                pic.Click += Fragment_Click;
                pic.Visible = true;
            }
        }

        private void Fragment_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int index = (int)pic.Tag;

            if (checkBox_Swap.Checked)
            {
                HandleFragmentSwap(index, pic);
                return;
            }

            if (radioButton_Load.Checked)
                LoadFragment(index);
            else
                SaveFragment(index);
        }

        private void HandleFragmentSwap(int index, PictureBox pic)
        {
            if (_selectedFragment == -1)
            {
                _selectedFragment = index;
                pic.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                _arr_pictures.Swap_Bmp(_selectedFragment, index);
                _arr_pictures[_selectedFragment].BorderStyle = BorderStyle.FixedSingle;
                _selectedFragment = -1;
            }
        }

        private void LoadFragment(int index)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap newFragment = new Bitmap(ofd.FileName);
                    _arr_pictures.Change_Bmp(index, newFragment);
                }
            }
        }

        private void SaveFragment(int index)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    PictureBox pic = _arr_pictures[index];
                    pic.Image.Save(sfd.FileName);
                }
            }
        }

        private void button_LoadNew_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap newImage = new Bitmap(ofd.FileName);
                    _arr_pictures = new Arraypicture(
                        pictureBox,
                        newImage,
                        pictureBox.Size,
                        (int)numericUpDown_Rows.Value,
                        (int)numericUpDown_Cols.Value
                    );
                    AssignPictureClickHandlers();
                }
            }
        }

        private void button_SaveAll_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JPEG Image|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap fullImage = new Bitmap(pictureBox.Width, pictureBox.Height);
                    using (Graphics g = Graphics.FromImage(fullImage))
                    {
                        foreach (PictureBox pic in _arr_pictures.Get_Pictures())
                        {
                            g.DrawImage(pic.Image, pic.Location);
                        }
                    }
                    fullImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_arr_pictures != null)
            {
                _arr_pictures = new Arraypicture(
                    pictureBox,
                    _arr_pictures.GetFullImage(),
                    pictureBox.Size,
                    (int)numericUpDown_Rows.Value,
                    (int)numericUpDown_Cols.Value
                );
                AssignPictureClickHandlers();
            }
        }

        private void Form_Main_SizeChanged(object sender, EventArgs e)
        {
            Size newSize = new Size(
                this.ClientSize.Width - 40,
                this.ClientSize.Height - 100
            );

            pictureBox.Size = newSize;
            _arr_pictures?.Set_Sizes(newSize);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




    




