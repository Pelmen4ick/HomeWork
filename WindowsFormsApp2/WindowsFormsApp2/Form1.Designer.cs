namespace WindowsFormsApp2
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonRemoveSelectedElement = new System.Windows.Forms.Button();
            this.ButtonClearList = new System.Windows.Forms.Button();
            this.ButtonAddElement = new System.Windows.Forms.Button();
            this.TextBoxNewElement = new System.Windows.Forms.TextBox();
            this.LabelEvents = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxEvents = new System.Windows.Forms.TextBox();
            this.LabelInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ButtonRemoveSelectedElement
            // 
            this.ButtonRemoveSelectedElement.Location = new System.Drawing.Point(12, 373);
            this.ButtonRemoveSelectedElement.Name = "ButtonRemoveSelectedElement";
            this.ButtonRemoveSelectedElement.Size = new System.Drawing.Size(135, 23);
            this.ButtonRemoveSelectedElement.TabIndex = 1;
            this.ButtonRemoveSelectedElement.Text = "Удалить элемент";
            this.ButtonRemoveSelectedElement.UseVisualStyleBackColor = true;
            this.ButtonRemoveSelectedElement.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonClearList
            // 
            this.ButtonClearList.Location = new System.Drawing.Point(12, 402);
            this.ButtonClearList.Name = "ButtonClearList";
            this.ButtonClearList.Size = new System.Drawing.Size(121, 23);
            this.ButtonClearList.TabIndex = 2;
            this.ButtonClearList.Text = "Очистить список";
            this.ButtonClearList.UseVisualStyleBackColor = true;
            this.ButtonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // ButtonAddElement
            // 
            this.ButtonAddElement.Location = new System.Drawing.Point(410, 131);
            this.ButtonAddElement.Name = "ButtonAddElement";
            this.ButtonAddElement.Size = new System.Drawing.Size(130, 23);
            this.ButtonAddElement.TabIndex = 3;
            this.ButtonAddElement.Text = "Добавить";
            this.ButtonAddElement.UseVisualStyleBackColor = true;
            this.ButtonAddElement.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TextBoxNewElement
            // 
            this.TextBoxNewElement.Location = new System.Drawing.Point(273, 88);
            this.TextBoxNewElement.Multiline = true;
            this.TextBoxNewElement.Name = "TextBoxNewElement";
            this.TextBoxNewElement.Size = new System.Drawing.Size(267, 24);
            this.TextBoxNewElement.TabIndex = 6;
            this.TextBoxNewElement.Text = "Введите элемент для добавления в список";
            this.TextBoxNewElement.TextChanged += new System.EventHandler(this.TextBoxNewElement_TextChanged);
            this.TextBoxNewElement.Enter += new System.EventHandler(this.TextBoxNewElement_Enter);
            this.TextBoxNewElement.Leave += new System.EventHandler(this.TextBoxNewElement_Leave);
            // 
            // LabelEvents
            // 
            this.LabelEvents.AutoSize = true;
            this.LabelEvents.Location = new System.Drawing.Point(259, 164);
            this.LabelEvents.Name = "LabelEvents";
            this.LabelEvents.Size = new System.Drawing.Size(51, 13);
            this.LabelEvents.TabIndex = 8;
            this.LabelEvents.Text = "События";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Очистить логи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TextBoxEvents
            // 
            this.TextBoxEvents.Location = new System.Drawing.Point(262, 183);
            this.TextBoxEvents.Multiline = true;
            this.TextBoxEvents.Name = "TextBoxEvents";
            this.TextBoxEvents.ReadOnly = true;
            this.TextBoxEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxEvents.Size = new System.Drawing.Size(392, 226);
            this.TextBoxEvents.TabIndex = 11;
            this.TextBoxEvents.TextChanged += new System.EventHandler(this.TextBoxEvents_TextChanged);
            // 
            // LabelInfo
            // 
            this.LabelInfo.Location = new System.Drawing.Point(273, 30);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.ReadOnly = true;
            this.LabelInfo.Size = new System.Drawing.Size(267, 20);
            this.LabelInfo.TabIndex = 12;
            this.LabelInfo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.TextBoxEvents);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelEvents);
            this.Controls.Add(this.TextBoxNewElement);
            this.Controls.Add(this.ButtonAddElement);
            this.Controls.Add(this.ButtonClearList);
            this.Controls.Add(this.ButtonRemoveSelectedElement);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ButtonRemoveSelectedElement;
        private System.Windows.Forms.Button ButtonClearList;
        private System.Windows.Forms.Button ButtonAddElement;
        private System.Windows.Forms.TextBox TextBoxNewElement;
        private System.Windows.Forms.Label LabelEvents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxEvents;
        private System.Windows.Forms.TextBox LabelInfo;
    }
}

