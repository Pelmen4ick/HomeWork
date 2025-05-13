using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WinFormsApp_FormatOutputBox;
namespace WinFormsApp_FormatOutputBox
{

    

 
    
        public class FormatOutputBox_Handling
        {
        public class Operation_None : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                pic.Image = (Image)Форматный_вывод_данных.Properties.Resources.ResourceManager.GetObject("Operation_None");
                consoleOut.AppendText("Выберите операцию из списка");
                return true;
            }

            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                consoleOut.AppendText("\nОперация не выбрана!");
                return false;
            }
        }

        // 1. x³ - y²
        public class Operation_X3MinusY2 : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                pic.Image = (Image)Форматный_вывод_данных.Properties.Resources.ResourceManager.GetObject("Operation_X3MinusY2");
                consoleOut.AppendText("Выбрано: x³ - y²\nДиапазоны: 0 ≤ x < 16, -12 < y < 0");
                return true;
            }

            public bool Run_Executing(int? x, int? y, ref RichTextBox consoleOut)
            {
                if (!ValidateInput(x, y, consoleOut)) return false;

                int xCubed = x.Value * x.Value * x.Value;
                int ySquared = y.Value * y.Value;
                int result = xCubed - ySquared;

                consoleOut.AppendText($"\n{x}³ - ({y})² = {xCubed} - {ySquared} = {result}");
                return true;
            }
        }

        // 2. Поразрядное сложение
        public class Operation_BitwiseSum : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                pic.Image = (Image)Форматный_вывод_данных.Properties.Resources.ResourceManager.GetObject("Operation_BitwiseSum");
                consoleOut.AppendText("Выбрано сложение столбиком\nДиапазоны: 0 ≤ x < 16, -12 < y < 0");
                return true;
            }

            public bool Run_Executing(int? x, int? y, ref RichTextBox consoleOut)
            {
                if (!ValidateInput(x, y, consoleOut)) return false;

                int result = x.Value + y.Value;

                consoleOut.AppendText("\n  " + x.Value.ToString().PadLeft(4));
                consoleOut.AppendText("\n+ " + y.Value.ToString().PadLeft(4));
                consoleOut.AppendText("\n──────");
                consoleOut.AppendText("\n= " + result.ToString().PadLeft(4));

                return true;
            }
        }

        // 3. Поразрядное умножение
        public class Operation_BitwiseMult : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                pic.Image = (Image)Форматный_вывод_данных.Properties.Resources.ResourceManager.GetObject("Operation_BitwiseMult");
                consoleOut.AppendText("Выбрано умножение столбиком\nДиапазоны: 0 ≤ x < 16, -12 < y < 0");
                return true;
            }

            public bool Run_Executing(int? x, int? y, ref RichTextBox consoleOut)
            {
                if (!ValidateInput(x, y, consoleOut)) return false;

                int result = x.Value * y.Value;

                consoleOut.AppendText("\n  " + x.Value.ToString().PadLeft(4));
                consoleOut.AppendText("\n× " + y.Value.ToString().PadLeft(4));
                consoleOut.AppendText("\n──────");
                consoleOut.AppendText("\n= " + result.ToString().PadLeft(4));

                return true;
            }
        }

        // Общая валидация для всех операций
        private static bool ValidateInput(int? x, int? y, RichTextBox consoleOut)
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

            return true;
        }
    }
}
    

