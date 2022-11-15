using SmartTicTacToe.Utility;
using System;
using System.Windows.Forms;

namespace SmartTicTacToe
{
    public partial class TicTacToeStartPage : Form
    {
        public TicTacToeStartPage()
        {
            InitializeComponent();
        }

        private void TwoPlayerClick(object sender, EventArgs e)
        {
            PlayersNameForm playerName = new PlayersNameForm();
            playerName.ShowDialog();
        }

        private void RandomBotClick(object sender, EventArgs e)
        {
            PlayersNameForm playerName = new PlayersNameForm((Bot.RandomBot).ToString());
            playerName.ShowDialog();


        }

        private void GuidedBotClick(object sender, EventArgs e)
        {
            PlayersNameForm playerName = new PlayersNameForm((Bot.GuidedBot).ToString());
            playerName.ShowDialog();

        }

    }
}
