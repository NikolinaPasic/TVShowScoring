using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class DodajGlumcaSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
          
            Glumac g = (Glumac)objekat;
          

            if (broker.Sacuvaj(g) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }
        }

   

        protected override void Validacija(DomenskiObjekat objekat)
        {
            if (!(objekat is Glumac))
            {
                throw new ArgumentException();
            }
        }

     
    }
}
