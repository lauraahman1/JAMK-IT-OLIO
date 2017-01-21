using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 3;
            double sum = 0;
            for (int i = 1; i <= numero; i++)
            {
                Console.Write("Anna numero: ");
                string line = Console.ReadLine();
                int numero;
                bool result = Int32.TryParse(line, out numero);
                if (result)
                {
                    sum += numero;
                }
               
                }
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = {0:F2}", (sum / numbers));
            Console.ReadLine();
        }
    }
}
