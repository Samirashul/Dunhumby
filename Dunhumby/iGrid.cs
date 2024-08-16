using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal interface iGrid
    {
        void Write(string player, int space);

        void Show();

        string[] GetGrid();

    }
}
