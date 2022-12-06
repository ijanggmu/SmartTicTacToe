using SmartTicTacToe.Utility;
using SmartTicTacToe.Utility.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TikTacToe;

namespace SmartTicTacToe
{
    public partial class PlayersNameForm : Form
    {
        // When Player Click Player vs Player 
        public PlayersNameForm()
        {
            InitializeComponent();
        }
        
        // When Player Click Player vs RandomBot / Guided Bot
        public PlayersNameForm(string bot)
        {
            InitializeComponent();
            if (bot == nameof(Bot.RandomBot))
            {
                playerTwoTextBox.Text = nameof(Bot.RandomBot);
                playerTwoTextBox.Enabled = false;
            }
            else if (bot == nameof(Bot.GuidedBot))
            {
                playerTwoTextBox.Text = nameof(Bot.GuidedBot);
                playerTwoTextBox.Enabled = false;
            }
            PlayPlayerTwoFirst.Text = "Play Bot First";

        }
        private void PlayClick(object sender, EventArgs e)
        {
            //Validation For Empty Player Name

            if (String.IsNullOrEmpty(playerOneTextBox.Text) || String.IsNullOrEmpty(playerTwoTextBox.Text))
            {
                MessageBox.Show(ErrorMessage.EmptyPlayersNameError);
            }
            else if (!(String.IsNullOrEmpty(playerOneTextBox.Text)) && playerTwoTextBox.Text == nameof(Bot.GuidedBot))
            {
                TicTacToeMainGameForm.SetPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm.botFirst = false;
                // Choose the Guided Bot as  Opponent 
                TicTacToeMainGameForm.SetOpponentChoice(playerTwoTextBox.Text);
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm();
                mainGame.ShowDialog();
                this.Close();
            }
            else if (!(String.IsNullOrEmpty(playerOneTextBox.Text)) && playerTwoTextBox.Text == nameof(Bot.RandomBot))
            {
                TicTacToeMainGameForm.SetPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm.botFirst = false;
                // Choose the Random Bot as  Opponent 
                TicTacToeMainGameForm.SetOpponentChoice(playerTwoTextBox.Text);
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm();
                mainGame.ShowDialog();
                this.Close();
            }
            else
            {
                TicTacToeMainGameForm.SetPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm();
                mainGame.ShowDialog();
                this.Close();

            }
        }

        //When Player two first or Bot First is Clicked
        private void PlayPlayerTwoFirstClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(playerOneTextBox.Text) || String.IsNullOrEmpty(playerTwoTextBox.Text))
            {
                MessageBox.Show(ErrorMessage.EmptyPlayersNameError);
            }
            else if (!(String.IsNullOrEmpty(playerOneTextBox.Text)) && playerTwoTextBox.Text == Bot.GuidedBot.ToString())
            {
                TicTacToeMainGameForm.SetPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm.botFirst = true;
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm();
                TicTacToeMainGameForm.SetOpponentChoice(playerTwoTextBox.Text);
                mainGame.ShowDialog();
                this.Close();
            }
            else if (!(String.IsNullOrEmpty(playerOneTextBox.Text)) && playerTwoTextBox.Text == Bot.RandomBot.ToString())
            {
                TicTacToeMainGameForm.SetPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm.botFirst = true;
                TicTacToeMainGameForm.SetOpponentChoice(playerTwoTextBox.Text);
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm();
                mainGame.ShowDialog();
                this.Close();
            }
            else
            {
                TicTacToeMainGameForm.SetPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm();
                TicTacToeMainGameForm.SetPlayerTwoFirst();
                mainGame.ShowDialog();
                this.Close();

            }
        }
    }
}
