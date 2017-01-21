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
            int numbers = 3;
            double sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                Console.Write("Anna luku: ");
                string line = Console.ReadLine();
                int number;
                bool result = Int32.TryParse(line, out number);
                if (result)
                {
                    sum += number;
                }
               
            }
            Console.WriteLine("Summa = " + sum);
            Console.WriteLine("Keskiarvo = {0:F2}", (sum / numbers));
            Console.ReadLine();
        }
    }
}
