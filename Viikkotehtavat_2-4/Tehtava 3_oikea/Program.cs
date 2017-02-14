using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_3_oikea
{
    class Program
    {
        static void Main(string[] args);
        
            class Nisakas
        {
            //properties
            public int Ika { get; set; }

            //constructors
            public Nisakas()
            {
                //default constructor
            }
            public Nisakas(int ika)
            {
                Ika = ika;
            }
            //methods
            public void Liiku();
            public void setIka();


        }
        class Ihminen : Nisakas //luodaan aliluokka Nisakkaasta
        {
            //properties
            public const int maxIka = 100;
            public const int minIka = 0;
            public int countIka = 0;
            public int Paino { get; set; }
            public int Pituus { get; set; }
            public string Nimi { get; set; }
            //tyypitetty lista joka on dynaaminen
            public List<Ihminen> Vuodet { get; }
            //constructors
            public Ihminen()
            {
                //default
            }
            public Ihminen(int paino, int pituus, string nimi)
            {
                Paino = paino;
                Pituus = pituus;
                Nimi = nimi;
            }
            //methods

            public override void Liiku()
            {
            }
            public override void setIka()
            {
                Ika++;
            }
            public override string ToString()
            {
                return "Nimi: " + Nimi + " Paino: " + Paino + " Pituus: " + Pituus + " Ikä: " + Ika;
            }
        }
        class Vauva : Ihminen
        {
            public string Vaippa { get; set; }

            public override void Liiku()
            {
                Console.WriteLine("Konttaa");
            }
            public override string ToString()
            {
                return "Nimi: " + Nimi + " Paino: " + Paino + " Pituus: " + Pituus + " Ikä: " + Ika + " Vaippa: " + Vaippa;
            }

        }
        class Aikuinen : Ihminen
        {
            public string Auto { get; set; }
            public override void Liiku()
            {
                Console.WriteLine("Kävelee");
            }
            public override string ToString()
            {
                return "Nimi: " + Nimi + " Paino: " + Paino + " Pituus: " + Pituus + " Ikä: " + Ika + " Auto: " + Auto;
            }
        }
    }
}


    

