using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuSerijaSO : OpstaSistemskaOperacija
    {
        public List<Serija> Serije { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Serije = new List<Serija>(broker.VratiSve(objekat).Cast<Serija>());
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
