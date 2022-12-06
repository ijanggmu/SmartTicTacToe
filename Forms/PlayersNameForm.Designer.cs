namespace SmartTicTacToe
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
            this.Play = new System.Windows.Forms.Button();
            this.PlayPlayerTwoFirst = new System.Windows.Forms.Button();
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
            this.playerTwo.Location = new System.Drawing.Point(31, 85);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(76, 22);
            this.playerTwo.TabIndex = 1;
            this.playerTwo.Text = "Player 2";
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Location = new System.Drawing.Point(139, 49);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.Size = new System.Drawing.Size(179, 22);
            this.playerOneTextBox.TabIndex = 2;
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Location = new System.Drawing.Point(139, 85);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(179, 22);
            this.playerTwoTextBox.TabIndex = 3;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(334, 124);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 4;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.PlayClick);
            // 
            // PlayPlayerTwoFirst
            // 
            this.PlayPlayerTwoFirst.Location = new System.Drawing.Point(165, 124);
            this.PlayPlayerTwoFirst.Name = "PlayPlayerTwoFirst";
            this.PlayPlayerTwoFirst.Size = new System.Drawing.Size(163, 23);
            this.PlayPlayerTwoFirst.TabIndex = 5;
            this.PlayPlayerTwoFirst.Text = "Play Player 2 First";
            this.PlayPlayerTwoFirst.UseVisualStyleBackColor = true;
            this.PlayPlayerTwoFirst.Click += new System.EventHandler(this.PlayPlayerTwoFirstClick);
            // 
            // PlayersNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 170);
            this.Controls.Add(this.PlayPlayerTwoFirst);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.playerTwoTextBox);
            this.Controls.Add(this.playerOneTextBox);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Name = "PlayersNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayesNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerOne;
        private System.Windows.Forms.Label playerTwo;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button PlayPlayerTwoFirst;
    }
}