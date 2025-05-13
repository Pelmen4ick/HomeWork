
namespace WinFormsApp_SaveLoadFragments
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.radioButton_SaveAs = new System.Windows.Forms.RadioButton();
            this.radioButton_Load = new System.Windows.Forms.RadioButton();
            this.button_Close = new System.Windows.Forms.Button();
            this.checkBox_Swap = new System.Windows.Forms.CheckBox();
            this.button_LoadNew = new System.Windows.Forms.Button();
            this.button_SaveAll = new System.Windows.Forms.Button();
            this.numericUpDown_Rows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Cols = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cols)).BeginInit();
            this.SuspendLayout();

            // pictureBox
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(560, 300);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;

            // radioButton_SaveAs
            this.radioButton_SaveAs.AutoSize = true;
            this.radioButton_SaveAs.Checked = true;
            this.radioButton_SaveAs.Location = new System.Drawing.Point(12, 318);
            this.radioButton_SaveAs.Name = "radioButton_SaveAs";
            this.radioButton_SaveAs.Size = new System.Drawing.Size(98, 17);
            this.radioButton_SaveAs.TabIndex = 1;
            this.radioButton_SaveAs.TabStop = true;
            this.radioButton_SaveAs.Text = "Save Fragment";
            this.radioButton_SaveAs.UseVisualStyleBackColor = true;

            // radioButton_Load
            this.radioButton_Load.AutoSize = true;
            this.radioButton_Load.Location = new System.Drawing.Point(116, 318);
            this.radioButton_Load.Name = "radioButton_Load";
            this.radioButton_Load.Size = new System.Drawing.Size(97, 17);
            this.radioButton_Load.TabIndex = 2;
            this.radioButton_Load.Text = "Load Fragment";
            this.radioButton_Load.UseVisualStyleBackColor = true;

            // button_Close
            this.button_Close.Location = new System.Drawing.Point(472, 318);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(100, 23);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);

            // checkBox_Swap
            this.checkBox_Swap.AutoSize = true;
            this.checkBox_Swap.Location = new System.Drawing.Point(219, 320);
            this.checkBox_Swap.Name = "checkBox_Swap";
            this.checkBox_Swap.Size = new System.Drawing.Size(80, 17);
            this.checkBox_Swap.TabIndex = 4;
            this.checkBox_Swap.Text = "Swap Mode";
            this.checkBox_Swap.UseVisualStyleBackColor = true;

            // button_LoadNew
            this.button_LoadNew.Location = new System.Drawing.Point(12, 341);
            this.button_LoadNew.Name = "button_LoadNew";
            this.button_LoadNew.Size = new System.Drawing.Size(100, 23);
            this.button_LoadNew.TabIndex = 5;
            this.button_LoadNew.Text = "Load New Image";
            this.button_LoadNew.UseVisualStyleBackColor = true;
            this.button_LoadNew.Click += new System.EventHandler(this.button_LoadNew_Click);

            // button_SaveAll
            this.button_SaveAll.Location = new System.Drawing.Point(118, 341);
            this.button_SaveAll.Name = "button_SaveAll";
            this.button_SaveAll.Size = new System.Drawing.Size(100, 23);
            this.button_SaveAll.TabIndex = 6;
            this.button_SaveAll.Text = "Save All";
            this.button_SaveAll.UseVisualStyleBackColor = true;
            this.button_SaveAll.Click += new System.EventHandler(this.button_SaveAll_Click);

            // numericUpDown_Rows
            this.numericUpDown_Rows.Location = new System.Drawing.Point(264, 342);
            this.numericUpDown_Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Rows.Name = "numericUpDown_Rows";
            this.numericUpDown_Rows.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Rows.TabIndex = 7;
            this.numericUpDown_Rows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_Rows.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);

            // numericUpDown_Cols
            this.numericUpDown_Cols.Location = new System.Drawing.Point(370, 342);
            this.numericUpDown_Cols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Cols.Name = "numericUpDown_Cols";
            this.numericUpDown_Cols.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Cols.TabIndex = 8;
            this.numericUpDown_Cols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_Cols.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rows";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Columns";

            // Form_Main
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Cols);
            this.Controls.Add(this.numericUpDown_Rows);
            this.Controls.Add(this.button_SaveAll);
            this.Controls.Add(this.button_LoadNew);
            this.Controls.Add(this.checkBox_Swap);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.radioButton_Load);
            this.Controls.Add(this.radioButton_SaveAs);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(600, 410);
            this.Name = "Form_Main";
            this.Text = "Image Fragment Editor";
            this.SizeChanged += new System.EventHandler(this.Form_Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton radioButton_SaveAs;
        private System.Windows.Forms.RadioButton radioButton_Load;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.CheckBox checkBox_Swap;
        private System.Windows.Forms.Button button_LoadNew;
        private System.Windows.Forms.Button button_SaveAll;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rows;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }


}


