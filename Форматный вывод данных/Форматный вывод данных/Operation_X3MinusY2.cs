using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_FormatOutputBox
{
    class Operation_X3MinusY2 : IFormatOutputBox
    {
        public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
        {
            try
            {
                pic.Image = (Image)Форматный_вывод_данных.Properties.Resources.ResourceManager.GetObject("Operation_X3MinusY2");
                consoleOut.AppendText("Выбрано: x³ - y²\nДиапазоны: 0 ≤ x < 16, -12 < y < 0");
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

            int xCubed = x.Value * x.Value * x.Value;
            int ySquared = y.Value * y.Value;
            int result = xCubed - ySquared;

            consoleOut.AppendText($"\nВычисление:");
            consoleOut.AppendText($"\n{x}³ - ({y})² = {xCubed} - {ySquared} = {result}");

            return true;
        }
    }
}

