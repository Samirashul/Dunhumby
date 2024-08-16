using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal class Repository : iRepository
    {

        /*
        As you can see, these have been mocked for our purposes as there is no db to work with. These can however be updated with names.
        */

        public void AddPlayer(string player)
        {
            //this would be a put-type action, ensuring that the player name exists
        }

        public int GetVictoriesByName(string player)
        {
            return 0;
            //returns the count of all the games where this player was X and the victory code was 0 or this player was O and code was 1
        }

        public int GetLossesByName(string player)
        {
            return 0;
            //returns the count of all the games where this player was X and the victory code was 1 or this player was O and code was 0
        }

        public int GetTiesByName(string player)
        {
            return 0;
            //returns the count of all the games where this player was X and the victory code was 2 or this player was O and code was 2
        }

        public void AddGameRecord(GameRecord record)
        { 
            //sends the record to update the GamesRecords table
        }

        public bool AddName(string player)
        {
            return true;
        }

    }
}
