using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Ikkuna
    {
        //properties=ominaisuudet
        public float Leveys { get; set; }
        public float Korkeus { get; set; }
        public float Pintaala
        { 
         get { return Leveys * Korkeus; }
            //methods = metodit
        }
        public float Piiri
        {
            get { return 2 * (Leveys + Korkeus); }
            
        }

        //methods = metodit
        //constructors = konstruktori, 'rakentajat'
        public Ikkuna ()
        { //tämä on ns. oletuskonstruktori
        }
        public Ikkuna(float leveys, float korkeus)
        {
            Korkeus = korkeus;
            Leveys = leveys;
        }
        public float LaskeaPintaala()
        {
            return Leveys * Korkeus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOIkkunaDemo();
        }
        static void OOIkkunaDemo()
        {
            //ohjelma laskee ikkunan pinta-alan ja piirin
            float Leveys = 0;
            float Korkeus = 0;
            float Ala, Piiri = 0;
            //Kysytään käyttäjältä mitat
            Console.WriteLine("Lasken ikkunan pinta-alan ja piirin, syötä ikkunan leveys millimetreinä");
            Leveys = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna korkeus millimetreinä");
            Korkeus = float.Parse(Console.ReadLine());
            //Lasketaan pinta-ala ja piiri, ja ilmoitetaan ne

            Ala = Leveys * Korkeus;
            Piiri = 2 * (Leveys + Korkeus);
            Console.WriteLine("Ikkunan ala {0} ja piiri {1}", Ala, Piiri); //Ensimmäinen aaltosulku ilmoittaa pilkun jälkeen ensimmäisen tiedot ja toinen pilkun jälkeen toisen tiedon
            //Sama homma olion avulla

            Ikkuna ikkuna = new Ikkuna();
            ikkuna.Leveys = Leveys;
            ikkuna.Korkeus = Korkeus;
            //Ala = ikkuna.LaskeaPintaala();
            Console.WriteLine("Olion avulla laskettu ikkunan ala {0} ja piiri {1}", ikkuna.Pintaala, ikkuna.Piiri);
            //kokeillaan puolta pienemmällä ikkunalla toista konstruktoria
            Ikkuna ikkuna2 = new.Ikkuna(Leveys/2, Korkeus/2);
            Console.WriteLine("Olioikkunan2 avulla laskettu ikkunan ala {0} ja piiri {1}", ikkuna2.Pintaala, ikkuna.Piiri);
        }
    }
}
