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
    public class Glumac : DomenskiObjekat
    {
        //Glumac (SifraGlumca, Ime, Prezime, Biografija)

        public int GlumacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Biografija { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public string PostaviVrednostAtributa()
        {
            return $"Ime, Prezime,Biografij";
        }

        public string VratiImeKlase()
        {
            return "Glumac";
        }

        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> glumci = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Glumac glumac = new Glumac
                {
                    GlumacID = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    Biografija = reader.GetString(3)

                };
                glumci.Add(glumac);
            }
           
            return glumci;
        }

        public DomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            DomenskiObjekat glumac = null;
            while (reader.Read())
            {
                glumac = new Glumac
                {
                    
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    Biografija = reader.GetString(3)

                };
            }
            return glumac;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"GlumacID = {GlumacID}";
        }

        public string VratiVrednostAtributa()
        {
            return $" '{Ime}', '{Prezime}', '{Biografija}'";
        }

        public string VratiImeID()
        {
            return "GlumacID";
        }

        public string Izmeni()
        {
            return $" Ime = '{Ime}', Prezime='{Prezime}', Biografij='{Biografija}'";
        }

        public string Join()
        {
            return "";
        }

        string DomenskiObjekat.StringPretrazi()
        {
            return $"Ime like '%{Ime}%'";
        }

        List<DomenskiObjekat> DomenskiObjekat.VratiListuPoKriterijumu(SqlDataReader reader)
        {
            List<DomenskiObjekat> lista = new List<DomenskiObjekat>();

            while (reader.Read())
            {
                Glumac glumac = new Glumac();
                glumac.GlumacID = reader.GetInt32(0);
                glumac.Ime = reader.GetString(1);
                glumac.Prezime = reader.GetString(2);
                glumac.Biografija = reader.GetString(3);
                

                lista.Add(glumac);
            }

            return lista;
        }
    }
}
