namespace ErrorProviderSample
{
    partial class FrmErrorProviderSample
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErrorProviderSample));
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ErrorProviderForName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderForName)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(150, 88);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubmit.TabIndex = 0;
            this.ButtonSubmit.Text = " &Отправить";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(281, 88);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = " &Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(30, 17);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(78, 13);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = " Введите имя:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(64, 46);
            this.TextBoxName.Multiline = true;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(411, 36);
            this.TextBoxName.TabIndex = 3;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // ErrorProviderForName
            // 
            this.ErrorProviderForName.BlinkRate = 500;
            this.ErrorProviderForName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorProviderForName.ContainerControl = this;
            this.ErrorProviderForName.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderForName.Icon")));
            // 
            // FrmErrorProviderSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 123);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmErrorProviderSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Allineed.Ru] Пример работы с элементом ErrorProvider";
            this.Load += new System.EventHandler(this.FrmErrorProviderSample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderForName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.ErrorProvider ErrorProviderForName;
    }
}

