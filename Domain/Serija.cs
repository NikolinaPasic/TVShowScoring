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
    public class Serija : DomenskiObjekat
    {
        //  Serija(SifraSerije, NazivSerije, OpisSerije, BrojSezona, DobitSerije, SifraZanra )
        public int SerijaID { get; set; }
        public string NazivSerije { get; set; }
        public string OpisSerije { get; set; }
        public int BrojSezona { get; set; }
        public double DobitSerije { get; set; }
        public Zanr Zanr { get; set; }
       public BindingList<Uloga> uloge { get; set; }


        public override string ToString()
        {
            return NazivSerije;
        }

        public string PostaviVrednostAtributa()
        {
            return $"SerijaID,NazivSerije, OpisSerije, BrojSezona, DobitSerije,ZanrID";
        }

        public string VratiImeID()
        {
            return "SerijaID";
        }

        public string VratiImeKlase()
        {
            return "Serija";
        }
        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<DomenskiObjekat> serije = new List<DomenskiObjekat>();
            while (reader.Read())
            {
             
                Serija s = new Serija
                {
                    
                    SerijaID = reader.GetInt32(0),
                    NazivSerije =reader.GetString(1),
                    OpisSerije=reader.GetString(2),
                    BrojSezona=reader.GetInt32(3),
                    DobitSerije=reader.GetDouble(4),
                    Zanr= new Zanr { ZanrID = reader.GetInt32(5), NazivZanra=reader.GetString(7)}
                    
                };
              
                serije.Add(s);
            }

            return serije;
        }

        public DomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
           
            Serija serija = new Serija();
            while (reader.Read())
            {

                serija.SerijaID = reader.GetInt32(0);
                serija.NazivSerije = reader.GetString(1);
                serija.OpisSerije = reader.GetString(2);
                serija.BrojSezona = reader.GetInt32(3);
                serija.DobitSerije = reader.GetDouble(4);
                serija.Zanr = new Zanr { ZanrID = reader.GetInt32(5), NazivZanra = reader.GetString(7) };

                
            }
            
            return serija;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"SerijaID = {SerijaID}";
        }

        public string VratiVrednostAtributa()
        {
            return $"{SerijaID},'{NazivSerije}', '{OpisSerije}', {BrojSezona}, {DobitSerije} , {Zanr.ZanrID}";
        }
        public string Izmeni()
        {
            return $" NAzivSerije = '{NazivSerije}',  OpisSerije='{OpisSerije}',BrojSezona={BrojSezona},DobitSerije={DobitSerije}, Zanrid = {Zanr.ZanrID}";
        }

        public string Join()
        {
            return "s join Zanr z on s.ZanrID=z.ZanrID";
        }

        string DomenskiObjekat.StringPretrazi()
        {
            return $"s.NazivSerije like '%{NazivSerije}%'";
        }

        List<DomenskiObjekat> DomenskiObjekat.VratiListuPoKriterijumu(SqlDataReader reader)
        {
            List<DomenskiObjekat> lista = new List<DomenskiObjekat>();
         
            while (reader.Read())
            {
                Serija serija = new Serija();
                serija.SerijaID = reader.GetInt32(0);
                serija.NazivSerije = reader.GetString(1);
                serija.OpisSerije = reader.GetString(2);
                serija.BrojSezona = reader.GetInt32(3);
                serija.DobitSerije = reader.GetDouble(4);
                serija.Zanr = new Zanr { ZanrID = reader.GetInt32(5), NazivZanra = reader.GetString(7) };

                lista.Add(serija);
            }

            return lista;
        }
    } 
}
