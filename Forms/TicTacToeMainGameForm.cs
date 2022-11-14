using SmartTicTacToe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTacToe
{
    public partial class TicTacToeMainGameForm : Form
    {
        bool turn = true; //true = x turn; false = y turn;
        int turnCount = 0;
        static string Player1, Player2;
        List<Button> emptyButton = new List<Button>();


        public TicTacToeMainGameForm()
        {
            InitializeComponent();
        }
        public TicTacToeMainGameForm(string bot)
        {
            InitializeComponent();
        }
        public static void setPlayerName(string p1,string p2)
        {
            Player1 = p1;
            Player2 = p2;
        }
        private void TikTacToe_Load(object sender, EventArgs e)
        {
            label1.Text = Player1;
            label3.Text = Player2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is SmartTicTakToe");
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
                
            }

            turn = !turn;
            button.Enabled = false;

           
            turnCount = turnCount + 1;

            WinCheck();
        }

        private void WinCheck()
        {
           
            bool win = false;
            #region HorizontalCheck
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
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
                string winner_is = "";
                if (turn)
                {
                    winner_is = Player2;
                    Computer.Text=(Int32.Parse(Computer.Text)+1).ToString();
                }
                else 
                { 
                    winner_is = Player1;
                    Human.Text = (Int32.Parse(Human.Text) + 1).ToString();
                }
                MessageBox.Show("Yay! " + winner_is + "wins!");
                newGameAfterMatchEnd();
            }
            if (turnCount == 9)
            {
                Draw.Text = (Int32.Parse(Draw.Text) + 1).ToString();
                MessageBox.Show("Draw!!");
                newGameAfterMatchEnd();

            }


        }
        private void disableButton()
        {
            
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            Human.Text = "0";
            Computer.Text = "0";
            Draw.Text = "0";
           
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
                catch { }
            }
            

        }
        private void newGameAfterMatchEnd()
        {
            turn = true;
            turnCount = 0;
            foreach (Control c in Controls)
                {
                    try { 
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
                    catch { }
                }
           

        }

        private void ticTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #region Bot
        private void ticTacToeRandomBot()
        {
            Button button = null;
            button = randomMove();
             if (button != null)
            {
                button.PerformClick();

            }
        }
        private void ticTacToeGuidedBot()
        {
            Button move = null;
            //MoveToWin//
            move = bestMoveToWinOrBlock("0");
            if (move == null)
            {
                //MoveToBlock//
                move = bestMoveToWinOrBlock("X");
                if (move == null)
                {
                    move = moveForMiddle();
                    if (move == null)
                    {
                        move = moveForCorners();

                        if (move == null)
                        {
                            move = moveForOpenSpace();
                        }
                    }
                }
            }
            if (move != null) 
            { 
            move.PerformClick();

            }
            
            
        }
        #endregion Bot
        //private bool isSpaceEmptyChecker()
        //{
        //    string[] emptyCell = new string[9];
        //    int empty = 0;
        //    for(var i = 0; i < 9; i++)
        //    {
        //        var isEmpty = Controls[i].Text.ToString();
        //        if (isEmpty == "")
        //        {
        //            emptyCell[i]=(Controls[i].Name.ToString());
        //            empty++;
        //        }
        //    }
        //    if (empty >= 0)
        //    {   
        //        return true;
        //    }
        //    return false;

        //}
        #region BotLogic
        private Button bestMoveToWinOrBlock(string mark)
        {
            // Horinzontal Moves for Block
            
            //H1
            if((A1.Text==mark) && (A2.Text==mark) && (A3.Text == ""))
            {
                return A3;
            }
            if((A1.Text==mark) && (A2.Text=="") && (A3.Text == mark))
            {
                return A2;
            }if((A1.Text=="") && (A2.Text==mark) && (A3.Text == mark))
            {
                return A1;
            }

            //H2

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
            {
                return B3;
            }
            if ((B1.Text == mark) && (B2.Text == "") && (B3.Text == mark))
            {
                return B2;
            }
            if ((B1.Text == "") && (B2.Text == mark) && (B3.Text == mark))
            {
                return B1;
            }

            //H3

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
            {
                return C3;
            }
            if ((C1.Text == mark) && (C2.Text == "") && (C3.Text == mark))
            {
                return C2;
            }
            if ((C1.Text == "") && (C2.Text == mark) && (C3.Text == mark))
            {
                return C1;
            }

            //Vertical
            //V1

            if ((A1.Text == mark) && (B1.Text == mark) &&(C1.Text== ""))
            {
                return C1;
            }
            if ((A1.Text == mark) && (B1.Text == "") &&(C1.Text== mark))
            {
                return B1;
            }
            if ((A1.Text == "") && (B1.Text == mark) &&(C1.Text== mark))
            {
                return A1;
            }

            //V2

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
            {
                return C2;
            }
            if ((A2.Text == mark) && (B2.Text == "") && (C2.Text == mark))
            {
                return B2;
            }
            if ((A2.Text == "") && (B2.Text ==mark ) && (C2.Text == mark))
            {
                return A2;
            }

            //V3

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
            {
                return C3;
            }
            if ((A3.Text == mark) && (B3.Text == "") && (C3.Text == mark))
            {
                return B3;
            }
            if ((A3.Text == "") && (B3.Text ==mark ) && (C3.Text == mark))
            {
                return A3;
            }

            //Diagonal
            
            // \

            if((A1.Text==mark) && (B2.Text==mark) && (C3.Text == ""))
            {
                return C3;
            }
            if ((A1.Text == mark) && (B2.Text == "") && (C3.Text == mark))
            {
                return B2;
            }
            if ((A1.Text == "") && (B2.Text == mark) && (C3.Text == mark))
            {
                return A1;
            }

            // /

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
            {
                return C1;
            }
            if ((A3.Text == mark) && (B2.Text == "") && (C1.Text == mark))
            {
                return B2;
            }
            if ((A3.Text == "") && (B2.Text == mark) && (C1.Text == mark))
            {
                return A3;
            }

            return null;
        }
        private Button moveForMiddle()
        {
            if (B2.Text == "")
            {
                return B2;
            }
            return null;
        }
        private Button moveForCorners()
        {
            if (A1.Text == "0")
            {
                if (A3.Text == "")
                {
                    return A3;
                }
                if (C3.Text == "")
                {
                    return C3;
                }
                if (C1.Text == "")
                {
                    return C1;
                }
            }
            if (A3.Text == "0")
            {
                if (A1.Text == "")
                {
                    return A3;
                }
                if (C3.Text == "")
                {
                    return C3;
                }
                if (C1.Text == "")
                {
                    return C1;
                }
            }
            if (C3.Text == "0")
            {
                if (A3.Text == "")
                {
                    return A3;
                }
                if (A1.Text == "")
                {
                    return C3;
                }
                if (C1.Text == "")
                {
                    return C1;
                }
            }
            if (C1.Text == "0")
            {
                if (A3.Text == "")
                {
                    return A3;
                }
                if (C3.Text == "")
                {
                    return C3;
                }
                if (A1.Text == "")
                {
                    return A1;
                }
            }

            if (A3.Text == "")
            {
               return A3;
            }
            if (C3.Text == "")
            {
               return C3;
            }
            if (A1.Text == "")
            {
               return A1;
            }
            if (C1.Text == "")
            {
               return C1;
            }

            return null;
        }
        private Button moveForOpenSpace()
        {
            Button button = null;
            foreach(Control controls in Controls)
            {
                button = controls as Button;
                if (button != null)
                {
                    if (button.Text == "")
                    {
                        return button;
                    }
                }
            }
            return null;
        }
        private List<Button> emptySpaceList()
        {
            List<Button> emptyButton = new List<Button>();
            Button button = null;
            foreach(Control control in Controls)
            {
                button = control as Button;
                if (button != null)
                {
                    if (button.Text == "")
                    {
                        emptyButton.Add(button);
                    }
                }
            }
            return emptyButton;
        }
        private Button randomMove()
        {
            emptyButton = emptySpaceList();
            var maxNumber = (emptyButton.Count() - 1);
            var randomNumber = new Random();
            var result = randomNumber.Next(0, maxNumber);
            
            return emptyButton[result];
        }
        #endregion BotLogic

        private void buttonEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                if (turn)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                    button.Text = "";
                 
            }
        }

        private void resetScore_Click(object sender, EventArgs e)
        {
            Human.Text = "0";
            Computer.Text= "0";
            Draw.Text = "0";
        }
    }
}
