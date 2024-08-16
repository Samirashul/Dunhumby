using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dunnhumby
{
    public class InputHandler : iInputHandler
    {
        public int GetNextKey(string[] board)
        {
            while (true)
            {
                string s = Console.ReadKey().KeyChar.ToString();

                if (Regex.Match(s.ToString(), "[1-9]").Success)
                {
                    int i = Int32.Parse(s) - 1;
                    if (board[i].Equals("-"))
                        return i;
                    Console.WriteLine($"\nSpace number {i+1} is already occupied. Please choose another.");
                    
                }
                else
                    Console.WriteLine($"\n{s} is not a number between 1 and 9 inclusive.");
            }
        }
    }
}
