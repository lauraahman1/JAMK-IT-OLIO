using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava12
{
    class Program
    {
        //Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
        static void Main(string[] args)
        {
            int[] numerot = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna luku : ");
                string line = Console.ReadLine();
                int luku;
                bool result = Int32.TryParse(line, out luku);
                if (result)
                {
                    numerot[i] = luku;
                }
                
            }
            Console.Write("Luvut ovat: ");
            for (int i = numerot.Length - 1; i >= 0; i--)
            {
                Console.Write(numerot[i]);
                if (i > 0) Console.Write(",");
            }
            Console.ReadLine();
        }
    }
}
