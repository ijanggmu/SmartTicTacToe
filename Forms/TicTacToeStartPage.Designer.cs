namespace SmartTicTacToe
{
    partial class TicTacToeStartPage
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
            this.GameMode = new System.Windows.Forms.Label();
            this.twoPlayer = new System.Windows.Forms.Label();
            this.RandomBot = new System.Windows.Forms.Label();
            this.GuidedBot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameMode
            // 
            this.GameMode.AutoSize = true;
            this.GameMode.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMode.Location = new System.Drawing.Point(193, 164);
            this.GameMode.Name = "GameMode";
            this.GameMode.Size = new System.Drawing.Size(360, 46);
            this.GameMode.TabIndex = 0;
            this.GameMode.Text = "Choose Game Modes";
            // 
            // twoPlayer
            // 
            this.twoPlayer.AutoSize = true;
            this.twoPlayer.Font = new System.Drawing.Font("PMingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoPlayer.Location = new System.Drawing.Point(96, 259);
            this.twoPlayer.Name = "twoPlayer";
            this.twoPlayer.Size = new System.Drawing.Size(212, 28);
            this.twoPlayer.TabIndex = 1;
            this.twoPlayer.Text = "- Player VS Player";
            this.twoPlayer.Click += new System.EventHandler(this.TwoPlayerClick);
            // 
            // RandomBot
            // 
            this.RandomBot.AutoSize = true;
            this.RandomBot.Font = new System.Drawing.Font("PMingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomBot.Location = new System.Drawing.Point(363, 256);
            this.RandomBot.Name = "RandomBot";
            this.RandomBot.Size = new System.Drawing.Size(278, 28);
            this.RandomBot.TabIndex = 2;
            this.RandomBot.Text = "- Player VS Random Bot";
            this.RandomBot.Click += new System.EventHandler(this.RandomBotClick);
            // 
            // GuidedBot
            // 
            this.GuidedBot.AutoSize = true;
            this.GuidedBot.Font = new System.Drawing.Font("PMingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuidedBot.Location = new System.Drawing.Point(363, 314);
            this.GuidedBot.Name = "GuidedBot";
            this.GuidedBot.Size = new System.Drawing.Size(334, 28);
            this.GuidedBot.TabIndex = 3;
            this.GuidedBot.Text = "- Player VS Guided Logic Bot";
            this.GuidedBot.Click += new System.EventHandler(this.GuidedBotClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 79);
            this.label2.TabIndex = 4;
            this.label2.Text = "Smart TicTacToe";
            // 
            // TicTacToeStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuidedBot);
            this.Controls.Add(this.RandomBot);
            this.Controls.Add(this.twoPlayer);
            this.Controls.Add(this.GameMode);
            this.Name = "TicTacToeStartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToeStartPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameMode;
        private System.Windows.Forms.Label twoPlayer;
        private System.Windows.Forms.Label RandomBot;
        private System.Windows.Forms.Label GuidedBot;
        private System.Windows.Forms.Label label2;
    }
}