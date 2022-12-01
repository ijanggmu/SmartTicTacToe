using SmartTicTacToe.Utility.Helper;
using System;
using System.Windows.Forms;

namespace SmartTicTacToe
{
    public partial class TicTacToeMainGameForm
    {
        #region ToolBar 
        private void NewGameMenuClick(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            TurnLabel.Text = Player1;
            Human.Text = SystemConstant.DefaultScoreBoard;
            Computer.Text = SystemConstant.DefaultScoreBoard;
            Draw.Text = SystemConstant.DefaultScoreBoard;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }


        }
        private void ResetScoreClick(object sender, EventArgs e)
        {
            Human.Text = SystemConstant.DefaultScoreBoard;
            Computer.Text = SystemConstant.DefaultScoreBoard;
            Draw.Text = SystemConstant.DefaultScoreBoard;
        }
        private void ExitApplicationMenuClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(SystemConstant.AboutGame);
        }
        #endregion ToolBar
    }
}
