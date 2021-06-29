using Domen;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{
    public class ControllerLogin
    {
        bool signal = true;
        Korisnik k = new Korisnik();
        private Form1 form1;
  
        public ControllerLogin(Form1 form1)
        {
            this.form1 = form1;
           
        }

        internal bool SrediFormu()
        { 
            if (!Komunikacija.Instance.PoveziSe())
            {
                signal = false;
            }
            return signal;
        }

        internal Korisnik UlogujSe(TextBox txtUsername, TextBox txtPassword)
        {

            try
            {
               
                try
                {
                    k = Komunikacija.Instance.PrijaviKorisnika(txtUsername.Text, txtPassword.Text);
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
                if (k != null)
                {
                    return k;
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

        internal void Zavrsi()
        {
            try
            {

                Korisnik k;
                try
                {
                  // k = Komunikacija.Instance.Kraj(k);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}