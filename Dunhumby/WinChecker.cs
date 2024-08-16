using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal class WinChecker : iWinChecker
    {
        private List<int[]> winConditions = new List<int[]>();

        public WinChecker()
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

        public bool CheckWin(Grid g, string playerX, string playerO, bool isCurrentlyPlayerX)
        {
            foreach (int[] pattern in winConditions)
            {
                if (pattern.All(x => g.GetGrid()[x].Equals(isCurrentlyPlayerX ? "X" : "O")))
                {
                    Console.WriteLine($"\nPlayer {(isCurrentlyPlayerX ? playerX : playerO)} wins!");
                    GameRecord record = new GameRecord(playerX, playerO, isCurrentlyPlayerX ? 0 : 1);
                    Repository repository = new Repository();
                    repository.AddGameRecord(record);
                    WriteStats(repository, playerX);
                    WriteStats(repository, playerO);
                    return true;
                }
            }
            if (g.GetGrid().All(x => !x.Equals("-")))
            {
                Console.WriteLine("\nGame ends in a tie!");
                GameRecord record = new GameRecord(playerX, playerO, 2);
                Repository repository = new Repository();
                repository.AddGameRecord(record);
                WriteStats(repository, playerX);
                WriteStats(repository, playerO);
                return true;
            }
            return false;
        }

        private void WriteStats(Repository repository, string x)
        { 
            Console.WriteLine($"{x} has {repository.GetVictoriesByName(x)} wins, {repository.GetLossesByName(x)} losses, and {repository.GetTiesByName(x)} ties!"); 
        }
    }
}
