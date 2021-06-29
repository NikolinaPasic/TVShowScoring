using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{
    public partial class Form1 : Form
    {
        ControllerLogin kontroler;
        public Form1()
        {
           
            InitializeComponent();
            kontroler = new ControllerLogin(this);
            if (kontroler.SrediFormu())
            {
                MessageBox.Show("Uspesno povezivanje");
            }
            else {
                MessageBox.Show("Neuspesno povezivanje");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidationHelpers.EmptyFieldValidation(txtUsername) || !ValidationHelpers.EmptyFieldValidation(txtPassword)) {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }
            Korisnik k = kontroler.UlogujSe(txtUsername, txtPassword);
            if (k != null)
            {
                if (k.Ime == null || k.Prezime == null) {
                    MessageBox.Show("Vec ste se prijavili");
                    return;
                }
                MessageBox.Show("Uspjesno ste se prijavili na sistem!");
                if (k.Administrator)
                {
                    FrmGlavnaAdministrator glavnaAdministrator = new FrmGlavnaAdministrator(k);
                    this.Visible = false;
                    glavnaAdministrator.ShowDialog();
                    this.Visible = true;
                }
                else {
                    FrmRegularniKorisnik frm = new FrmRegularniKorisnik(k);
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Visible = true;
                }
            }
            else {

                MessageBox.Show("Pokusajte ponovo");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmSignIn signin = new FrmSignIn();
            this.Visible = false;
            signin.ShowDialog();
            this.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
