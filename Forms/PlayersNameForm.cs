using SmartTicTacToe.Utility;
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
        public PlayersNameForm()
        {
            InitializeComponent();
        }
        public PlayersNameForm(string bot)
        {
            InitializeComponent();
            if (bot == (BotEnum.Bot.RandomBot).ToString())
            {
                playerTwoTextBox.Text = "RandomBot";
                playerTwoTextBox.Enabled = false;
            }
            else if (bot == BotEnum.Bot.GuidedBot.ToString())
            {
                playerTwoTextBox.Text = "GuidedBot";
                playerTwoTextBox.Enabled = false;
            }
            
            
        }
        private void playTwoPlayer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(playerOneTextBox.Text) || String.IsNullOrEmpty(playerTwoTextBox.Text))
            {
                MessageBox.Show("Player Name Cannot be Empty");
            }
            else if (!(String.IsNullOrEmpty(playerOneTextBox.Text)) && playerTwoTextBox.Text == BotEnum.Bot.GuidedBot.ToString())
            {
                TicTacToeMainGameForm.setPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm(BotEnum.Bot.GuidedBot.ToString());
                mainGame.Show();
            }
            else if (!(String.IsNullOrEmpty(playerOneTextBox.Text)) && playerTwoTextBox.Text == BotEnum.Bot.RandomBot.ToString())
            {
                TicTacToeMainGameForm.setPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm(BotEnum.Bot.GuidedBot.ToString());
            }
            else
            {

                TicTacToeMainGameForm.setPlayerName(playerOneTextBox.Text, playerTwoTextBox.Text);
                TicTacToeMainGameForm mainGame = new TicTacToeMainGameForm();
                mainGame.ShowDialog();
                this.Close();

            }
        }

        private void PlayersNameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
