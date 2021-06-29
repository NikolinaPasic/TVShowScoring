using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PrikaziSerijuSO : OpstaSistemskaOperacija
    {
        public Serija Serija { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Serija = (Serija)broker.VratiJedan(objekat);
        }

        protected override void Validacija(DomenskiObjekat objekat)
        {
            if (!(objekat is Serija))
            {
                throw new ArgumentException();
            }
        }
    }
}
