using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal interface iGameRecord
    {
        string GetPlayerX();
        string GetPlayerO();
        int GetVictory();
    }
}
