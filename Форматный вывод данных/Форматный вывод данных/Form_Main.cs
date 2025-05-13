using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_FormatOutputBox
{

  

    public partial class form_Main : Form
    {

        private readonly FormatOutputBox_GUI _outputBox = new FormatOutputBox_GUI();
        private int? _a;
        private int? _b;
        private int _index;

        public form_Main()
        {
            InitializeComponent();
            listBox_Input.SelectedIndex = 0;
        }

        public void  Form_Main_Load(object s, EventArgs e)
        {

        }


        private void pictureBox_Preview_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = listBox_Input.SelectedIndex;
            _outputBox.InvokeData(_index, ref pictureBox_Preview, ref richTextBox_Output);
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            _outputBox.ExecuteData(_a, _b);
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            _a = int.TryParse(textBox_A.Text, out int val) ? val : (int?)null;
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            _b = int.TryParse(textBox_B.Text, out int val) ? val : (int?)null;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _outputBox.ClearData();
        }
    }
}

