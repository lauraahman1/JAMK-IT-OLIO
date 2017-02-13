using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat_2
{
    public class Jääkaappi
    {
        public int Koko { get; set; }
        public string Väri { get; set; }
        public string Merkki { get; set; }

        public Jääkaappi()
        {
            this.Väri = Väri;
        }
        public Jääkaappi(string merkki)
        {
            this.Merkki = merkki;
        }
        public Jääkaappi(int koko)
        {
            this.Koko = koko;
        }

        public string Sisältö1()
        {
            return "Maitoa, Ruokakermaa, Jauhelihaa";
        }
        public string Sisältö2()
        {
            return "Juustoa, Ilmakuivattua kinkkua, Pizzaa";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teejääkaappi();
        }
        static void Teejääkaappi()
        {
            Jääkaappi munJääkaappi = new Jääkaappi();
            munJääkaappi.Merkki = "Rosenlew";
            munJääkaappi.Väri = "Valkoinen";
            munJääkaappi.Koko = 150;

            Jääkaappi muntoinenJääkaappi = new Jääkaappi();
            muntoinenJääkaappi.Merkki = "Bosch";
            muntoinenJääkaappi.Väri = "Teräs";
            muntoinenJääkaappi.Koko = 165;

            Console.WriteLine("Jääkaappi 1: \n Merkki: {0} \n Väri: {1} \n Koko: {2}L", munJääkaappi.Merkki, munJääkaappi.Väri, munJääkaappi.Koko);
            Console.WriteLine("Jääkaappi 2: \n Merkki: {0} \n Väri: {1} \n Koko: {2}L", muntoinenJääkaappi.Merkki, muntoinenJääkaappi.Väri, muntoinenJääkaappi.Koko);

            Console.WriteLine("Valitse 1 tai 2, tulostaa jääkaapin sisällön");
            string Valinta = Console.ReadLine();
            switch (Valinta)
            {
                case "1":
                    Console.WriteLine("Valitsit {0} merkin jääkaapin, tässä sisältö: {1} ", munJääkaappi.Merkki, munJääkaappi.Sisältö1());
                    break;
                case "2":
                    Console.WriteLine("Valitsit {0} merkin jääkaapin, tässä sisältö: {1} ", muntoinenJääkaappi.Merkki, muntoinenJääkaappi.Sisältö2());
                    break;
            }

        }
    }
}

