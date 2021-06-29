using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBB;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Korisnik k = new Korisnik {
            //        KorisnikID=1
            //        //Ime = "Jana",
            //        //Prezime = "Milovanovic",
            //        //Username = "jana",
            //        //Password = "jana",
            //        //Email = "jana@gmail.com",
            //        //Administrator = false
            //    };
            //    Zanr z = new Zanr
            //    {
            //        NazivZanra = "Romanticna komedija"
            //    };

            //    Serija s = new Serija {
            //        SerijaID=1,
            //        NazivSerije = "Iznajmljena ljubav",
            //        BrojSezona = 2,
            //        DobitSerije = 6290000,
            //        OpisSerije = "Nagradjena kao najbolja romanticna komedija 2017. godine u Turskoj",
            //        Zanr = new Zanr { ZanrID = 1 }

            //    };
            //    Broker b = new Broker();
            //    b.OpenConnection();



            //    Iskustvo i = new Iskustvo {
            //        RedniBrojIskustva = 1,
            //        Serija = new Serija { SerijaID = 1 }




            //    };
            //    Glumac g = new Glumac { 
            //    Ime="Nikolina",
            //    Prezime="Pasic",
            //    Biografija="nista"

            //    };
            //    Ocena o = new Ocena {
            //        Iskustvo = new Iskustvo { RedniBrojIskustva =1 },
            //        Ocjena =10,
            //     TipOcene= new TipOcene { RbrTipaOcene = 1 }


            //    };
            //    //Console.WriteLine(b.Azuriraj(s));
            //    //b.CloseConnection();

            //    TipOcene T = new TipOcene { 
            //    NazivTipa="Privremena"
            //    };
            //    Uloga u = new Uloga {
            //    Serija= new Serija { SerijaID=1},

            //    Opis="Glavni glumac"
            //    };


            //    //if (b.Obrisi(s) == 1)
            //    //{
            //    //    Console.WriteLine("Yee");

            //    //    Console.ReadLine();

            //    //}

            //    //List<DomenskiObjekat> lista = new List<DomenskiObjekat>();
            //    //lista = b.VratiSve(u);

            //    //foreach (var korisnik in lista)
            //    //{
            //    //    Console.WriteLine(korisnik.ToString());
            //    //}
            //    //b.CloseConnection();
            //    //Console.ReadLine();

            //    if (Kontroler.Instance.DodajGlumca(g) == true)
            //    {

            //        Console.WriteLine("jesam");

            //    }

            //}
            //  Controller.Controller.Instance.DodajGlumca(new Glumac { Ime="Hande",Prezime="Ercel",Biografija="Glumica u Sen cal kapimi"});
            //List<Zanr> serije = (List<Zanr>)Controller.Controller.Instance.VratiListuZanrova();
            //foreach (var item in serije)
            //{
            //    Console.WriteLine( item.ToString());
            //}
            Console.WriteLine(Controller.Controller.Instance.IzmenaSerije(new Serija { SerijaID = 2, NazivSerije = "Sen cal kapimi", BrojSezona = 1, DobitSerije = 2565, OpisSerije = "opos", Zanr = new Zanr { ZanrID = 1 } })); 
        }
    }
}
