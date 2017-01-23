using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(100);
            int number;
            int guesses = 0;
            Console.WriteLine("Arvaa luku 0-100 väliltä");
            do
            {
                Console.Write("Arvaa luku: ");
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out number);
                if (result)
                {
                    if (number < randomNumber) Console.WriteLine("Luku on isompi");
                    else if (number > randomNumber) Console.WriteLine("Luku on pienempi");
                    guesses++;
                }
              
            } while (number != randomNumber);
            Console.WriteLine("Hienoa, arvasit luvun" + guesses + "kerralla!");
            Console.ReadLine();
        }
    }
}
