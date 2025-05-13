using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WinFormsApp_SaveLoadFragments
{
    class Arraypicture
    {
        private Bitmap _bmp_picture;
        private Size _size_picture;
        private PictureBox[] _pictures;
        private int _count_str;
        private int _count_col;

        public Arraypicture(Control parent_control, Bitmap bmp_picture, Size size_picture,
            int count_str, int count_col)
        {
            _count_str = count_str;
            _count_col = count_col;
            _pictures = new PictureBox[count_str * count_col];
            _bmp_picture = bmp_picture;
            _size_picture = size_picture;

            InitializePictureBoxes(parent_control);
            Set_Sizes(size_picture);
        }

        private void InitializePictureBoxes(Control parent)
        {
            for (int i_w = 0; i_w < _count_col; i_w++)
            {
                for (int i_h = 0; i_h < _count_str; i_h++)
                {
                    int index = Get_Real_Index(i_w, i_h);
                    _pictures[index] = new PictureBox
                    {
                        Name = "pic_" + i_h + "_" + i_w,
                        Parent = parent,
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Tag = index
                    };
                }
            }
        }

        public void Change_Bmp(int index, Bitmap bmp_change)
        {
            int w_bmp = _bmp_picture.Width / _count_col;
            int h_bmp = _bmp_picture.Height / _count_str;
            int index_string = Get_String_Index(index);
            int index_column = Get_Column_Index(index);

            RectangleF rect_temp = new RectangleF(
                index_string * w_bmp,
                index_column * h_bmp,
                w_bmp,
                h_bmp);

            using (Graphics gr = Graphics.FromImage(_bmp_picture))
            {
                gr.DrawImage(bmp_change, rect_temp);
            }
            Set_Sizes(_size_picture);
        }

        public void Swap_Bmp(int index_first, int index_second)
        {
            int w_bmp = _bmp_picture.Width / _count_col;
            int h_bmp = _bmp_picture.Height / _count_str;

            // Получаем координаты первого фрагмента
            int first_str = Get_String_Index(index_first);
            int first_col = Get_Column_Index(index_first);
            RectangleF rect_first = new RectangleF(
                first_str * w_bmp,
                first_col * h_bmp,
                w_bmp,
                h_bmp);
            Bitmap bmp_first = _bmp_picture.Clone(rect_first, _bmp_picture.PixelFormat);

            // Получаем координаты второго фрагмента
            int second_str = Get_String_Index(index_second);
            int second_col = Get_Column_Index(index_second);
            RectangleF rect_second = new RectangleF(
                second_str * w_bmp,
                second_col * h_bmp,
                w_bmp,
                h_bmp);
            Bitmap bmp_second = _bmp_picture.Clone(rect_second, _bmp_picture.PixelFormat);

            // Меняем фрагменты местами
            using (Graphics gr = Graphics.FromImage(_bmp_picture))
            {
                gr.DrawImage(bmp_first, rect_second);
                gr.DrawImage(bmp_second, rect_first);
            }
            Set_Sizes(_size_picture);
        }

        public void Set_Sizes(Size im_size)
        {
            _size_picture = im_size;
            int w = _size_picture.Width / _count_col;
            int h = _size_picture.Height / _count_str;
            int w_bmp = _bmp_picture.Width / _count_col;
            int h_bmp = _bmp_picture.Height / _count_str;

            for (int i_w = 0; i_w < _count_col; i_w++)
            {
                for (int i_h = 0; i_h < _count_str; i_h++)
                {
                    RectangleF rect_temp = new RectangleF(
                        i_w * w_bmp,
                        i_h * h_bmp,
                        w_bmp,
                        h_bmp);

                    Bitmap bmp_temp = _bmp_picture.Clone(rect_temp, _bmp_picture.PixelFormat);
                    int index = Get_Real_Index(i_w, i_h);

                    _pictures[index].Image = bmp_temp;
                    _pictures[index].Width = w;
                    _pictures[index].Height = h;
                    _pictures[index].Left = i_w * w;
                    _pictures[index].Top = i_h * h;
                    _pictures[index].Refresh();
                }
            }
        }

        public IEnumerable<PictureBox> Get_Pictures()
        {
            for (int i = 0; i < _pictures.Length; i++)
            {
                yield return _pictures[i];
            }
        }

        public Bitmap GetFullImage() => _bmp_picture;

        public int Get_String_Index(int real_index) => real_index / _count_str;
        public int Get_Column_Index(int real_index) => real_index % _count_str;
        public int Get_Real_Index(int ind_str, int ind_col) => _count_str * ind_str + ind_col;

        public PictureBox this[int index] => _pictures[index];
    }
}


