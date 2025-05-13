using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_FormatOutputBox
{


    public interface IFormatOutputBox
    {
        bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic);
        bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut);
    }

}
