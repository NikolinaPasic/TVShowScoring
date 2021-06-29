using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{
    public class ControllerIzmenaGlumca
    {
        internal bool IzmeniGlumca(Glumac glumac)
        {
            try
            {
                bool uspesno=false;
                try
                {
                    uspesno = Komunikacija.Instance.IzmeniGlumca(glumac);
                    Console.WriteLine(uspesno);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show($"Napravljene su izmene nad glumcem: {glumac.Ime} !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene glumca.");
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
