using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domen;

namespace Korisnicki_interfejs
{
    public class Komunikacija
    {
        private static Komunikacija _instance;
        private Socket klijent;
        private NetworkStream tok;


        private BinaryFormatter formater = new BinaryFormatter();


        private Komunikacija()
        {
        }

        internal bool PoveziSe()
        {
            try
            {

                klijent = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                klijent.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000));
                tok = new NetworkStream(klijent);
                return true;
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        public static Komunikacija Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Komunikacija();
                return _instance;
            }
        }

        internal List<Serija> PronadjiSeriju(Serija serija)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = serija, Operacija = Operacija.VratiSerijuPoKriterijumu };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    Console.WriteLine(odgovor.Objekat.ToString());
                    return (List<Serija>)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }
        }

        internal List<TipOcene> VratiListuTipova()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Operacija = Operacija.VratiTipove };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return (List<TipOcene>)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                    throw;

            }
        }

        internal string Kraj(Korisnik k)
        {
            try
            {
              
                Zahtev zahtev = new Zahtev { Objekat = k, Operacija = Operacija.Kraj };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return odgovor.Poruka;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }
        }

        internal List<Glumac> PronadjiGlumca(Glumac glumac)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = glumac, Operacija = Operacija.VratiGlumcePoKriterijumu };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    Console.WriteLine(odgovor.Objekat.ToString());
                    return (List<Glumac>)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }
        }

        internal bool DodajIskustvo(Iskustvo iskustvo)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = iskustvo, Operacija = Operacija.DodajRecenziju };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.Error:
                        throw new Exception("Server nije dodao recenziju");
                }
                return false;
            }
            catch (Exception)
            {
                throw new Exception("Nije moguca komunikacija sa serverom");
            }

        }

        internal bool IzmeniSeriju(Serija serija)
        {

            try
            {

                Zahtev zahtev = new Zahtev { Objekat = serija, Operacija = Operacija.IzmeniSeriju };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }
        }

        internal bool DodajSeriju(Serija s)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = s, Operacija = Operacija.DodajSeriju };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.Error:
                        throw new Exception("Server nije dodao film");
                }
                return false;
            }
            catch (Exception)
            {
                throw new Exception("Nije moguce zapamtitit seriju");
            }
        }

        internal bool ObrisiSeriju(Serija s)
        {
            try
            {

                Zahtev zahtev = new Zahtev { Objekat = s, Operacija = Operacija.ObrisiSeriju };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }
        }

        internal object vratiListuZanrova()
        {

            try
            {
                Zahtev zahtev = new Zahtev { Operacija = Operacija.VratiZanrove};
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return (List<Zanr>)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }

        }

        internal bool DodajGlumca(Glumac glumac)
        {
            try
            {

                Zahtev zahtev = new Zahtev { Objekat = glumac, Operacija = Operacija.DodajGlumca};
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }

        }
        internal bool IzmeniGlumca(Glumac glumac)
        {
            try
            {

                Zahtev zahtev = new Zahtev { Objekat = glumac, Operacija = Operacija.IzmeniGlumca };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }

        }
        internal List<Glumac> vratiListuGlumaca()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Operacija = Operacija.VratiGlumce };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return (List<Glumac>)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }
        }

        internal object vratiListuSerija()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Operacija = Operacija.VratiSerije };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }

        }

        internal Korisnik PrijaviKorisnika(string username, string pass)
        { 
            try
            {
                Korisnik korisnik = new Korisnik {Username= username, Password= pass };
                Zahtev zahtev = new Zahtev { Objekat = korisnik, Operacija = Operacija.PrijaviKorisnika };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return (Korisnik)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(">>" + ex.Message);
                throw;

            }

        }
        internal Boolean RegistrujSe(Korisnik k)
        {
            try
            {
                
                Zahtev zahtev = new Zahtev { Objekat = k, Operacija = Operacija.RegistrujNovogKorisnika };
                try { formater.Serialize(tok, zahtev); }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Niste povezani sa serverom!!!");
                    Environment.Exit(0);
                }
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska prilikom registracije");
                throw;

            }

        }




    }
}
