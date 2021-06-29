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
   public class Zanr: DomenskiObjekat
    {
        public int ZanrID { get; set; }
        public string NazivZanra { get; set; }

        public override string ToString()
        {
            return $"'{NazivZanra}'";
        }

        public string PostaviVrednostAtributa()
        {
            return $"NazivZanra = '{NazivZanra}'";
        }

        public string VratiImeKlase()
        {
            return "Zanr";
        }

        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> zanrovi = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Zanr zanr = new Zanr
                {
                    ZanrID = reader.GetInt32(0),
                  NazivZanra= reader.GetString(1)

                };
                zanrovi.Add(zanr);
            }
            return zanrovi;
        }

        public DomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            DomenskiObjekat zanr = null;
            while (reader.Read())
            {
                zanr = new Zanr
                {

                    NazivZanra = reader.GetString(1)

                };
            }
            return zanr;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"ZanrID = {ZanrID}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{ZanrID}, '{NazivZanra}'";
        }

        public string VratiImeID()
        {
            return "ZanrID";
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
