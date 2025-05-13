using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_FormatOutputBox
{


    public class FormatOutputBox_GUI
    {
        public enum Operations
        {
            None = 0,
            SimpleSum,
            SimpleMult,
            X3MinusY2,   
            BitwiseSum,  
            BitwiseMult   
        };

        private int _selOperation = (int)Operations.None;
        private PictureBox _picturePreview;
        private RichTextBox _consoleExample;
        private readonly List<IFormatOutputBox> _operations = new List<IFormatOutputBox>();

        public FormatOutputBox_GUI()
        {
            _operations.Add(new FormatOutputBox_Handling.Operation_None());
            _operations.Add(new Operation_X3MinusY2());
            _operations.Add(new Operation_BitwiseSum());
            _operations.Add(new Operation_BitwiseMult());
        }

        public bool InvokeData(int selOperation, ref PictureBox picturePreview, ref RichTextBox consoleExample)
        {
            _selOperation = selOperation;
            _picturePreview = picturePreview;
            _consoleExample = consoleExample;
            ClearData();
            return _operations[_selOperation].Load_Invoking(ref _consoleExample, ref _picturePreview);
        }

        public bool ExecuteData(int? a, int? b)
        {
            return _operations[_selOperation].Run_Executing(a, b, ref _consoleExample);
        }

        public void ClearData()
        {
            _consoleExample.Clear();
        }
    }
}



