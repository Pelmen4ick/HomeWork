using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_LuckyTicket
{
    public partial class Form1 : Form
    {


        private readonly Class_Evaluating evaluate = new Class_Evaluating();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            short[] arr = { -1, -1, -1, -1, -1, -1 };
            short def = -1;

            string str_arr = this.textBox_Input.Text;
            int length = str_arr.Length;

            for (int i = 0; i < length && i < 6; i++)
            {
                string str = str_arr[i].ToString();
                arr[i] = Class_Parsing.StrToShortDef(str, def);
            }

            short sh_checked = Class_Evaluating.DEF_VARIANT_DEFAULT;
            if (this.radioButton_VariantTask.Checked)
                sh_checked = Class_Evaluating.DEF_VARIANT_TASK;

            short sh_answer = Class_Evaluating.IsHappyLucky(arr, sh_checked);
            string str_answer = Class_Evaluating.GetMessageByLuckyValue(sh_answer);
            MessageBox.Show(str_answer);
        }

        private void button_FindAll_Click(object sender, EventArgs e)
        {
            short sh_checked = Class_Evaluating.DEF_VARIANT_DEFAULT;
            if (this.radioButton_VariantTask.Checked)
                sh_checked = Class_Evaluating.DEF_VARIANT_TASK;

            List<string> lst_lucky = new List<string>();
            short[] sh_arr = { -1, -1, -1, -1, -1, -1 };
            long count = 0;

            for (long num = 0; num <= 999999; num++)
            {
                Class_Parsing.ConvertLongToArray(num, ref sh_arr);
                short result = Class_Evaluating.IsHappyLucky(sh_arr, sh_checked);

                if (result == Class_Evaluating.DEF_LUCKY_TICKET)
                {
                    string str = $"[{count++}] {Class_Parsing.ConvertLongToString(num, 6)}";
                    lst_lucky.Add(str);
                }
            }

            listBox_Enumerate.Items.Clear();
            listBox_Enumerate.Items.AddRange(lst_lucky.ToArray());
        }
    }
}



