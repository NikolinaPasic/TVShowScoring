using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class ObrisiSerijuSO: OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }
       
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Uloga u = new Uloga { Serija =(Serija) objekat };
            Iskustvo i = new Iskustvo { Serija = (Serija)objekat };
            List<Uloga> uloge = broker.VratiSveSaUslovom(u).Cast<Uloga>().ToList();
            List<Iskustvo> iskustva = broker.VratiSveSaUslovom(i).Cast<Iskustvo>().ToList();
            if (uloge != null)
            {
                foreach (var item in uloge)
                {
                    broker.Obrisi(item);
                }
            }
            if (iskustva != null) {
                foreach (var item in iskustva)
                {
                    i.RedniBrojIskustva = item.RedniBrojIskustva;
                    Ocena o = new Ocena { Iskustvo = item };
                    List<Ocena>ocene =broker.VratiSveSaUslovom(o).Cast<Ocena>().ToList();
                    foreach (var m in ocene)
                    {
                        broker.Obrisi(o);
                    }
                    broker.Obrisi(item);
                }

            }
            if (broker.Obrisi(objekat) != 1)
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
            if (!(objekat is Serija))
            {
                throw new ArgumentException();
            }
        }
    }
}
