// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Text.RegularExpressions;

namespace Dunnhumby
{

    public class Board
    {
        static Board()
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

        private static readonly List<int[]> winConditions = new List<int[]>();
        public string[] board = ["-", "-", "-", "-", "-", "-", "-", "-", "-"];
        private bool isTurnX = true;

        static void Main(string[] args)
        {
            Board board = new Board();
            if (!board.GamePlay())
            {
                board.ShowGameState();
                Console.WriteLine("Game ends in a tie!");
            }
        }

        public bool CheckWin(string player)
        {
            foreach (int[] i in winConditions)
            {
                if (i.All(position => player.Equals(board[position])))
                    return true;
            }
            return false;
        }

        public void ShowGameState()
        {
            Console.Clear();
            Console.WriteLine(board[0] + " " + board[1] + " " + board[2]);
            Console.WriteLine(board[3] + " " + board[4] + " " + board[5]);
            Console.WriteLine(board[6] + " " + board[7] + " " + board[8]);
        }

        public int GetNextKey(string c)
        {
            if (Regex.Match(c.ToString(), "[1-9]").Success)
            {
                if (board[Int32.Parse(c) - 1].Equals("-"))
                    return Int32.Parse(c) - 1;
                return 9;
            }
            return 10;
        }

        public void PlayerHelp(int i)
        {
            if (i == 10)
                Console.WriteLine("You did not enter a number between 1 and 9 inclusive. Please try again.");
            if (i == 9)
            {
                Console.Write("That space is currently occupied.");
            }
        }

        public bool GamePlay()
        {
            while (true)
            {
                if (!board.Contains("-"))
                    return false;
                int space = 11;
                while (space > 8)
                {
                    ShowGameState();
                    PlayerHelp(space);
                    space = GetNextKey(Console.ReadKey().KeyChar.ToString());
                }

                if (addEntry(space))
                {
                    ShowGameState();

                    Console.WriteLine("Game over! Winner: Player " + GetTurn() + "!");
                    return true;
                }

                if (!board.Contains("-"))
                    return false;
            }


        }

        public bool addEntry(int i)
        {
            board[i] = isTurnX ? "X" : "O";
            if (CheckWin(GetTurn()))
                return true;
            isTurnX = !isTurnX;
            return false;
        }

        public string GetTurn()
        {
            return isTurnX ? "X" : "O";
        }

    }
}