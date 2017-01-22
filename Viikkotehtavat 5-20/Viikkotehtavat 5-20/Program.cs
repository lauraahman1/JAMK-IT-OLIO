using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna aika sekuntteina: ");
            string line = Console.ReadLine();
            int sekuntit;
            bool result = Int32.TryParse(line, out sekuntit);
            if (result)
            {
                int tunti = sekuntit / 3600;
                int minuutti = sekuntit / 60 - tunti * 60;
                int sekuntti = sekuntit % 60;
                Console.WriteLine(tunti + " tuntia " + minuutti + " minuuttia " + sekuntti + " sekunttia");
            }

            Console.ReadLine();
        }
    }
}

