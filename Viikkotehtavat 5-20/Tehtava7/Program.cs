using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{ 
    class Program
    {
        // Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
        static void Main(string[] args)
        {
            Console.Write("Anna vuosiluku: ");
            string line = Console.ReadLine();
            int vuosi;
            bool result = Int32.TryParse(line, out vuosi);
            if (result)
            {
                if ((vuosi % 4 == 0 && vuosi % 100 != 0) || vuosi % 400 == 0)
                {
                    Console.WriteLine("Vuosi on karkausvuosi.");
                }
                else
                {
                    Console.WriteLine("Vuosi ei ole karkausvuosi.");
                }
            }
           
            Console.ReadLine();
        }
    }
}
