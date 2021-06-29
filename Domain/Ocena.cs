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
   public class Ocena: DomenskiObjekat
    {
        //Ocena (RbrOcene, RbrIskustva, Ocena, RbrTipaOcene)

        public int RedniBrojOcene { get; set; }
        public Iskustvo Iskustvo { get; set; }
        public int Ocjena { get; set; }
        public TipOcene TipOcene{ get; set; }

        public string Izmeni()
        {
            throw new NotImplementedException();
        }

        public string PostaviVrednostAtributa()
        {
            return $"RedniBrojIskustva,RedniBrojOcene,Ocjena, TipOcene";
        }

        public string VratiImeID()
        {
            return "RedniBrojOcene";
        }

        public string VratiImeKlase()
        {
            return "Ocena";
        }

        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {

            List<DomenskiObjekat> ocene = new List<DomenskiObjekat>();
            while (reader.Read())
            {
                Ocena ocena = new Ocena
                {
                   Iskustvo= new Iskustvo { RedniBrojIskustva=reader.GetInt32(0)},
                   RedniBrojOcene=reader.GetInt32(1),
                   Ocjena=reader.GetInt32(2),
                   TipOcene= new TipOcene { RbrTipaOcene= reader.GetInt32(3)}
                };
                ocene.Add(ocena);
            }
            return ocene;
        }

        public DomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string VratiUslovZaTrazenje()
        {
            return $"RedniBrojIskustva={Iskustvo.RedniBrojIskustva}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{Iskustvo.RedniBrojIskustva},{RedniBrojOcene},{Ocjena}, {TipOcene.RbrTipaOcene}";
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
