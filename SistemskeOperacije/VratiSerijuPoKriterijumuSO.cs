using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiSerijuPoKriterijumuSO : OpstaSistemskaOperacija
    {
        public List<Serija> Serije{ get; set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Serije =new List<Serija>(broker.VratiListuPoKriterijumu(objekat).Cast<Serija>());
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
