using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava18
{
    class Program
    {
        //Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause). Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.
        static void Main(string[] args)
        {
            Console.Write("Kirjoita lause : ");
            string line = Console.ReadLine();
            int length = line.Length;
            bool palindromi = true;
            for (int i = 0; i < length / 2; i++)
            {
        
                if (line[i] != line[length - i - 1])
                {
                    palindromi = false;
                    break;
                }
            }
            if (palindromi) Console.WriteLine("Kyseessä on palindromi!");
            else Console.WriteLine("Kyseessä ei ole palindromi!");

            Console.ReadLine();
        }
    }
}
