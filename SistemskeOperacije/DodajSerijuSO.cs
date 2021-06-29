using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class DodajSerijuSO : OpstaSistemskaOperacija
    {

        public bool Uspelo { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Serija s = (Serija)objekat;
            s.SerijaID = broker.DajSledeciID(s);
            if (broker.Sacuvaj(objekat) != 1)
            {
                Uspelo = false;
            }
            else
            {
                Uspelo = true;
            }

            if (Uspelo == true)
            {
                foreach (Uloga u in s.uloge)
                {
                    u.Serija = s;
                    if (broker.Sacuvaj(u) != 1)
                    {
                        Uspelo = false;
                    }
                    else
                    {
                        Uspelo = true;
                    }
                }

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
