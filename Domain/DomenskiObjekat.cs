using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface DomenskiObjekat
    {
      
        string VratiVrednostAtributa();
        string VratiImeKlase();
        string PostaviVrednostAtributa();
        string VratiUslovZaTrazenje();
        string VratiImeID();
        string Izmeni();
        string Join();
        string StringPretrazi();
        List<DomenskiObjekat> VratiListu(SqlDataReader reader);
        DomenskiObjekat VratiObjekat(SqlDataReader reader);
        List<DomenskiObjekat> VratiListuPoKriterijumu(SqlDataReader reader);

    }
}
