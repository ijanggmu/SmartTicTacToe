namespace SmartTicTacToe
{
    partial class TicTacToeMainGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tikTacToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScore = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Human = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.Computer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tikTacToeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tikTacToeToolStripMenuItem
            // 
            this.tikTacToeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenu,
            this.resetScore,
            this.exitApplicationMenu});
            this.tikTacToeToolStripMenuItem.Name = "tikTacToeToolStripMenuItem";
            this.tikTacToeToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.tikTacToeToolStripMenuItem.Text = "TicTacToe";
            // 
            // newGameMenu
            // 
            this.newGameMenu.Name = "newGameMenu";
            this.newGameMenu.Size = new System.Drawing.Size(169, 26);
            this.newGameMenu.Text = "New Game";
            this.newGameMenu.Click += new System.EventHandler(this.NewGameMenuClick);
            // 
            // resetScore
            // 
            this.resetScore.Name = "resetScore";
            this.resetScore.Size = new System.Drawing.Size(169, 26);
            this.resetScore.Text = "Reset Score";
            this.resetScore.Click += new System.EventHandler(this.ResetScoreClick);
            // 
            // exitApplicationMenu
            // 
            this.exitApplicationMenu.Name = "exitApplicationMenu";
            this.exitApplicationMenu.Size = new System.Drawing.Size(169, 26);
            this.exitApplicationMenu.Text = "Exit";
            this.exitApplicationMenu.Click += new System.EventHandler(this.ExitApplicationMenuClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(72, 76);
            this.A1.Margin = new System.Windows.Forms.Padding(4);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 92);
            this.A1.TabIndex = 8;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.ButtonClick);
            this.A1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(180, 76);
            this.A2.Margin = new System.Windows.Forms.Padding(4);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 92);
            this.A2.TabIndex = 9;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.ButtonClick);
            this.A2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(288, 76);
            this.A3.Margin = new System.Windows.Forms.Padding(4);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 92);
            this.A3.TabIndex = 10;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.ButtonClick);
            this.A3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(72, 176);
            this.B1.Margin = new System.Windows.Forms.Padding(4);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 92);
            this.B1.TabIndex = 11;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.ButtonClick);
            this.B1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(180, 176);
            this.B2.Margin = new System.Windows.Forms.Padding(4);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 92);
            this.B2.TabIndex = 12;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.ButtonClick);
            this.B2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(288, 176);
            this.B3.Margin = new System.Windows.Forms.Padding(4);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 92);
            this.B3.TabIndex = 13;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.ButtonClick);
            this.B3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(72, 276);
            this.C1.Margin = new System.Windows.Forms.Padding(4);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 92);
            this.C1.TabIndex = 14;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.ButtonClick);
            this.C1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(180, 276);
            this.C2.Margin = new System.Windows.Forms.Padding(4);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 92);
            this.C2.TabIndex = 15;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.ButtonClick);
            this.C2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(288, 276);
            this.C3.Margin = new System.Windows.Forms.Padding(4);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 92);
            this.C3.TabIndex = 16;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.ButtonClick);
            this.C3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Draw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Player2";
            // 
            // Human
            // 
            this.Human.AutoSize = true;
            this.Human.Location = new System.Drawing.Point(103, 419);
            this.Human.Name = "Human";
            this.Human.Size = new System.Drawing.Size(14, 16);
            this.Human.TabIndex = 21;
            this.Human.Text = "0";
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Location = new System.Drawing.Point(213, 419);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(14, 16);
            this.Draw.TabIndex = 22;
            this.Draw.Text = "0";
            // 
            // Computer
            // 
            this.Computer.AutoSize = true;
            this.Computer.Location = new System.Drawing.Point(334, 419);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(14, 16);
            this.Computer.TabIndex = 23;
            this.Computer.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Turn:";
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLabel.Location = new System.Drawing.Point(224, 51);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(0, 19);
            this.TurnLabel.TabIndex = 25;
            // 
            // TicTacToeMainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 478);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Human);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicTacToeMainGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TikTacToeLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tikTacToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameMenu;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.Button A1;
        public System.Windows.Forms.Button A2;
        public System.Windows.Forms.Button A3;
        public System.Windows.Forms.Button B1;
        public System.Windows.Forms.Button B2;
        public System.Windows.Forms.Button B3;
        public System.Windows.Forms.Button C1;
        public System.Windows.Forms.Button C2;
        public System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Human;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Label Computer;
        private System.Windows.Forms.ToolStripMenuItem resetScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TurnLabel;
    }
}

