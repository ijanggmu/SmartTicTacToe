﻿namespace SmartTicTacToe
{
    partial class PlayersNameForm
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
            this.playerOne = new System.Windows.Forms.Label();
            this.playerTwo = new System.Windows.Forms.Label();
            this.playerOneTextBox = new System.Windows.Forms.TextBox();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.playTwoPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerOne
            // 
            this.playerOne.AutoSize = true;
            this.playerOne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOne.Location = new System.Drawing.Point(31, 49);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(76, 22);
            this.playerOne.TabIndex = 0;
            this.playerOne.Text = "Player 1";
            // 
            // playerTwo
            // 
            this.playerTwo.AutoSize = true;
            this.playerTwo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwo.Location = new System.Drawing.Point(31, 95);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(76, 22);
            this.playerTwo.TabIndex = 1;
            this.playerTwo.Text = "Player 2";
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Location = new System.Drawing.Point(139, 49);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.Size = new System.Drawing.Size(185, 22);
            this.playerOneTextBox.TabIndex = 2;
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Location = new System.Drawing.Point(139, 95);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(185, 22);
            this.playerTwoTextBox.TabIndex = 3;
            // 
            // playTwoPlayer
            // 
            this.playTwoPlayer.Location = new System.Drawing.Point(334, 124);
            this.playTwoPlayer.Name = "playTwoPlayer";
            this.playTwoPlayer.Size = new System.Drawing.Size(75, 23);
            this.playTwoPlayer.TabIndex = 4;
            this.playTwoPlayer.Text = "Play";
            this.playTwoPlayer.UseVisualStyleBackColor = true;
            this.playTwoPlayer.Click += new System.EventHandler(this.playTwoPlayer_Click);
            // 
            // PlayersNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 170);
            this.Controls.Add(this.playTwoPlayer);
            this.Controls.Add(this.playerTwoTextBox);
            this.Controls.Add(this.playerOneTextBox);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Name = "PlayersNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayesNameForm";
            this.Load += new System.EventHandler(this.PlayersNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerOne;
        private System.Windows.Forms.Label playerTwo;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Button playTwoPlayer;
    }
}