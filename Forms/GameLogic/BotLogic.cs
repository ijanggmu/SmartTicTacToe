using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartTicTacToe
{
    public partial class TicTacToeMainGameForm
    {
        #region BotLogic
        private Button bestMoveToWinOrBlock(string mark)
        {
            // Horinzontal Moves for Block

            //H1
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
            {
                return A3;
            }
            if ((A1.Text == mark) && (A2.Text == "") && (A3.Text == mark))
            {
                return A2;
            }
            if ((A1.Text == "") && (A2.Text == mark) && (A3.Text == mark))
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

            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
            {
                return C1;
            }
            if ((A1.Text == mark) && (B1.Text == "") && (C1.Text == mark))
            {
                return B1;
            }
            if ((A1.Text == "") && (B1.Text == mark) && (C1.Text == mark))
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
            if ((A2.Text == "") && (B2.Text == mark) && (C2.Text == mark))
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
            if ((A3.Text == "") && (B3.Text == mark) && (C3.Text == mark))
            {
                return A3;
            }

            //Diagonal

            // \

            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
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
            foreach (Control controls in Controls)
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
            foreach (Control control in Controls)
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
    }
}
