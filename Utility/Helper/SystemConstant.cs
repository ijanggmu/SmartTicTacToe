using System;

namespace SmartTicTacToe.Utility.Helper
{
    public static class SystemConstant
    {
        public const string AboutGame = "This is SmartTicTakToe";
        public const string DrawMessage = "None Wins The Game. Draw";
        public const string DefaultScoreBoard = "0";
        public static string WinningMessage(String winner)
        {
            return $"{winner} Win the Game";
        }


    }
}
