using SmartTicTacToe.Utility;
using SmartTicTacToe.Utility.Enum;
using SmartTicTacToe.Utility.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartTicTacToe
{
    public partial class TicTacToeMainGameForm : Form
    {
        private bool turn = true;
        private int turnCount = 0;
        private static string Player1, Player2;
        private static bool againstRandomBot;
        private static bool againstGuidedbot;
        private List<Button> emptyButton = new List<Button>();
        public Symbol CurrentPlayer { get; set; }

        public TicTacToeMainGameForm()
        {
            InitializeComponent();
        }


        #region Bot
        private void TicTacToeRandomBot()
        {
            Button button = randomMove();
            if (button != null)
            {
                button.PerformClick();

            }
        }
        private void TicTacToeGuidedBot()
        {
            //MoveToWin//
            Button move = bestMoveToWinOrBlock(nameof(Symbol.O)) ?? bestMoveToWinOrBlock(nameof(Symbol.X)) ?? moveForMiddle() ?? moveForCorners() ?? moveForOpenSpace();

            if (move == null)
            {
                return;
            }

            move.PerformClick();
        }
        #endregion Bot

        public static void SetPlayerName(string p1, string p2)
        {
            Player1 = p1;
            Player2 = p2;
        }
        public static void SetOpponentChoice(string opponent)
        {
            if (opponent == nameof(Bot.GuidedBot))
            {
                againstGuidedbot = true;
            }
            else if (opponent == nameof(Bot.RandomBot))
            {
                againstRandomBot = true;
            }
        }
        private void TikTacToeLoad(object sender, EventArgs e)
        {
            label1.Text = Player1;
            label3.Text = Player2;
        }

        private void WinCheck()
        {

            bool win = false;

            #region HorizontalCheck
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                win = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                win = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                win = true;
            #endregion

            #region VerticalCheck
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                win = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                win = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                win = true;
            #endregion

            #region DiagonalCheck
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                win = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                win = true;
            #endregion

            if (win)
            {
                string winner;
                if (turn)
                {
                    winner = Player2;
                    Computer.Text = (Int32.Parse(Computer.Text) + 1).ToString();
                }
                else
                {
                    winner = Player1;
                    Human.Text = (Int32.Parse(Human.Text) + 1).ToString();
                }

                MessageBox.Show(SystemConstant.WinningMessage(winner));
                NewGameAfterMatchEnd();
                return;
            }

            if (turnCount == 9)
            {
                if(Int32.TryParse(Draw.Text,out int number))
                {
                    Draw.Text = (number + 1).ToString();
                }
                else
                {
                    Console.WriteLine(ErrorMessage.IntParseError);
                }
                MessageBox.Show(SystemConstant.DrawMessage);
                NewGameAfterMatchEnd();
            }


        }

        private void NewGameAfterMatchEnd()
        {
            turn = true;
            turnCount = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = String.Empty;

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                 }
            }


        }

        private void ButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            button.Text = turn ? nameof(Symbol.X) : nameof(Symbol.O);

            turn = !turn;
            button.Enabled = false;
            turnCount += 1;

            WinCheck();

            if (turn)
            {
                return;
            }

            if (againstRandomBot)
            {
                TicTacToeRandomBot();
            }
            else if (againstGuidedbot)
            {
                TicTacToeGuidedBot();
            }
        }

        private void ButtonEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!button.Enabled)
            {
                return;
            }

            if (turn)
            {
                button.Text = nameof(Symbol.X);
            }
            else
            {
                button.Text = nameof(Symbol.O);
            }
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = String.Empty;
            }
        }

    }
}
