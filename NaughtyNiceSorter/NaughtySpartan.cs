using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NaughtyNiceSorter
{
    public class NaughtySpartan : Spartan
    {

        static private List<string> piecesofcoal = new List<string>
        {
            "Read your programming notes ",
            "Attend class early",
            "No Playstation 5",
            "No Christmass gift"
        };
        
        public NaughtySpartan(string name, string location,string present)
        {

            this.Name = name;
            this.Location = location;
            this.Present = present;

        }
 
        public override void DecidedPresent()   
        {
            Present = $"{piecesofcoal[rnd.Next(0, 4)]}";
 
        }


    }


}
