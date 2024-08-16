using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dunnhumby
{
    internal class NameHandler : iNameHandler
    {
        public string GetName()
        { 
            string name = Console.ReadLine();
            if (name.Length > 12)
            {
                //Console.Clear();
                Console.WriteLine("A name must be 12 characters or less!");
                return GetName();
            }
            if (name.Length == 0)
            {
                //Console.Clear();
                Console.WriteLine("A name must have at least 1 character!");
                return GetName();
            }
            if (!Regex.Match(name, "^[A-Za-z1-9]+$").Success)
            {
                Console.WriteLine("A name can only contain alphanumeric characters!");
                return GetName();
            }
            Repository repository = new Repository();
            repository.AddPlayer(name);
            return name;
        }


        private bool isNameValid(string s)
        {

            return true;
        }
    }
}
