using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Iskustvo : DomenskiObjekat
    {
        //Iskustvo (RbrIskustva, OpisIskustva, SifraKorisnika, SifraSerije)

        public int RedniBrojIskustva { get; set; }
        public string OpisIskustva { get; set; }
        public Korisnik Korisnik { get; set; }
        public Serija Serija { get; set; }
        public BindingList<Ocena> Ocene { get; set; }
        public string Izmeni()
        {
            throw new NotImplementedException();
        }

        public string PostaviVrednostAtributa()
        {
            return $"RbrIskustva,OpisIskustva,KorisnikID, SerijaID";
        }

        public string VratiImeID()
        {
            return "RbrIskustva";
        }

        public string VratiImeKlase()
        {
            return "Iskustvo";
        }

        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> iskustva = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Iskustvo iskustvo = new Iskustvo
                {
                    Serija = new Serija { SerijaID = reader.GetInt32(3) },

                    Korisnik = new Korisnik { KorisnikID = reader.GetInt32(2) },
                    OpisIskustva = reader.GetString(1),
                    RedniBrojIskustva= reader.GetInt32(0)
                };
                iskustva.Add(iskustvo);
            }
            return iskustva;
        }

        public DomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string VratiUslovZaTrazenje()
        {
            return $"SerijaID = {Serija.SerijaID}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{RedniBrojIskustva}, '{OpisIskustva}', {Korisnik.KorisnikID}, {Serija.SerijaID}";
        }

        public string Join()
        {
            return "";
        }

        string DomenskiObjekat.StringPretrazi()
        {
            throw new NotImplementedException();
        }

        List<DomenskiObjekat> DomenskiObjekat.VratiListuPoKriterijumu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
