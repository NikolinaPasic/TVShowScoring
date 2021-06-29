using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{

    public class ControllerSignIn
    {
        internal Boolean RegistrujSe(Korisnik novi)
        {
            try
            {

                Boolean signal;
                try
                {
                    signal = Komunikacija.Instance.RegistrujSe(novi);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (signal)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
