using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava14
{
    class Program
    { 
//Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:
//        Arvosanajakauma: 
//0:
//1:****
//2:**
//3:******
//4:*****
//5:**
        
            static void Main(string[] args)
        {
                int[] pisteet = new int[6];
                int numero;
                bool result;
                Console.WriteLine("Anna arvosana 0-5 väliltä.");
                do
                {
                    Console.Write("Anna pisteet : ");
                    string line = Console.ReadLine();
                    result = Int32.TryParse(line, out numero);
                    if (result)
                    {
                        switch (numero)
                        {
                            case 0: pisteet[0]++; break;
                            case 1: pisteet[1]++; break;
                            case 2: pisteet[2]++; break;
                            case 3: pisteet[3]++; break;
                            case 4: pisteet[4]++; break;
                            case 5: pisteet[5]++; break;
                        }
                    }
                } while (result);
                Console.WriteLine("Arvosanajakauma:");
                for (int i = 0; i < pisteet.Length; i++)
                {
                    Console.Write(i + ":");
                    for (int k = 0; k < pisteet[i]; k++) Console.Write("*");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }