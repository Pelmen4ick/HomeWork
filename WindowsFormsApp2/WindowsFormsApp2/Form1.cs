using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                AddLogRecord("Удалён элемент списка: " +
                listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            EnableDisableButtonRemoveSelectedElement();
            EnableDisableButtonClearList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newListElement = TextBoxNewElement.Text;
            AddLogRecord("Добавлен новый элемент в список: " + newListElement);
            listBox1.Items.Add(newListElement);
            ClearTextBox();
            EnableDisableButtonRemoveSelectedElement();
            EnableDisableButtonClearList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedElementInfo();
            EnableDisableButtonRemoveSelectedElement();
        }

       
        private void UpdateSelectedElementInfo()
        {
            if (listBox1.SelectedIndex == -1)
            {
                LabelInfo.Text = "Не выбран ни один элемент списка";
                return;
            }
            string selectedItem = (string)listBox1.SelectedItem;
            LabelInfo.Text = "Выбран элемент списка: " +
            selectedItem;
        }

        private void ButtonClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            EnableDisableButtonClearList();
            EnableDisableButtonRemoveSelectedElement();
            AddLogRecord("Список полностью очищен");
        }

        private void AddLogRecord(string logMessage)
        {
            TextBoxEvents.Text += logMessage + "\r\n";
        }
        private void TextBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ClearTextBox()
        {
            TextBoxNewElement.ForeColor = Color.LightGray;
            TextBoxNewElement.Text = "< Введите текст для элемента списка... >";
        }

        private void EnableDisableButtonAddElement()
        {
            ButtonAddElement.Enabled = TextBoxNewElement.Text != "" && TextBoxNewElement.ForeColor != Color.LightGray;
        }
        private void EnableDisableButtonRemoveSelectedElement()
        {
            ButtonRemoveSelectedElement.Enabled = listBox1.Items.Count > 0 && listBox1.SelectedItem != null;
        }
        private void EnableDisableButtonClearList()
        {
            ButtonClearList.Enabled = listBox1.Items.Count > 0;
        }

        private void TextBoxNewElement_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtonAddElement();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Первый элемент списка");
            listBox1.Items.Add("Второй элемент списка");
            listBox1.Items.Add("Третий элемент списка");
            listBox1.Items.Add("Другой элемент списка");
            listBox1.Items.Add("Какой-то ещё элемент списка");


            UpdateSelectedElementInfo();

            ClearTextBox();
            EnableDisableButtonAddElement();
        }

        private void TextBoxNewElement_Enter(object sender, EventArgs e)
        {
            if(TextBoxNewElement.ForeColor == Color.LightGray) {
                TextBoxNewElement.Text = "";
                TextBoxNewElement.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxNewElement_Leave(object sender, EventArgs e)
        {
            if (TextBoxNewElement.Text == "")
            {
                ClearTextBox();
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            AddLogRecord("[MouseClick] Клик мышью: Кнопка = " + e.Button + ", Кликов = " + e.Clicks + ", Положение = " + e.Location);
        }

     

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBoxEvents.Text = "";
        }

        private void LabelInfoSelectedElement_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxEvents_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
