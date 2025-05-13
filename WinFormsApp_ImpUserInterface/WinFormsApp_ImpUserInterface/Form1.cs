using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_ImpUserInterface
{
    public partial class Form1 : Form
    {
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool _flag_access = true;
        private readonly int[] _paramValuesDefault = { 10, 12, 13 }; // N=11, поэтому 11+1=12, 11+2=13
        private IEvaluate[] _evaluate_ref = { null, null, null };

        public Form1()
        {
            InitializeComponent();

            _evaluate_ref[0] = new Class_Task1();
            _evaluate_ref[1] = new Class_Task2();
            _evaluate_ref[2] = new Class_Task3();

            comboBox_TaskNum.SelectedIndex = 0;

            // Настройка ScrollBar
            vScrollBar_InputValue.Minimum = 0;
            vScrollBar_InputValue.Maximum = 100;
            vScrollBar_InputValue.Value = 50;

            // Обработчики событий
            comboBox_TaskNum.SelectedIndexChanged += ComboBox_TaskNum_SelectedIndexChanged;
            button_EvaluateVariant.Click += Button_EvaluateVariant_Click;
            button_EvaluateAllDefault.Click += Button_EvaluateAllDefault_Click;
            button_Close.Click += Button_Close_Click;
            textBox_InputValue.TextChanged += TextBox_InputValue_TextChanged;
            vScrollBar_InputValue.Scroll += VScrollBar_InputValue_Scroll;
        }

        private void ComboBox_TaskNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_flag_access) return;

            int ind = comboBox_TaskNum.SelectedIndex;
            _evaluate_ref[ind].Invoke_Variant(ind, _paramValuesDefault[ind]);
            textBox_InputValue.Text = _paramValuesDefault[ind].ToString();

            // Загрузка изображения формулы
            pictureBox_Formula.Image = (Image)Properties.Resources.ResourceManager
                .GetObject("Task_" + (ind + 1).ToString());
        }

        private void Button_EvaluateVariant_Click(object sender, EventArgs e)
        {
            if (!_flag_access) return;

            int ind = comboBox_TaskNum.SelectedIndex;
            string str_out = _evaluate_ref[ind].Execute_Variant();
            label_Output.Text = str_out;
        }

        private void Button_EvaluateAllDefault_Click(object sender, EventArgs e)
        {
            if (!_flag_access) return;

            string result = "";
            for (int i = 0; i < 3; i++)
            {
                _evaluate_ref[i].Invoke_Variant(i, _paramValuesDefault[i]);
                result += $"Задание {i + 1}:\n{_evaluate_ref[i].Execute_Variant()}\n\n";
            }
            label_Output.Text = result;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_InputValue_TextChanged(object sender, EventArgs e)
        {
            if (!_flag_access) return;

            int ind = comboBox_TaskNum.SelectedIndex;
            if (int.TryParse(textBox_InputValue.Text, out int value))
            {
                _evaluate_ref[ind].ParamValue = value;
            }
        }

        private void VScrollBar_InputValue_Scroll(object sender, ScrollEventArgs e)
        {
            _flag_access = false;
            int invertedValue = vScrollBar_InputValue.Maximum - (e.NewValue - vScrollBar_InputValue.Minimum);
            textBox_InputValue.Text = invertedValue.ToString();
            _flag_access = true;

            // Вызываем вычисления автоматически при изменении ScrollBar
            Button_EvaluateVariant_Click(sender, e);
        }
    }
}

