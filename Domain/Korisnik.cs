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
    public class Korisnik : DomenskiObjekat
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Administrator { get; set; }

        public string Izmeni()
        {
            throw new NotImplementedException();
        }

        public string PostaviVrednostAtributa()
        {
            return $"Ime, Prezime,Email,Username, Password,Administrator";
        }
        public string VratiImeID()
        {
            throw new NotImplementedException();
        }

        public string VratiImeKlase()
        {
            return "Korisnik";
        }

        public List<DomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public DomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            Korisnik k = null;
            while (reader.Read())
            {
                k = new Korisnik
                {
                    KorisnikID=reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    Email = reader.GetString(3),
                    Username = reader.GetString(4),
                    Password=reader.GetString(5),
                    Administrator=reader.GetBoolean(6)
                };
            }
            return k;
        }

        public string VratiUslovZaTrazenje()
        {
            return $"Username = '{Username}' and Password = '{Password}'";
        }

        public string VratiVrednostAtributa()
        {
            return $"'{Ime}','{Prezime}','{Email}','{Username}','{Password}','{Administrator}'";
        }
        public string Join()
        {
            return "";
        }

        string DomenskiObjekat.StringPretrazi()
        {
            return $"Username='{Username}'";
        }

        List<DomenskiObjekat> DomenskiObjekat.VratiListuPoKriterijumu(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
