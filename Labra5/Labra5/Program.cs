using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;
namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtava1
            Lab05teht01();
        }
        static void Lab05teht01()
        {
            //Programmed and tested by Laura 7.2.2017
            //testataan Vehicle ja Tyre luokkia
            //Luodaan ensimmäinen ajoneuvo
            Vehicle auto = new JAMK.IT.Vehicle();
            auto.Brand = "BMW";
            auto.Model = "320";
            //ostetaan parit renkaat
            Tyre rinkula = new Tyre();
            rinkula.Branch = "Hankook";
            rinkula.Size = "205/55R16";
            // laitetaan bemariin taakse renkaat
            auto.Addtyre(rinkula);
            auto.Addtyre(rinkula);

            // näytetään auton tiedot
            Console.WriteLine("Autossasi {0} on seuraavat tiedot: {1}", auto.Brand, auto.ToString());

        }
    }
}

