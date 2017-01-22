using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava9
{
    class Program
    {//Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
        static void Main(string[] args)
        {
            int numero;
            int sum = 0;
            bool result;
            do
            {
                Console.Write("Anna luku: ");
                string line = Console.ReadLine();
                result = Int32.TryParse(line, out numero);
                if (result)
                {
                    sum += numero;
                }
            } while (result && numero != 0);
            Console.WriteLine("Annettujen numeroiden summa on: {0}.", sum);
            Console.ReadLine();
        }
    }
}
