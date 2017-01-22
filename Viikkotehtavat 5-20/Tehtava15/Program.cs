using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava15
{
    class Program
    { //Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Anna luku 4-40 väliltä : ");
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out numero);
            int puu = numero - 2;
            int juuri = numero - puu;
            if (result)
            {
                if (numero < 4)
                {
                    Console.WriteLine("Liian pieni puuksi!");
                    Console.ReadLine();
                    return;
                }
                else if (numero > 40)
                {
                    Console.WriteLine("Liian iso puuksi!");
                    Console.ReadLine();
                    return;
                }
                // puu
                for (int i = 0; i < puu; i++)
                {
                    int TilanPituus = puu - i;
     
                    for (int tila = 0; tila <= TilanPituus; tila++)
                    {
                        Console.Write(" ");
                    }
            
                    for (int tähti = 0; tähti <= i * 2; tähti++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
        
                for (int i = 0; i < juuri; i++)
                {
                    for (int tila = 0; tila <= puu; tila++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }
          
            Console.ReadLine();
        }
    }
}
