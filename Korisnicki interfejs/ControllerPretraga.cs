using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{
    public class ControllerPretraga
    {
       
        internal List<Serija> PronadjiSeriju(Serija serija)
        {
            List<Serija> serije = new List<Serija>();
            try
            {
               
                try
                {
                    serije=Komunikacija.Instance.PronadjiSeriju(serija);
                   
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
                if (serije!=null)
                {
                    return serije;
                }
                else
                {
                    return null;
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal List<Glumac> PronadjiGlumca(Glumac glumac)
        {
            List<Glumac> glumci = new List<Glumac>();
            try
            {

                try
                {
                    glumci = Komunikacija.Instance.PronadjiGlumca(glumac);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
                if (glumci!=null)
                {
                    return glumci;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
