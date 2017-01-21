using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Program
    //Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikäsi: ");
            string line = Console.ReadLine();
            int ikä;
            bool result = Int32.TryParse(line, out ikä);
            if (result)
            {
                if (ikä < 17) Console.WriteLine("Alaikäinen");
                else if (ikä >= 18 && ikä <= 65) Console.WriteLine("Aikuinen");
                else Console.WriteLine("Seniori");
            }
            
            Console.ReadLine();
        }
    }
}