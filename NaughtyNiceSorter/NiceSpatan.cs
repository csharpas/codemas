using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaughtyNiceSorter
{
    public class NiceSpatan : Spartan

    {
        static private List<string> presents = new List<string>
        {
            "Playstation 5",
            "Pony",
            "Chocolate Frog"
        };

        public NiceSpatan(string name, string location)
        {

        this.Name = name;
        this.Location = location;

    }
      
        public override void DecidedPresent()
        {
            Present = $"{presents[rnd.Next(0,3)]}";
        }
    }
}
