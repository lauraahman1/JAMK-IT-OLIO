using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava8
{
    class Program
    { //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
        static void Main(string[] args)
        {
            int numero;
            int numerot = 3;
            int suurin = 0;

            for (int i = 1; i <= numerot; i++)
            {
                Console.Write("Anna numero: ");
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out numero);
                if (result)
                {
                    if (i == 1) suurin = numero;
                    else if (numero > suurin) suurin = numero;
                }
                
            }
            Console.WriteLine("Suurin numero on: " + suurin);
            Console.ReadLine();
        }
    }
}
