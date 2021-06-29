using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{
    class ControllerUnosGlumca
    {
        internal bool dodajGlumca(string txtIme, string txtPrezime, string biografija)
        {
            try
            {
                Glumac glumac = new Glumac
                {
                    Ime = txtIme,
                    Prezime = txtPrezime,
                    Biografija = biografija,
                };
                bool uspesno = false;
                try
                {
                    uspesno = Komunikacija.Instance.DodajGlumca(glumac);


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                if (uspesno)
                {
                    MessageBox.Show("Dodat je novi glumac po imenu " + glumac.Ime + " !");
                   
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti glumca");
                }
                return uspesno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
         
        }
    }
}
