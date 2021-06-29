using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuZanrovaSO : OpstaSistemskaOperacija
    {
        public List<Zanr> Zanrovi { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Zanrovi = new List<Zanr>(broker.VratiSve(objekat).Cast<Zanr>());
        }

        protected override void Validacija(DomenskiObjekat objekat)
        {
            if (!(objekat is Zanr))
            {
                throw new ArgumentException();
            }
        }
    }
}
