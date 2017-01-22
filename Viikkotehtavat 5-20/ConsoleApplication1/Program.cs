using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Program
    { //Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
        //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
        static void Main(string[] args)
        {
            double kulutus = 7.02;
            double hinta = 1.595;
            Console.Write("Anna matka kilometreinä: ");
            string line = Console.ReadLine();
            double matka;
            bool result = Double.TryParse(line, out matka);
            if (result)
            {
                double bensa = matka / 100 * kulutus;
                double kulu = bensa * hinta;
                Console.WriteLine("Bensan kulutus {0:F2} litroina.", bensa);
               Console.WriteLine("Kulut ovat {0:F2} euroa.", kulu);
            }
            
            Console.ReadLine();
        }
    }
}
