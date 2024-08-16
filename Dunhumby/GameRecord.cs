using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal class GameRecord : iGameRecord
    {
        private string playerX;
        private string playerO;
        //0 is X victory, 1 is Y victory, 2 is tie
        int victory;

        public GameRecord(string x, string o, int victoryCode)
        {
            playerX = x;
            playerO = o;
            victory = victoryCode;
        }
        public string GetPlayerX()
        {
            return playerX;
        }
        public string GetPlayerO()
        {
            return playerO;
        }
        public int GetVictory()
        {
            return victory;
        }
    }
}
