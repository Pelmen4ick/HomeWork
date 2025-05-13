using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using PasswordGenerator.Properties;


namespace PasswordGenerator
{
    public partial class FrmPasswordGenerator : Form
    {

        public string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8",
"9" };
        public string[] lowercaseLetters = new string[] { "a", "b", "c", "d", "e", "f",
"g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x",
"y", "z" };
        public string[] uppercaseLetters = new string[] { "A", "B", "C", "D", "E", "F",
"G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
"W", "X", "Y", "Z" };
        public string[] specialSymbols = new string[] { "#", "!", "$", ";", "_", "&",
"^", "%", "&", "*", "(", ")", "{", "}", "[", "]" };
        public const int USE_DIGITS = 1;
        public const int USE_LOWERCASE_LETTERS = 2;
        public const int USE_UPPERCASE_LETTERS = 3;
        public const int USE_SPECIAL_SYMBOLS = 4;


        private void LoadSettings()
        {
            CheckBoxUseDigits.Checked = Settings.Default.IsUseDigits;
            CheckBoxUseSpecialSymbols.Checked =
           Settings.Default.IsUseSpecialSymbols;
            CheckBoxUseUppercaseLetters.Checked =
           Settings.Default.IsUseUppercaseLetters;
            CheckBoxUseLowercaseLetters.Checked =
           Settings.Default.IsUseLowercaseLetters;
            TrackBarPasswordLength.Value = Settings.Default.PasswordLength;
            UpdatePasswordLengthValue();
        }

        private void UpdatePasswordLengthValue()
        {
            LabelPasswordLengthValue.Text =
           TrackBarPasswordLength.Value.ToString();

        }

        private void SaveSettings()
        {
            Settings.Default.IsUseDigits = CheckBoxUseDigits.Checked;
            Settings.Default.IsUseSpecialSymbols =
           CheckBoxUseSpecialSymbols.Checked;
            Settings.Default.IsUseUppercaseLetters =
           CheckBoxUseUppercaseLetters.Checked;
            Settings.Default.IsUseLowercaseLetters =
           CheckBoxUseLowercaseLetters.Checked;
            Settings.Default.PasswordLength = TrackBarPasswordLength.Value;
            Settings.Default.Save();
        }


        private void CheckPasswordStrength()
        {
            bool isLengthGreaterThan7Symbols = TrackBarPasswordLength.Value >=
           8;
            bool isUsedAllSymbols = CheckBoxUseDigits.Checked &&
           CheckBoxUseSpecialSymbols.Checked &&
           CheckBoxUseLowercaseLetters.Checked &&
           CheckBoxUseUppercaseLetters.Checked;
            bool isStrongPassword = isLengthGreaterThan7Symbols &&
           isUsedAllSymbols;
            LabelWarningMessageTitle.Visible = !isStrongPassword;
            LabelWarningMessage.Visible = !isStrongPassword;
        }

        private void EnableDisableGeneratePasswordButton()
        {
            ButtonGeneratePassword.Enabled = CheckBoxUseDigits.Checked ||
           CheckBoxUseLowercaseLetters.Checked ||
           CheckBoxUseUppercaseLetters.Checked ||
           CheckBoxUseSpecialSymbols.Checked;
            CheckPasswordStrength();
        }

        public FrmPasswordGenerator()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private string GetGeneratedPassword(int passwordLength)
        {
            StringBuilder sbPassword = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < passwordLength; i++)
            {
                int randomArrayNumber;
                do
                {
                    randomArrayNumber = random.Next(1, 5);
                } while (IsNeedToSkip(randomArrayNumber));
                switch (randomArrayNumber)
                {
                    case USE_DIGITS:
                        int randomDigitIndex = random.Next(0, digits.Length);
                        sbPassword.Append(digits[randomDigitIndex]);
                        break;
                    case USE_LOWERCASE_LETTERS:
                        int randomLowercaseLetterIndex = random.Next(0,
                       lowercaseLetters.Length);

                        sbPassword.Append(lowercaseLetters[randomLowercaseLetterIndex]);
                        break;
                    case USE_UPPERCASE_LETTERS:
                        int randomUppercaseLetterIndex = random.Next(0,
                       uppercaseLetters.Length);

                        sbPassword.Append(uppercaseLetters[randomUppercaseLetterIndex]);
                        break;
                    case USE_SPECIAL_SYMBOLS:
                        int randomSpecialSymbolIndex = random.Next(0,
                       specialSymbols.Length);

                        sbPassword.Append(specialSymbols[randomSpecialSymbolIndex]);
                        break;
                }
            }
            return sbPassword.ToString();
        }

        private bool IsNeedToSkip(int arrayNumber)
        {
            if (arrayNumber == USE_DIGITS && !CheckBoxUseDigits.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_LOWERCASE_LETTERS &&
           !CheckBoxUseLowercaseLetters.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_UPPERCASE_LETTERS &&
           !CheckBoxUseUppercaseLetters.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_SPECIAL_SYMBOLS &&
           !CheckBoxUseSpecialSymbols.Checked)
            {
                return true;
            }
            return false;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LabelPasswordLength_Click(object sender, EventArgs e)
        {

        }

        private void FrmPasswordGenerator_Load(object sender, EventArgs e)
        {
            LoadSettings();
            EnableDisableGeneratePasswordButton();
            CheckPasswordStrength();

        }

        private void SaveSettingsAndExitApp()
        {
            SaveSettings();
            Application.Exit();
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void ButtonClearPassword_Click(object sender, EventArgs e)
        {
            TextBoxGeneratedPassword.Text = "";
        }

        private void TimerShowLabelCopiedToClipboard_Tick(object sender, EventArgs e)
        {

            LabelPasswordCopiedToClipboard.Hide();
            TimerShowLabelCopiedToClipboard.Stop();


        }

        private void ButtonGeneratePassword_Click(object sender, EventArgs e)
        {
            LabelPasswordCopiedToClipboard.Hide();
            TimerShowLabelCopiedToClipboard.Stop();
            int passwordLength = TrackBarPasswordLength.Value;
            TextBoxGeneratedPassword.Text =
           GetGeneratedPassword(passwordLength);
            Clipboard.SetText(TextBoxGeneratedPassword.Text);
            LabelPasswordCopiedToClipboard.Show();
            TimerShowLabelCopiedToClipboard.Start();

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            SaveSettingsAndExitApp();
        }

        private void FrmPasswordGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsAndExitApp();
        }

        private void TextBoxGeneratedPassword_TextChanged(object sender, EventArgs e)
        {
            ButtonClearPassword.Enabled = TextBoxGeneratedPassword.TextLength > 0;

        }

        private void TrackBarPasswordLength_Scroll(object sender, EventArgs e)
        {
            UpdatePasswordLengthValue();
        }
    }
}
