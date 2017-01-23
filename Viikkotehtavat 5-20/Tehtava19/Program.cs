using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava19
{
    class Program
    {
        static void Main(string[] args)
        {
            string oikeasana = "Hirsipuu";
            StringBuilder ArvattavaSana = new StringBuilder("_______");
            StringBuilder ArvattavaKirjain = new StringBuilder("");
            int arvauskerrat = 10;
            int arvaukset = 0;
            do
            {
               
                Console.Write("Anna kirjain : ");
                string line = Console.ReadLine().ToUpper();
                if (line.Length == 0)
                {
                    Console.WriteLine("Et antanut kirjainta (Game Over!)");
                    return;
                }
                arvaukset++;
                
                for (int i = 0; i < oikeasana.Length; i++)
                {
                    if (oikeasana[i] == line[0])
                    {
                        ArvattavaSana[i] = line[0];
                    }
                }
                
                ArvattavaKirjain.Append(line[0]);
                Console.WriteLine("Arvattu kirjain: {0}", ArvattavaKirjain.ToString());
                Console.WriteLine("Tehdyt kysymykset: {0} ja väljellä{1}", arvaukset, arvauskerrat - arvaukset);
                Console.WriteLine("Kysytyt kirjaimet: {0}", ArvattavaKirjain.ToString());
            } while (arvaukset < arvauskerrat && !oikeasana.Equals(ArvattavaSana.ToString()));

            if (oikeasana.Equals(ArvattavaSana.ToString()))
            {
                Console.WriteLine("Hienoa! -Selvisit!");
            }
            else
            {
                Console.WriteLine("Sorry - Hirsipuu!");
            }

            Console.ReadLine();
        }
    }
}
