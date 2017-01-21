using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    /// <summary> 
    //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron)
    /// </summary> 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna pistemäärä: ");
            int score;
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out score);
            if (result)
            {
                switch (score)
                {
                    case 0:
                    case 1: Console.WriteLine("Kouluarvosanasi on 0"); break;
                    case 2:
                    case 3: Console.WriteLine("Kouluarvosanasi on 1"); break;
                    case 4:
                    case 5: Console.WriteLine("Kouluarvosanasi on 2"); break;
                    case 6:
                    case 7: Console.WriteLine("Kouluarvosanasi on 3"); break;
                    case 8:
                    case 9: Console.WriteLine("Kouluarvosanasi on 4"); break;
                    case 10:
                    case 11:
                    case 12: Console.WriteLine("Kouluarvosanasi on 5"); break;
                }
            }
        }
    }            }
           
    

