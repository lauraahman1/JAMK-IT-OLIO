using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava13
{
    class Program
    { // Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.

        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
    
            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.Write("Anna pisteet {0} : ", (i + 1));
                string line = Console.ReadLine();
                int piste;
                bool result = Int32.TryParse(line, out piste);
                if (result)
                {
                    pisteet[i] = piste;
                }
                 }
           
            Array.Sort(pisteet);
  
            int sum = pisteet[1] + pisteet[2] + pisteet[3];
            Console.WriteLine("Kokonaispisteet ovat: " + sum);

            Console.ReadLine();
        }
    }
}
