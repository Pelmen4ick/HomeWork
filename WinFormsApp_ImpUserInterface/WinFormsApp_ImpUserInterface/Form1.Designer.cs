
namespace WinFormsApp_ImpUserInterface
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

        private void InitializeComponent()
        {
            this.panel_Output = new System.Windows.Forms.Panel();
            this.pictureBox_Formula = new System.Windows.Forms.PictureBox();
            this.label_InputValue = new System.Windows.Forms.Label();
            this.textBox_InputValue = new System.Windows.Forms.TextBox();
            this.vScrollBar_InputValue = new System.Windows.Forms.VScrollBar();
            this.label_Output = new System.Windows.Forms.Label();
            this.label_InputTaskNum = new System.Windows.Forms.Label();
            this.comboBox_TaskNum = new System.Windows.Forms.ComboBox();
            this.button_EvaluateVariant = new System.Windows.Forms.Button();
            this.button_EvaluateAllDefault = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Output
            // 
            this.panel_Output.Controls.Add(this.pictureBox_Formula);
            this.panel_Output.Controls.Add(this.label_InputValue);
            this.panel_Output.Controls.Add(this.textBox_InputValue);
            this.panel_Output.Controls.Add(this.vScrollBar_InputValue);
            this.panel_Output.Controls.Add(this.label_Output);
            this.panel_Output.Location = new System.Drawing.Point(200, 12);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(300, 300);
            this.panel_Output.TabIndex = 0;
            // 
            // pictureBox_Formula
            // 
            this.pictureBox_Formula.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Formula.Name = "pictureBox_Formula";
            this.pictureBox_Formula.Size = new System.Drawing.Size(294, 100);
            this.pictureBox_Formula.TabIndex = 0;
            this.pictureBox_Formula.TabStop = false;
            // 
            // label_InputValue
            // 
            this.label_InputValue.AutoSize = true;
            this.label_InputValue.Location = new System.Drawing.Point(3, 110);
            this.label_InputValue.Name = "label_InputValue";
            this.label_InputValue.Size = new System.Drawing.Size(102, 13);
            this.label_InputValue.TabIndex = 1;
            this.label_InputValue.Text = "Введите значение:";
            // 
            // textBox_InputValue
            // 
            this.textBox_InputValue.Location = new System.Drawing.Point(104, 107);
            this.textBox_InputValue.Name = "textBox_InputValue";
            this.textBox_InputValue.ReadOnly = true;
            this.textBox_InputValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_InputValue.TabIndex = 2;
            // 
            // vScrollBar_InputValue
            // 
            this.vScrollBar_InputValue.Location = new System.Drawing.Point(207, 107);
            this.vScrollBar_InputValue.Name = "vScrollBar_InputValue";
            this.vScrollBar_InputValue.Size = new System.Drawing.Size(17, 20);
            this.vScrollBar_InputValue.TabIndex = 3;
            // 
            // label_Output
            // 
            this.label_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Output.Location = new System.Drawing.Point(3, 140);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(294, 157);
            this.label_Output.TabIndex = 4;
            // 
            // label_InputTaskNum
            // 
            this.label_InputTaskNum.AutoSize = true;
            this.label_InputTaskNum.Location = new System.Drawing.Point(12, 20);
            this.label_InputTaskNum.Name = "label_InputTaskNum";
            this.label_InputTaskNum.Size = new System.Drawing.Size(105, 13);
            this.label_InputTaskNum.TabIndex = 1;
            this.label_InputTaskNum.Text = "Выберите задание:";
            // 
            // comboBox_TaskNum
            // 
            this.comboBox_TaskNum.FormattingEnabled = true;
            this.comboBox_TaskNum.Items.AddRange(new object[] {
            "Задание 1",
            "Задание 2",
            "Задание 3"});
            this.comboBox_TaskNum.Location = new System.Drawing.Point(12, 36);
            this.comboBox_TaskNum.Name = "comboBox_TaskNum";
            this.comboBox_TaskNum.Size = new System.Drawing.Size(150, 21);
            this.comboBox_TaskNum.TabIndex = 2;
            // 
            // button_EvaluateVariant
            // 
            this.button_EvaluateVariant.Location = new System.Drawing.Point(12, 80);
            this.button_EvaluateVariant.Name = "button_EvaluateVariant";
            this.button_EvaluateVariant.Size = new System.Drawing.Size(158, 30);
            this.button_EvaluateVariant.TabIndex = 3;
            this.button_EvaluateVariant.Text = "Вычислить";
            this.button_EvaluateVariant.UseVisualStyleBackColor = true;
            // 
            // button_EvaluateAllDefault
            // 
            this.button_EvaluateAllDefault.Location = new System.Drawing.Point(12, 120);
            this.button_EvaluateAllDefault.Name = "button_EvaluateAllDefault";
            this.button_EvaluateAllDefault.Size = new System.Drawing.Size(158, 30);
            this.button_EvaluateAllDefault.TabIndex = 4;
            this.button_EvaluateAllDefault.Text = "Все расчеты со значениями по умолчанию";
            this.button_EvaluateAllDefault.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 160);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(158, 30);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 324);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_EvaluateAllDefault);
            this.Controls.Add(this.button_EvaluateVariant);
            this.Controls.Add(this.comboBox_TaskNum);
            this.Controls.Add(this.label_InputTaskNum);
            this.Controls.Add(this.panel_Output);
            this.Name = "Form1";
            this.Text = "Вычисление вариантов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.PictureBox pictureBox_Formula;
        private System.Windows.Forms.Label label_InputValue;
        private System.Windows.Forms.TextBox textBox_InputValue;
        private System.Windows.Forms.VScrollBar vScrollBar_InputValue;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Label label_InputTaskNum;
        private System.Windows.Forms.ComboBox comboBox_TaskNum;
        private System.Windows.Forms.Button button_EvaluateVariant;
        private System.Windows.Forms.Button button_EvaluateAllDefault;
        private System.Windows.Forms.Button button_Close;
    }
}


