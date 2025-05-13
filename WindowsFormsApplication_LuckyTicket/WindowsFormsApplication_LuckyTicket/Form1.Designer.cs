
namespace WindowsFormsApplication_LuckyTicket
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.radioButton_VariantDefault = new System.Windows.Forms.RadioButton();
            this.radioButton_VariantTask = new System.Windows.Forms.RadioButton();
            this.button_Check = new System.Windows.Forms.Button();
            this.button_FindAll = new System.Windows.Forms.Button();
            this.listBox_Enumerate = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // textBox_Input
            this.textBox_Input.Location = new System.Drawing.Point(12, 32);
            this.textBox_Input.MaxLength = 6;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(200, 20);
            this.textBox_Input.TabIndex = 0;
            this.textBox_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // radioButton_VariantDefault
            this.radioButton_VariantDefault.AutoSize = true;
            this.radioButton_VariantDefault.Checked = true;
            this.radioButton_VariantDefault.Location = new System.Drawing.Point(6, 19);
            this.radioButton_VariantDefault.Name = "radioButton_VariantDefault";
            this.radioButton_VariantDefault.Size = new System.Drawing.Size(122, 17);
            this.radioButton_VariantDefault.TabIndex = 1;
            this.radioButton_VariantDefault.TabStop = true;
            this.radioButton_VariantDefault.Text = "Стандартный метод";
            this.radioButton_VariantDefault.UseVisualStyleBackColor = true;

            // radioButton_VariantTask
            this.radioButton_VariantTask.AutoSize = true;
            this.radioButton_VariantTask.Location = new System.Drawing.Point(6, 42);
            this.radioButton_VariantTask.Name = "radioButton_VariantTask";
            this.radioButton_VariantTask.Size = new System.Drawing.Size(117, 17);
            this.radioButton_VariantTask.TabIndex = 2;
            this.radioButton_VariantTask.Text = "Метод по варианту";
            this.radioButton_VariantTask.UseVisualStyleBackColor = true;

            // button_Check
            this.button_Check.Location = new System.Drawing.Point(12, 120);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(200, 30);
            this.button_Check.TabIndex = 3;
            this.button_Check.Text = "Проверить вариант";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);

            // button_FindAll
            this.button_FindAll.Location = new System.Drawing.Point(12, 156);
            this.button_FindAll.Name = "button_FindAll";
            this.button_FindAll.Size = new System.Drawing.Size(200, 30);
            this.button_FindAll.TabIndex = 4;
            this.button_FindAll.Text = "Найти все счастливые числа";
            this.button_FindAll.UseVisualStyleBackColor = true;
            this.button_FindAll.Click += new System.EventHandler(this.button_FindAll_Click);

            // listBox_Enumerate
            this.listBox_Enumerate.FormattingEnabled = true;
            this.listBox_Enumerate.HorizontalScrollbar = true;
            this.listBox_Enumerate.Location = new System.Drawing.Point(218, 32);
            this.listBox_Enumerate.Name = "listBox_Enumerate";
            this.listBox_Enumerate.Size = new System.Drawing.Size(250, 420);
            this.listBox_Enumerate.TabIndex = 5;

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите номер билета (6 цифр):";

            // groupBox1
            this.groupBox1.Controls.Add(this.radioButton_VariantDefault);
            this.groupBox1.Controls.Add(this.radioButton_VariantTask);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод проверки";

            // Form_Main
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Enumerate);
            this.Controls.Add(this.button_FindAll);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.textBox_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка счастливых билетов (Вариант 11)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.RadioButton radioButton_VariantDefault;
        private System.Windows.Forms.RadioButton radioButton_VariantTask;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Button button_FindAll;
        private System.Windows.Forms.ListBox listBox_Enumerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


