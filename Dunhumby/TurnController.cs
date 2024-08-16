using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    public class TurnController : iTurnController
    {
        private WinChecker winChecker = new WinChecker();
        private bool isTurnX = true;

        public string GetTurn()
        { 
            return isTurnX ? "X" : "O";
        }

        public bool NextTurn(Grid g, string playerX, string playerO)
        {
            bool result = winChecker.CheckWin(g, playerX, playerO, isTurnX);
            isTurnX = !isTurnX;
            return result;
        }

        

        private bool IsBoardFull(string[] board)
        {
            if(board.All(x => x.Equals("-")))
                return true;
            return false;
        }

    }
}
