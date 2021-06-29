using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PrikaziGlumcaS : OpstaSistemskaOperacija
    {
        public Glumac Glumac { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Glumac = (Glumac)broker.VratiJedan(objekat);
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
