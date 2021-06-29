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
   public class Uloga: DomenskiObjekat
    {
        //   Uloga(SifraSerije, SifraGlumca, Opis)

        public Serija Serija { get; set; }
        public Glumac Glumac { get; set; }
        public string Opis { get; set; }

        public string PostaviVrednostAtributa()
        {
            return $"SerijaID,GlumacID,Opis";
        }


        public string VratiImeID()
        {
            throw new NotImplementedException();
        }

        public string VratiImeKlase()
        {
            return "Uloga";
        }

        public override string ToString()
        {
            return Serija.NazivSerije + " " + Glumac.Ime + " " + Glumac.Prezime;
        }

        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> uloge = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Uloga uloga = new Uloga
                {
                    Serija = new Serija { SerijaID = reader.GetInt32(0) },

                    Glumac  = new Glumac { GlumacID = reader.GetInt32(1) },
                    Opis = reader.GetString(2)
                };
                uloge.Add(uloga);
            }
            return uloge;
        }

        public DomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            DomenskiObjekat uloga = null;
            while (reader.Read())
            {
                uloga = new Uloga
                {
                    Serija = new Serija { SerijaID = reader.GetInt32(0) },

                    Glumac = new Glumac { GlumacID = reader.GetInt32(1) },
                    Opis = reader.GetString(2)
                };
            }
            return uloga;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"SerijaID={Serija.SerijaID}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{Serija.SerijaID}, {Glumac.GlumacID}, '{Opis}'";
        }

        public string Izmeni()
        {
            throw new NotImplementedException();
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
