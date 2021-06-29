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
    public class TipOcene: DomenskiObjekat
    {

        //TipOcene (RbrTipaOcene, Naziv)
        public int RbrTipaOcene { get; set; }
        public string NazivTipa { get; set; }

        public override string ToString()
        {
            return NazivTipa;
        }
        public string PostaviVrednostAtributa()
        {
            return $"NazivTipa = '{NazivTipa}'";
        }

        public string VratiImeKlase()
        {
            return "TipOcene";
        }

        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> tipovi = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                TipOcene tip = new TipOcene
                {
                    RbrTipaOcene=reader.GetInt32(0),
                    NazivTipa = reader.GetString(1)

                };
                tipovi.Add(tip);
            }
            return tipovi;
        }

        public DomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            DomenskiObjekat tip = null;
            while (reader.Read())
            {
                tip = new TipOcene
                {

                    NazivTipa = reader.GetString(1)

                };
            }
            return tip;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"RbrTipaOcene = {RbrTipaOcene}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{RbrTipaOcene}, '{NazivTipa}''";
        }

        public string VratiImeID()
        {
            return "RbrTipaOcene";
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
