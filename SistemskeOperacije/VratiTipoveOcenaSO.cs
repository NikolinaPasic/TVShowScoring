using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiTipoveOcenaSO : OpstaSistemskaOperacija
    {
        public List<TipOcene> Tipovi { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Tipovi = new List<TipOcene>(broker.VratiSve(objekat).Cast<TipOcene>());
            foreach (var item in Tipovi)
            {
                Console.WriteLine(item.RbrTipaOcene);
            }
        }

        protected override void Validacija(DomenskiObjekat objekat)
        {
            if (!(objekat is TipOcene))
            {
                throw new ArgumentException();
            }
        }
    }
}
