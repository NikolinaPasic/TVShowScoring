using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
   public  class Controller
    {
        private static Controller instance;
        private Controller()
        {
                
        }
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }


        public Korisnik PrijaviKorisnika(Korisnik korisnik)
        {
            OpstaSistemskaOperacija operacija = new PrijaviKorisnikaSO();
            operacija.Izvrsi(korisnik);
            return ((PrijaviKorisnikaSO)operacija).Korisnik;
        }
        public Boolean RegistrujNovogKorisnika(Korisnik korisnik)
        {
            OpstaSistemskaOperacija operacija = new RegistrujNovogKorisnikaSO();
            operacija.Izvrsi(korisnik);
            return ((RegistrujNovogKorisnikaSO)operacija).Uspelo;
        }
        public Boolean DodajGlumca(Glumac glumac)
        {
            OpstaSistemskaOperacija operacija = new DodajGlumcaSO();
            operacija.Izvrsi(glumac);
            return ((DodajGlumcaSO)operacija).Uspelo;
        }

        public object VratiGlumce()
        {
            OpstaSistemskaOperacija operacija = new VratiListuGlumacaSO();
            operacija.Izvrsi(new Glumac());
            return ((VratiListuGlumacaSO)operacija).Glumci;

        }
        public object VratiListuSerija()
        {
            OpstaSistemskaOperacija operacija = new VratiListuSerijaSO();
            operacija.Izvrsi(new Serija());
            return ((VratiListuSerijaSO)operacija).Serije;

        }
        public object VratiListuZanrova()
        {
            OpstaSistemskaOperacija operacija = new VratiListuZanrovaSO();
            operacija.Izvrsi(new Zanr());
            return ((VratiListuZanrovaSO)operacija).Zanrovi;

        }

        public object IzmeniGlumca(Glumac glumac)
        {
            OpstaSistemskaOperacija operacija = new IzmenaGlumcaSO();
            operacija.Izvrsi(glumac);
            return ((IzmenaGlumcaSO)operacija).Uspelo;
        }
        public object IzmenaSerije(Serija serija)
        {
            OpstaSistemskaOperacija operacija = new IzmenaSerijaSO();
            operacija.Izvrsi(serija);
            return ((IzmenaSerijaSO)operacija).Uspelo;
        }

        public object ObrisiSeriju(Serija serija)
        {
            OpstaSistemskaOperacija operacija = new ObrisiSerijuSO();
            operacija.Izvrsi(serija);
            return ((ObrisiSerijuSO)operacija).Uspelo;
        }
        public object DodajSeriju(Serija serija)
        {
            OpstaSistemskaOperacija operacija = new DodajSerijuSO();
            operacija.Izvrsi(serija);
            return ((DodajSerijuSO)operacija).Uspelo;
        }

        public object VratiSerijuPoKriterijumu(Serija serija)
        {
            OpstaSistemskaOperacija operacija = new VratiSerijuPoKriterijumuSO();
            operacija.Izvrsi(serija);
            return ((VratiSerijuPoKriterijumuSO)operacija).Serije;
        }

        public object VratiGlumcePoKriterijumu(Glumac objekat)
        {
            OpstaSistemskaOperacija operacija = new VratiGlumcaPoKriterijumuSO();
            operacija.Izvrsi(objekat);
            return ((VratiGlumcaPoKriterijumuSO)operacija).Glumci;
        }

        public List<TipOcene> VratiListuTipovaOcene()
        {
            OpstaSistemskaOperacija operacija = new VratiTipoveOcenaSO();
            operacija.Izvrsi(new TipOcene());
            return ((VratiTipoveOcenaSO)operacija).Tipovi;
        }

        public object DodajRecenziju(Iskustvo objekat)
        {
            OpstaSistemskaOperacija operacija = new SacuvajOcenuSO();
            operacija.Izvrsi(objekat);
            return ((SacuvajOcenuSO)operacija).Uspelo;
        }
    }
}
