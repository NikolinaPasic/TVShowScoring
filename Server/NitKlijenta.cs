using Domain;
using Domen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class NitKlijenta
    {
        private Socket klijent;
        public Korisnik korisnik;
        private FrmServer frmServer;
        private NetworkStream tok;
        private BinaryFormatter formatter = new BinaryFormatter();
        private bool kraj;
        private List<string> ulogovani;
        public NitKlijenta(Socket klijent, FrmServer frmServer)
        {
            this.klijent = klijent;
            this.frmServer = frmServer;
            this.tok = new NetworkStream(klijent);
            ulogovani = new List<string>();
        }

        internal void Obradjuj()
        {
            kraj = false;
            while (!kraj)
            {
                try
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(tok);
                    Odgovor odgovor = new Odgovor();
                    switch (zahtev.Operacija)
                    {
                        case Operacija.PrijaviKorisnika:
                            odgovor = PrijaviKorisnika((Korisnik)zahtev.Objekat);
                            break;
                        case Operacija.RegistrujNovogKorisnika:
                            odgovor = RegistrujNovogKorisnika((Korisnik)zahtev.Objekat);
                            break;
                        case Operacija.VratiGlumce:
                            odgovor = VratiGlumce();
                            break;
                        case Operacija.DodajGlumca:
                            odgovor = DodajGlumca((Glumac)zahtev.Objekat);
                            break;
                       case Operacija.IzmeniGlumca:
                           odgovor = IzmeniGlumca((Glumac)zahtev.Objekat);
                           break;
                        case Operacija.DodajSeriju:
                            odgovor = DodajSeriju((Serija)zahtev.Objekat);
                            break;
                        case Operacija.VratiSerije:
                            odgovor = VratiSerije();
                            break;
                        case Operacija.VratiZanrove:
                            odgovor = VratiZanrove();
                            break;
                        case Operacija.ObrisiSeriju:
                            odgovor = ObrisiSeriju((Serija)zahtev.Objekat);
                            break;
                        case Operacija.IzmeniSeriju:
                            odgovor = IzmeniSeriju((Serija)zahtev.Objekat);
                            break;
                        case Operacija.VratiSerijuPoKriterijumu:
                            odgovor = VratiSerijuPoKriterijumu((Serija)zahtev.Objekat);
                            break;
                        case Operacija.VratiGlumcePoKriterijumu:
                            odgovor = VratiGlumcePoKriterijumu((Glumac)zahtev.Objekat);
                            break;
                        case Operacija.VratiTipove:
                            odgovor = VratiTipove();
                            break;
                        case Operacija.DodajRecenziju:
                            odgovor = DodajRecenziju((Iskustvo)zahtev.Objekat);
                            break;
                    }
                    Salji(odgovor);
                }
                catch (ThreadInterruptedException e)
                {
                    kraj = false;
                }
                catch (IOException e)
                {
                    kraj = false;

                }
            }
        }

       

        private Odgovor DodajRecenziju(Iskustvo objekat)
        {

            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.DodajRecenziju(objekat);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor VratiTipove()
        {
            List<TipOcene> lista = new List<TipOcene>();
            Odgovor odgovor = new Odgovor();
            lista = Controller.Controller.Instance.VratiListuTipovaOcene();
            odgovor.Objekat = lista;

            if (lista == null) {
                odgovor.Signal = Signal.Error;
              
            }
            else {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor VratiGlumcePoKriterijumu(Glumac objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.VratiGlumcePoKriterijumu(objekat);
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor VratiSerijuPoKriterijumu(Serija objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.VratiSerijuPoKriterijumu(objekat);
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

      

        private Odgovor IzmeniSeriju(Serija serija)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Controller.Controller.Instance.IzmenaSerije(serija);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor ObrisiSeriju(Serija objekat)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Controller.Controller.Instance.ObrisiSeriju(objekat);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;

            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor VratiSerije()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.VratiListuSerija();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }
        private Odgovor VratiZanrove()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.VratiListuZanrova();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }
        private Odgovor DodajSeriju(Serija objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.DodajSeriju(objekat);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor IzmeniGlumca(Glumac glumac)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Controller.Controller.Instance.IzmeniGlumca(glumac);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }

        private Odgovor VratiGlumce()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.VratiGlumce();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }
        private Odgovor DodajGlumca(Glumac objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.DodajGlumca(objekat);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor RegistrujNovogKorisnika(Korisnik objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Controller.Controller.Instance.RegistrujNovogKorisnika(objekat);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }

        private Odgovor PrijaviKorisnika(Korisnik objekat)
        {
          
            korisnik = Controller.Controller.Instance.PrijaviKorisnika(objekat);
            Odgovor odgovor = new Odgovor();
            foreach (var item in ulogovani)
            {
                if (item == objekat.Username)
                {
                    odgovor.Objekat = objekat;
                    return odgovor;
                }
            }
            if (korisnik == null)
            {
                odgovor.Signal = Signal.Error;
                odgovor.Poruka = "Nije pronadjen korisnik";
                odgovor.Objekat = new Korisnik();
            }
            else
            {
                odgovor.Signal = Signal.Ok;
                odgovor.Poruka = "Pronadjen je korisnik";
                odgovor.Objekat = korisnik;
                ulogovani.Add(korisnik.Username);
            }
            return odgovor;
        }
        

        private void Salji(Odgovor odgovor)
        {
            formatter.Serialize(tok, odgovor);
        }
        internal void Ugasi()
        {
            Salji(new Odgovor { Signal = Signal.KrajServer });
            Zavrsi();
        }

        internal void Zavrsi()
        {
            kraj = true;
           
                klijent.Shutdown(SocketShutdown.Both);
                klijent.Disconnect(false);
                klijent.Close();
            
        }
    }
}
