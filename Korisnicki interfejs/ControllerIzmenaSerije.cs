using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{
    public class ControllerIzmenaSerije
    {
        internal bool IzmeniSeriju(Serija serija)
        {
            try
            {
                bool uspesno = false;
                try
                {
                    uspesno = Komunikacija.Instance.IzmeniSeriju(serija);
                    Console.WriteLine(uspesno);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show($"Napravljene su izmene nad serijom: {serija.NazivSerije} !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene serije.");
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        internal void ObrisiSeriju(Serija s)
        {
            try
            {
                bool uspesno = false;
                try
                {
                    uspesno = Komunikacija.Instance.ObrisiSeriju(s);
                    Console.WriteLine(uspesno);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                  
                }
                if (uspesno)
                {
                    MessageBox.Show($"Napravljene su izmene nad serijom: {s.NazivSerije} !");
                    
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene serije.");
                
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
