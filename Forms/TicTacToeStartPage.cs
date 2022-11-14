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
    public partial class TicTacToeStartPage : Form
    {
        public TicTacToeStartPage()
        {
            InitializeComponent();
        }

        private void twoPlayer_Click(object sender, EventArgs e)
        {
            PlayersNameForm playerName = new PlayersNameForm();
            playerName.ShowDialog();
        }

        private void RandomBot_Click(object sender, EventArgs e)
        {
            PlayersNameForm playerName = new PlayersNameForm((BotEnum.Bot.RandomBot).ToString());
            playerName.ShowDialog();


        }

        private void GuidedBot_Click(object sender, EventArgs e)
        {
            PlayersNameForm playerName = new PlayersNameForm((BotEnum.Bot.GuidedBot).ToString());
            playerName.ShowDialog();

        }

        private void TicTacToeStartPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
