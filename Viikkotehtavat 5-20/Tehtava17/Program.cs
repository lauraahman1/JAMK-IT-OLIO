using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava17
{
    class Program
    {
        //Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sisältö.
        static void Main(string[] args)
        {
            int[] Taulukko1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] Taulukko2 = { 5, 15, 25, 35, 45, 55, 65, 75, 85, 95 };
            int[] Taulukko3 = Taulukko1.Concat(Taulukko2).ToArray();
            Array.Sort(Taulukko3);
            Console.WriteLine("Numerot yhdistetyssä taulukossa:");
            for (int i = 0; i < Taulukko3.Length; i++)
            {
                Console.WriteLine(Taulukko3[i]);
            }
            Console.ReadLine();
        }
    }
}
