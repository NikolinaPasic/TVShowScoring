using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
   public class IzmenaGlumcaSO: OpstaSistemskaOperacija
    {

        public bool Uspelo { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            if (broker.Izmeni(objekat) != 1)
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
