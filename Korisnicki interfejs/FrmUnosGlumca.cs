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
    public partial class FrmUnosGlumca : Form
    {
        private ControllerUnosGlumca kontroler;
        public FrmUnosGlumca()
        {
            InitializeComponent();
        }

        private void FrmUnosGlumca_Load(object sender, EventArgs e)
        {
            kontroler = new ControllerUnosGlumca();
    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Glumac g = new Glumac { Ime=txtIme.Text, Prezime=txtPrezime.Text, Biografija=txtBiografija.Text};
            if (String.IsNullOrEmpty(txtIme.Text) && String.IsNullOrEmpty(txtPrezime.Text) && String.IsNullOrEmpty(txtBiografija.Text))
            {
                MessageBox.Show("Greska prilikom unosa!");
                return;
            }
            Boolean signal = kontroler.dodajGlumca(g.Ime,g.Prezime,g.Biografija);
            if (signal)
            {
                this.Close();
            }
            else
            {

                MessageBox.Show("Greska prilikom registracije");
                return;
            }
        }

        private void txtBiografija_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
