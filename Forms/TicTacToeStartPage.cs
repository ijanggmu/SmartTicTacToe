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

        // When Player Click Player VS Player
        private void TwoPlayerClick(object sender, EventArgs e)
        {
            // Object Initialize of PlayersNameForm Class and displayed it on Dialog 
            //check
            PlayersNameForm playerName = new PlayersNameForm();
            playerName.ShowDialog();
        }

        // When Player Click Player VS Random Bot
        private void RandomBotClick(object sender, EventArgs e)
        {
            // Object Initialize of PlayersNameForm Class with parameter RandomBot  and displayed it on Dialog 

            PlayersNameForm playerName = new PlayersNameForm((Bot.RandomBot).ToString());
            playerName.ShowDialog();

        }
        // When Player Click Player VS Guided Bot
        private void GuidedBotClick(object sender, EventArgs e)
        {
            // Object Initialize of PlayersNameForm Class with parameter Guided Bot  and displayed it on Dialog 

            PlayersNameForm playerName = new PlayersNameForm((Bot.GuidedBot).ToString());
            playerName.ShowDialog();
        }

    }
}
