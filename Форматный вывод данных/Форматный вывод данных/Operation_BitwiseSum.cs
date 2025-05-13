using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_FormatOutputBox;

namespace WinFormsApp_FormatOutputBox
{
    class Operation_BitwiseSum : IFormatOutputBox
    {
        public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
        {
            try
            {
                pic.Image = (Image)Форматный_вывод_данных.Properties.Resources.ResourceManager.GetObject("Operation_BitwiseSum");
                consoleOut.AppendText("Выбрано сложение столбиком\nДиапазоны: 0 ≤ x < 16, -12 < y < 0");
                return true;
            }
            catch
            {
                consoleOut.AppendText("Ошибка загрузки изображения операции");
                return false;
            }
        }

        public bool Run_Executing(int? x, int? y, ref RichTextBox consoleOut)
        {
            if (x == null || y == null)
            {
                consoleOut.AppendText("\nОшибка: введите оба числа!");
                return false;
            }

            if (x < 0 || x >= 16)
            {
                consoleOut.AppendText($"\nОшибка: x={x} должен быть 0 ≤ x < 16");
                return false;
            }

            if (y <= -12 || y >= 0)
            {
                consoleOut.AppendText($"\nОшибка: y={y} должен быть -12 < y < 0");
                return false;
            }

            int result = x.Value + y.Value;

            consoleOut.AppendText("\nПоразрядное сложение:");
            consoleOut.AppendText($"\n  {x,4}");
            consoleOut.AppendText($"\n+ {y,4}");
            consoleOut.AppendText($"\n──────");
            consoleOut.AppendText($"\n= {result,4}");

            return true;
        }
    }
}
