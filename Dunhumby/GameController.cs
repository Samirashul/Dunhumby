using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    public class GameController
    {
        public GameController()
        {
            winConditions.Add([0, 3, 6]);
            winConditions.Add([1, 4, 7]);
            winConditions.Add([2, 5, 8]);
            winConditions.Add([0, 1, 2]);
            winConditions.Add([3, 4, 5]);
            winConditions.Add([6, 7, 8]);
            winConditions.Add([0, 4, 8]);
            winConditions.Add([2, 4, 6]);
        }

        private List<int[]> winConditions = new List<int[]>();
        private bool isTurnX = true;

        public string GetTurn()
        { 
            return isTurnX ? "X" : "O";
        }

        public bool NextTurn(string[] board)
        {
            bool result = CheckWin(board);
            isTurnX = !isTurnX;
            return result;
        }

        private bool CheckWin(string[] board)
        {
            string s = GetTurn();
            foreach (int[] pattern in winConditions)
            {
                if (pattern.All(x => board[x].Equals(s)))
                { 
                    Console.WriteLine($"\nPlayer {GetTurn()} wins!");
                    return true;
                }
            }
            if (board.All(x => x.Equals("-")))
            {
                Console.WriteLine("\nGame ends in a tie!");
                return true;
            } 
            return false;
        }

        private bool IsBoardFull(string[] board)
        {
            if(board.All(x => x.Equals("-")))
                return true;
            return false;
        }

    }
}
