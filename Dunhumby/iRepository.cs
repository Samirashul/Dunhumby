using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal interface iRepository
    {
        /*
        This repository system is abstracted to interact with a database with the following tables and schema:
        Games: int id
        Players: int id, nvarchar(12) name (pk)
        GamesRecords: int gameId (fk Games), int victorId (fk Players)
        Normally a repository would be a generic class with type T, but in this program's case it's not necessary.
        */

        bool AddName(string player);
        int GetVictoriesByName(string player);
        int GetLossesByName(string player);
        int GetTiesByName(string player);
        void AddGameRecord(GameRecord record);
    }
}
