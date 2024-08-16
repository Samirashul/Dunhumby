using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    public class Grid : iGrid
    {
        private string[] grid = ["-", "-", "-", "-", "-", "-", "-", "-", "-"];
        private int counter;

        

        public void Write(string player, int space)
        { 
            grid[space] = player;
        }

        public void Show()
        {
            Console.Clear();
            counter = 0;
            grid.ToList().ForEach(x => Console.Write(AddSpace(x)));
            Console.Write("\n");
        }

        public string[] GetGrid()
        { 
            return grid;
        }

        private string AddSpace(string s)
        {
            counter++;
            if (counter % 3 == 1)
                return $"\n {s}";
            return $" {s}";
        }
    }
}
