using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal interface iTurnController
    {
        public string GetTurn();
        public bool NextTurn(Grid g, string playerX, string playerO);
    }
}
