using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SacuvajOcenuSO : OpstaSistemskaOperacija
    {
        public bool Uspelo { get; private set; }

        protected override void IzvrsiKonkretnuOperaciju(DomenskiObjekat objekat)
        {
            Iskustvo i = (Iskustvo)objekat;
            i.RedniBrojIskustva = broker.DajSledeciID(i);
            Console.WriteLine(i.RedniBrojIskustva);
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
                int j = 0;
                foreach (Ocena o in i.Ocene)
                {
                    o.Iskustvo = i;
                    o.Iskustvo.RedniBrojIskustva = i.RedniBrojIskustva;
                    Console.WriteLine(o.Iskustvo.RedniBrojIskustva);
                    o.RedniBrojOcene = ++j;
                    if (broker.Sacuvaj(o) != 1)
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
            if (!(objekat is Iskustvo))
            {
                throw new ArgumentException();
            }
        }
    }
}
