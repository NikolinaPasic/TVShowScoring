using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class RegistrujNovogKorisnikaSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Korisnik k =(Korisnik) broker.VratiJedan(objekat);
            if (k == null)
            {
                if (broker.Sacuvaj(objekat) != 1)
                {
                    
                    Uspelo = false;
                }

                else
                {
                    Uspelo = true;
                }
            } 
        }

        protected override void Validacija(DomenskiObjekat objekat)
        {
            if (!(objekat is Korisnik))
            {
                throw new ArgumentException();
            }
        }
    }
}
