﻿namespace TicTacToe {
    partial class FrmTicTacToe {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panelCloseButton = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelCell0_0 = new System.Windows.Forms.Panel();
            this.panelCell0_1 = new System.Windows.Forms.Panel();
            this.panelCell0_2 = new System.Windows.Forms.Panel();
            this.panelCell1_0 = new System.Windows.Forms.Panel();
            this.panelCell1_1 = new System.Windows.Forms.Panel();
            this.panelCell1_2 = new System.Windows.Forms.Panel();
            this.panelCell2_0 = new System.Windows.Forms.Panel();
            this.panelCell2_1 = new System.Windows.Forms.Panel();
            this.panelCell2_2 = new System.Windows.Forms.Panel();
            this.labelNewGameTitle = new System.Windows.Forms.Label();
            this.panelPlayerVsCpu = new System.Windows.Forms.Panel();
            this.labelPlayerVsCpu = new System.Windows.Forms.Label();
            this.panelPlayerVsPlayer = new System.Windows.Forms.Panel();
            this.labelPlayerVsPlayer = new System.Windows.Forms.Label();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.labelPlayer1Score = new System.Windows.Forms.Label();
            this.labelPlayer2Score = new System.Windows.Forms.Label();
            this.labelNowTurnIs = new System.Windows.Forms.Label();
            this.labelWhooseTurn = new System.Windows.Forms.Label();
            this.panelReset = new System.Windows.Forms.Panel();
            this.labelReset = new System.Windows.Forms.Label();
            this.panelNewGame = new System.Windows.Forms.Panel();
            this.labelNewGame = new System.Windows.Forms.Label();
            this.toolTipForButtons = new System.Windows.Forms.ToolTip(this.components);
            this.panelCloseButton.SuspendLayout();
            this.panelPlayerVsCpu.SuspendLayout();
            this.panelPlayerVsPlayer.SuspendLayout();
            this.panelReset.SuspendLayout();
            this.panelNewGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCloseButton
            // 
            this.panelCloseButton.BackColor = System.Drawing.Color.Indigo;
            this.panelCloseButton.Controls.Add(this.labelClose);
            this.panelCloseButton.Location = new System.Drawing.Point(520, 12);
            this.panelCloseButton.Name = "panelCloseButton";
            this.panelCloseButton.Size = new System.Drawing.Size(52, 42);
            this.panelCloseButton.TabIndex = 0;
            this.toolTipForButtons.SetToolTip(this.panelCloseButton, "Выход из игры");
            this.panelCloseButton.Click += new System.EventHandler(this.panelCloseButton_Click);
            this.panelCloseButton.MouseEnter += new System.EventHandler(this.panelCloseButton_MouseEnter);
            this.panelCloseButton.MouseLeave += new System.EventHandler(this.panelCloseButton_MouseLeave);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(14, 11);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 22);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.toolTipForButtons.SetToolTip(this.labelClose, "Выход из игры");
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            // 
            // panelCell0_0
            // 
            this.panelCell0_0.BackColor = System.Drawing.Color.Indigo;
            this.panelCell0_0.Location = new System.Drawing.Point(12, 12);
            this.panelCell0_0.Name = "panelCell0_0";
            this.panelCell0_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_0.TabIndex = 1;
            this.panelCell0_0.Click += new System.EventHandler(this.panelCell0_0_Click);
            this.panelCell0_0.MouseEnter += new System.EventHandler(this.panelCell0_0_MouseEnter);
            this.panelCell0_0.MouseLeave += new System.EventHandler(this.panelCell0_0_MouseLeave);
            // 
            // panelCell0_1
            // 
            this.panelCell0_1.BackColor = System.Drawing.Color.Indigo;
            this.panelCell0_1.Location = new System.Drawing.Point(117, 12);
            this.panelCell0_1.Name = "panelCell0_1";
            this.panelCell0_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_1.TabIndex = 2;
            this.panelCell0_1.Click += new System.EventHandler(this.panelCell0_1_Click);
            this.panelCell0_1.MouseEnter += new System.EventHandler(this.panelCell0_1_MouseEnter);
            this.panelCell0_1.MouseLeave += new System.EventHandler(this.panelCell0_1_MouseLeave);
            // 
            // panelCell0_2
            // 
            this.panelCell0_2.BackColor = System.Drawing.Color.Indigo;
            this.panelCell0_2.Location = new System.Drawing.Point(222, 12);
            this.panelCell0_2.Name = "panelCell0_2";
            this.panelCell0_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell0_2.TabIndex = 3;
            this.panelCell0_2.Click += new System.EventHandler(this.panelCell0_2_Click);
            this.panelCell0_2.MouseEnter += new System.EventHandler(this.panelCell0_2_MouseEnter);
            this.panelCell0_2.MouseLeave += new System.EventHandler(this.panelCell0_2_MouseLeave);
            // 
            // panelCell1_0
            // 
            this.panelCell1_0.BackColor = System.Drawing.Color.Indigo;
            this.panelCell1_0.Location = new System.Drawing.Point(12, 114);
            this.panelCell1_0.Name = "panelCell1_0";
            this.panelCell1_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_0.TabIndex = 4;
            this.panelCell1_0.Click += new System.EventHandler(this.panelCell1_0_Click);
            this.panelCell1_0.MouseEnter += new System.EventHandler(this.panelCell1_0_MouseEnter);
            this.panelCell1_0.MouseLeave += new System.EventHandler(this.panelCell1_0_MouseLeave);
            // 
            // panelCell1_1
            // 
            this.panelCell1_1.BackColor = System.Drawing.Color.Indigo;
            this.panelCell1_1.Location = new System.Drawing.Point(117, 114);
            this.panelCell1_1.Name = "panelCell1_1";
            this.panelCell1_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_1.TabIndex = 5;
            this.panelCell1_1.Click += new System.EventHandler(this.panelCell1_1_Click);
            this.panelCell1_1.MouseEnter += new System.EventHandler(this.panelCell1_1_MouseEnter);
            this.panelCell1_1.MouseLeave += new System.EventHandler(this.panelCell1_1_MouseLeave);
            // 
            // panelCell1_2
            // 
            this.panelCell1_2.BackColor = System.Drawing.Color.Indigo;
            this.panelCell1_2.Location = new System.Drawing.Point(222, 114);
            this.panelCell1_2.Name = "panelCell1_2";
            this.panelCell1_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell1_2.TabIndex = 6;
            this.panelCell1_2.Click += new System.EventHandler(this.panelCell1_2_Click);
            this.panelCell1_2.MouseEnter += new System.EventHandler(this.panelCell1_2_MouseEnter);
            this.panelCell1_2.MouseLeave += new System.EventHandler(this.panelCell1_2_MouseLeave);
            // 
            // panelCell2_0
            // 
            this.panelCell2_0.BackColor = System.Drawing.Color.Indigo;
            this.panelCell2_0.Location = new System.Drawing.Point(12, 216);
            this.panelCell2_0.Name = "panelCell2_0";
            this.panelCell2_0.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_0.TabIndex = 4;
            this.panelCell2_0.Click += new System.EventHandler(this.panelCell2_0_Click);
            this.panelCell2_0.MouseEnter += new System.EventHandler(this.panelCell2_0_MouseEnter);
            this.panelCell2_0.MouseLeave += new System.EventHandler(this.panelCell2_0_MouseLeave);
            // 
            // panelCell2_1
            // 
            this.panelCell2_1.BackColor = System.Drawing.Color.Indigo;
            this.panelCell2_1.Location = new System.Drawing.Point(117, 216);
            this.panelCell2_1.Name = "panelCell2_1";
            this.panelCell2_1.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_1.TabIndex = 4;
            this.panelCell2_1.Click += new System.EventHandler(this.panelCell2_1_Click);
            this.panelCell2_1.MouseEnter += new System.EventHandler(this.panelCell2_1_MouseEnter);
            this.panelCell2_1.MouseLeave += new System.EventHandler(this.panelCell2_1_MouseLeave);
            // 
            // panelCell2_2
            // 
            this.panelCell2_2.BackColor = System.Drawing.Color.Indigo;
            this.panelCell2_2.Location = new System.Drawing.Point(222, 216);
            this.panelCell2_2.Name = "panelCell2_2";
            this.panelCell2_2.Size = new System.Drawing.Size(99, 96);
            this.panelCell2_2.TabIndex = 4;
            this.panelCell2_2.Click += new System.EventHandler(this.panelCell2_2_Click);
            this.panelCell2_2.MouseEnter += new System.EventHandler(this.panelCell2_2_MouseEnter);
            this.panelCell2_2.MouseLeave += new System.EventHandler(this.panelCell2_2_MouseLeave);
            // 
            // labelNewGameTitle
            // 
            this.labelNewGameTitle.AutoSize = true;
            this.labelNewGameTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewGameTitle.ForeColor = System.Drawing.Color.White;
            this.labelNewGameTitle.Location = new System.Drawing.Point(359, 71);
            this.labelNewGameTitle.Name = "labelNewGameTitle";
            this.labelNewGameTitle.Size = new System.Drawing.Size(186, 37);
            this.labelNewGameTitle.TabIndex = 7;
            this.labelNewGameTitle.Text = "Новая игра:";
            // 
            // panelPlayerVsCpu
            // 
            this.panelPlayerVsCpu.BackColor = System.Drawing.Color.SlateBlue;
            this.panelPlayerVsCpu.Controls.Add(this.labelPlayerVsCpu);
            this.panelPlayerVsCpu.Location = new System.Drawing.Point(336, 114);
            this.panelPlayerVsCpu.Name = "panelPlayerVsCpu";
            this.panelPlayerVsCpu.Size = new System.Drawing.Size(236, 60);
            this.panelPlayerVsCpu.TabIndex = 8;
            this.toolTipForButtons.SetToolTip(this.panelPlayerVsCpu, "Выберите, чтобы начать новую игру против компьютера");
            this.panelPlayerVsCpu.Click += new System.EventHandler(this.panelPlayerVsCpu_Click);
            this.panelPlayerVsCpu.MouseEnter += new System.EventHandler(this.panelPlayerVsCpu_MouseEnter);
            this.panelPlayerVsCpu.MouseLeave += new System.EventHandler(this.panelPlayerVsCpu_MouseLeave);
            // 
            // labelPlayerVsCpu
            // 
            this.labelPlayerVsCpu.AutoSize = true;
            this.labelPlayerVsCpu.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerVsCpu.ForeColor = System.Drawing.Color.Cyan;
            this.labelPlayerVsCpu.Location = new System.Drawing.Point(26, 20);
            this.labelPlayerVsCpu.Name = "labelPlayerVsCpu";
            this.labelPlayerVsCpu.Size = new System.Drawing.Size(197, 21);
            this.labelPlayerVsCpu.TabIndex = 0;
            this.labelPlayerVsCpu.Text = "Игрок против компьютера";
            this.toolTipForButtons.SetToolTip(this.labelPlayerVsCpu, "Выберите, чтобы начать новую игру против компьютера");
            this.labelPlayerVsCpu.Click += new System.EventHandler(this.labelPlayerVsCpu_Click);
            this.labelPlayerVsCpu.MouseEnter += new System.EventHandler(this.labelPlayerVsCpu_MouseEnter);
            // 
            // panelPlayerVsPlayer
            // 
            this.panelPlayerVsPlayer.BackColor = System.Drawing.Color.SlateBlue;
            this.panelPlayerVsPlayer.Controls.Add(this.labelPlayerVsPlayer);
            this.panelPlayerVsPlayer.Location = new System.Drawing.Point(336, 180);
            this.panelPlayerVsPlayer.Name = "panelPlayerVsPlayer";
            this.panelPlayerVsPlayer.Size = new System.Drawing.Size(236, 60);
            this.panelPlayerVsPlayer.TabIndex = 9;
            this.toolTipForButtons.SetToolTip(this.panelPlayerVsPlayer, "Выберите, чтобы начать игру вдвоём");
            this.panelPlayerVsPlayer.Click += new System.EventHandler(this.panelPlayerVsPlayer_Click);
            this.panelPlayerVsPlayer.MouseEnter += new System.EventHandler(this.panelPlayerVsPlayer_MouseEnter);
            this.panelPlayerVsPlayer.MouseLeave += new System.EventHandler(this.panelPlayerVsPlayer_MouseLeave);
            // 
            // labelPlayerVsPlayer
            // 
            this.labelPlayerVsPlayer.AutoSize = true;
            this.labelPlayerVsPlayer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerVsPlayer.ForeColor = System.Drawing.Color.Cyan;
            this.labelPlayerVsPlayer.Location = new System.Drawing.Point(42, 20);
            this.labelPlayerVsPlayer.Name = "labelPlayerVsPlayer";
            this.labelPlayerVsPlayer.Size = new System.Drawing.Size(158, 21);
            this.labelPlayerVsPlayer.TabIndex = 0;
            this.labelPlayerVsPlayer.Text = "Игрок против игрока";
            this.toolTipForButtons.SetToolTip(this.labelPlayerVsPlayer, "Выберите, чтобы начать игру вдвоём");
            this.labelPlayerVsPlayer.Click += new System.EventHandler(this.labelPlayerVsPlayer_Click);
            this.labelPlayerVsPlayer.MouseEnter += new System.EventHandler(this.labelPlayerVsPlayer_MouseEnter);
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.labelPlayer1Name.Location = new System.Drawing.Point(327, 255);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(82, 30);
            this.labelPlayer1Name.TabIndex = 10;
            this.labelPlayer1Name.Text = "Игрок:";
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.AutoSize = true;
            this.labelPlayer2Name.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.labelPlayer2Name.Location = new System.Drawing.Point(327, 292);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(143, 30);
            this.labelPlayer2Name.TabIndex = 11;
            this.labelPlayer2Name.Text = "Компьютер:";
            // 
            // labelPlayer1Score
            // 
            this.labelPlayer1Score.AutoSize = true;
            this.labelPlayer1Score.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1Score.ForeColor = System.Drawing.Color.Gold;
            this.labelPlayer1Score.Location = new System.Drawing.Point(532, 255);
            this.labelPlayer1Score.Name = "labelPlayer1Score";
            this.labelPlayer1Score.Size = new System.Drawing.Size(27, 30);
            this.labelPlayer1Score.TabIndex = 12;
            this.labelPlayer1Score.Text = "0";
            // 
            // labelPlayer2Score
            // 
            this.labelPlayer2Score.AutoSize = true;
            this.labelPlayer2Score.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2Score.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelPlayer2Score.Location = new System.Drawing.Point(532, 292);
            this.labelPlayer2Score.Name = "labelPlayer2Score";
            this.labelPlayer2Score.Size = new System.Drawing.Size(27, 30);
            this.labelPlayer2Score.TabIndex = 13;
            this.labelPlayer2Score.Text = "0";
            // 
            // labelNowTurnIs
            // 
            this.labelNowTurnIs.AutoSize = true;
            this.labelNowTurnIs.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNowTurnIs.ForeColor = System.Drawing.Color.White;
            this.labelNowTurnIs.Location = new System.Drawing.Point(327, 331);
            this.labelNowTurnIs.Name = "labelNowTurnIs";
            this.labelNowTurnIs.Size = new System.Drawing.Size(80, 30);
            this.labelNowTurnIs.TabIndex = 14;
            this.labelNowTurnIs.Text = "Ходит:";
            // 
            // labelWhooseTurn
            // 
            this.labelWhooseTurn.AutoSize = true;
            this.labelWhooseTurn.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhooseTurn.ForeColor = System.Drawing.Color.White;
            this.labelWhooseTurn.Location = new System.Drawing.Point(413, 331);
            this.labelWhooseTurn.Name = "labelWhooseTurn";
            this.labelWhooseTurn.Size = new System.Drawing.Size(25, 30);
            this.labelWhooseTurn.TabIndex = 15;
            this.labelWhooseTurn.Text = "?";
            // 
            // panelReset
            // 
            this.panelReset.BackColor = System.Drawing.Color.SlateBlue;
            this.panelReset.Controls.Add(this.labelReset);
            this.panelReset.Location = new System.Drawing.Point(327, 12);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(61, 38);
            this.panelReset.TabIndex = 10;
            this.toolTipForButtons.SetToolTip(this.panelReset, "Сбросить текущий счёт, но не менять режим игры");
            this.panelReset.Click += new System.EventHandler(this.panelReset_Click);
            this.panelReset.MouseEnter += new System.EventHandler(this.panelReset_MouseEnter);
            this.panelReset.MouseLeave += new System.EventHandler(this.panelReset_MouseLeave);
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReset.ForeColor = System.Drawing.Color.Cyan;
            this.labelReset.Location = new System.Drawing.Point(4, 9);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(52, 21);
            this.labelReset.TabIndex = 0;
            this.labelReset.Text = "Сброс";
            this.toolTipForButtons.SetToolTip(this.labelReset, "Сбросить текущий счёт, но не менять режим игры");
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            this.labelReset.MouseEnter += new System.EventHandler(this.labelReset_MouseEnter);
            // 
            // panelNewGame
            // 
            this.panelNewGame.BackColor = System.Drawing.Color.SlateBlue;
            this.panelNewGame.Controls.Add(this.labelNewGame);
            this.panelNewGame.Location = new System.Drawing.Point(394, 12);
            this.panelNewGame.Name = "panelNewGame";
            this.panelNewGame.Size = new System.Drawing.Size(98, 38);
            this.panelNewGame.TabIndex = 11;
            this.toolTipForButtons.SetToolTip(this.panelNewGame, "Начать новую игру и выбрать режим");
            this.panelNewGame.Click += new System.EventHandler(this.panelNewGame_Click);
            this.panelNewGame.MouseEnter += new System.EventHandler(this.panelNewGame_MouseEnter);
            this.panelNewGame.MouseLeave += new System.EventHandler(this.panelNewGame_MouseLeave);
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewGame.ForeColor = System.Drawing.Color.Cyan;
            this.labelNewGame.Location = new System.Drawing.Point(3, 9);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(91, 21);
            this.labelNewGame.TabIndex = 0;
            this.labelNewGame.Text = "Новая игра";
            this.toolTipForButtons.SetToolTip(this.labelNewGame, "Начать новую игру и выбрать режим");
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            this.labelNewGame.MouseEnter += new System.EventHandler(this.labelNewGame_MouseEnter);
            // 
            // FrmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(585, 371);
            this.Controls.Add(this.panelNewGame);
            this.Controls.Add(this.panelReset);
            this.Controls.Add(this.labelWhooseTurn);
            this.Controls.Add(this.labelNowTurnIs);
            this.Controls.Add(this.labelPlayer2Score);
            this.Controls.Add(this.labelPlayer1Score);
            this.Controls.Add(this.labelPlayer2Name);
            this.Controls.Add(this.labelPlayer1Name);
            this.Controls.Add(this.panelPlayerVsPlayer);
            this.Controls.Add(this.panelPlayerVsCpu);
            this.Controls.Add(this.labelNewGameTitle);
            this.Controls.Add(this.panelCell2_2);
            this.Controls.Add(this.panelCell2_1);
            this.Controls.Add(this.panelCell2_0);
            this.Controls.Add(this.panelCell1_2);
            this.Controls.Add(this.panelCell1_1);
            this.Controls.Add(this.panelCell1_0);
            this.Controls.Add(this.panelCell0_2);
            this.Controls.Add(this.panelCell0_1);
            this.Controls.Add(this.panelCell0_0);
            this.Controls.Add(this.panelCloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.FrmTicTacToe_Load);
            this.panelCloseButton.ResumeLayout(false);
            this.panelCloseButton.PerformLayout();
            this.panelPlayerVsCpu.ResumeLayout(false);
            this.panelPlayerVsCpu.PerformLayout();
            this.panelPlayerVsPlayer.ResumeLayout(false);
            this.panelPlayerVsPlayer.PerformLayout();
            this.panelReset.ResumeLayout(false);
            this.panelReset.PerformLayout();
            this.panelNewGame.ResumeLayout(false);
            this.panelNewGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCloseButton;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panelCell0_0;
        private System.Windows.Forms.Panel panelCell0_1;
        private System.Windows.Forms.Panel panelCell0_2;
        private System.Windows.Forms.Panel panelCell1_0;
        private System.Windows.Forms.Panel panelCell1_1;
        private System.Windows.Forms.Panel panelCell1_2;
        private System.Windows.Forms.Panel panelCell2_0;
        private System.Windows.Forms.Panel panelCell2_1;
        private System.Windows.Forms.Panel panelCell2_2;
        private System.Windows.Forms.Label labelNewGameTitle;
        private System.Windows.Forms.Panel panelPlayerVsCpu;
        private System.Windows.Forms.Label labelPlayerVsCpu;
        private System.Windows.Forms.Panel panelPlayerVsPlayer;
        private System.Windows.Forms.Label labelPlayerVsPlayer;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelPlayer1Score;
        private System.Windows.Forms.Label labelPlayer2Score;
        private System.Windows.Forms.Label labelNowTurnIs;
        private System.Windows.Forms.Label labelWhooseTurn;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Panel panelNewGame;
        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.ToolTip toolTipForButtons;
    }
}

