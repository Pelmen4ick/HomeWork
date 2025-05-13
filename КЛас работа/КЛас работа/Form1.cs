using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace КЛас_работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            ofd.Dispose();

           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы раб системы");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = textBox1.Text;
            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
            if (checkBox2.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                DeleteSelectedStrings(listBox1);
            }
            else if(listBox2.SelectedItems.Count > 0)
            {
                DeleteSelectedStrings(listBox2);
            }
        }

        void DeleteSelectedStrings(ListBox lb)
        {
            for (int i = lb.Items.Count - 1; i >= 0; i--)
            {
                if (lb.GetSelected(i)) lb.Items.RemoveAt(i);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd2 = new SaveFileDialog();

            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(ofd2.FileName);

                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    writer.WriteLine(listBox2.Items[i].ToString());
                }
                writer.Close();

            }
            ofd2.Dispose();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            foreach (object Item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(Item);
              
               
            }
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.GetSelected(i))
                    listBox1.Items.RemoveAt(i);
            }
            listBox2.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(Item);
                

            }
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.GetSelected(i))
                    listBox2.Items.RemoveAt(i);
            }

            listBox1.EndUpdate();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sort(listBox1, comboBox1);


        }

        void Sort(ListBox lb, ComboBox cb)
        {
            var items = lb.Items.Cast<string>().ToList();
            switch (cb.SelectedIndex)
            {
                case 0: items.Sort(); break;
                    case 1: items.Sort(); items.Reverse(); break;
                case 2: items = items.OrderBy(x => x.Length).ToList();
                    break;
                case 3: items = items.OrderByDescending(x => x.Length).ToList(); break;


            }
            lb.Items.Clear();
            lb.Items.AddRange(items.ToArray());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sort(listBox2, comboBox2);
        }
    }
}
