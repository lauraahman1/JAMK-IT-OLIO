using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava10
{
    class Program
    {//Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) Console.WriteLine("HEP! parillinen numero on {1}.", i, array[i]);
            }
            Console.ReadLine();
        }
    }
}
