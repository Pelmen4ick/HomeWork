using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ErrorProviderSample
{
    public partial class FrmErrorProviderSample : Form
    {
        public FrmErrorProviderSample()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, " + TextBoxName.Text + "! Спасибо за корректный ввод.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            Regex regexMatchAnyCyrillicChar = new Regex(@"(.*[a-zA-Z0-9\W]+.*)|(^[а-я]+.*$)");
            MatchCollection regexMatches = regexMatchAnyCyrillicChar.Matches(TextBoxName.Text);
            if (regexMatches.Count > 0)
            {
                ErrorProviderForName.SetError(TextBoxName, "Вводите имя в кириллице, с большой буквы. Латинские буквы, цифры и спецсимволы запрещены.");

                ErrorProviderForName.SetIconPadding(TextBoxName, 10);
                TextBoxName.ForeColor = Color.Red;
            }
            else
            {
                TextBoxName.ForeColor = SystemColors.WindowText;
                ErrorProviderForName.Clear();
            }
            EnableDisableSubmitButton();
        }
        private void EnableDisableSubmitButton()
        {
            string currentError = ErrorProviderForName.GetError(TextBoxName);
            ButtonSubmit.Enabled = currentError.Length == 0 && TextBoxName.TextLength > 0;
        }

        private void FrmErrorProviderSample_Load(object sender, EventArgs e)
        {
            EnableDisableSubmitButton();
        }
    }
}
