using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal interface iWinChecker
    {
        bool CheckWin(Grid g, string playerX, string playerO, bool isCurrentlyPlayerX);

    }
}
