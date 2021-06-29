using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuGlumacaSO : OpstaSistemskaOperacija
    {
        public List<Glumac> Glumci { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Glumci = new List<Glumac>(broker.VratiSve(objekat).Cast<Glumac>());
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
