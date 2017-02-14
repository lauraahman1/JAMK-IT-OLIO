using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void TestPersonClass()
        {
            // luodaan ns. henkilö henkilörekisteri
            Persons myFriends = new Persons();
            //lisästään muutama kaveri rekisteriin
            Person friend1 = new IT.Person();
            friend1.Firstname = "Kirsi";
            friend1.Lastname = "Kernell";
            friend1.SocialSecurityNumber = "121270-123A";
            //lyhyempi tapa luoda olio ominaisuuksineen
            Person friend2 = new Person { Firstname = "Jack", Lastname = "Russel", SocialSecurityNumber = "140217A111B" };
            Person friend3 = new Person { Firstname = "Mathias", Lastname = "Tötterström", SocialSecurityNumber = "140217A123B" };
            Person friend4 = new Person { Firstname = "Teppo", Lastname = "Testaaja", SocialSecurityNumber = "010101-0010" };
            // lisätään kaverit yksi kerrallaan kaveri-rekisteriin
            myFriends.Add(friend1);
            myFriends.Add(friend2);
            myFriends.Add(friend3);
            myFriends.Add(friend4);
            //näytetään rekisteri
            Console.WriteLine("******* Kaverirekisterisi**********");
            myFriends.ShowPersons();
            //Testataan kaverin hakua
            Console.WriteLine("Anna kaverinumero:");
            string retval = Console.ReadLine();
            int i = 0;
            if (int.TryParse(retval, out i))
            { }
            //huom tämä Get-metodi palauttaa null, jos indexin osoittamaa kaveria ei löydy
            Person searchedFriend = myFriends.Get(int.Parse(retval));
            if (searchedFriend !=null)
            Console.WriteLine(string.Format("Löytyi ystävä nimeltä {0}", searchedFriend.ToString()));

        }

        static void Main(string[] args)
        {
            TestPersonClass();
            {
                Console.WriteLine("Annetulla numerolla ei löytynyt kaveria");
            }
        }
        //testataan kaverin hakua HETUlla
        Console.WriteLine("Anna kaverisi HETU");
        retval = Console.ReadLine();
         Person sp = myFriends.Find(retval);
        if (sp !=null)
       Console.WriteLine(string.Format("Löytyi yksi hetu {0}", sp.ToString()));
        
        else
        Console.WriteLine(string.Format("Annetulla{0} hetulla ei löytynyt kaveria", retval));
    }
}
