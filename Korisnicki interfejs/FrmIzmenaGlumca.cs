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
    public partial class FrmIzmenaGlumca : Form
    {
        private ControllerIzmenaGlumca kontroler;
        public FrmIzmenaGlumca()
        {
            InitializeComponent();
            kontroler = new ControllerIzmenaGlumca();
        }

        private void FrmIzmenaGlumca_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Komunikacija.Instance.vratiListuGlumaca();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Glumac g =(Glumac) comboBox1.SelectedItem;
            Console.WriteLine(g.GlumacID);
            txtIme.Text = g.Ime;
            txtPrezime.Text = g.Prezime;
            txtBiografija.Text = g.Biografija;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidationHelpers.EmptyFieldValidation(txtIme) || !ValidationHelpers.EmptyFieldValidation(txtPrezime))
            {
                MessageBox.Show("Popunite obavezna polja");
                return;
            }
            if (!ValidationHelpers.StringValidation(txtIme) || !ValidationHelpers.StringValidation(txtPrezime))
            {
                MessageBox.Show("Pogresan format");
                return;
            }
            Glumac g = (Glumac)comboBox1.SelectedItem;
            g.Ime = txtIme.Text;
            g.Prezime = txtPrezime.Text;
            g.Biografija = txtBiografija.Text;
            bool uspelo = kontroler.IzmeniGlumca(g);
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
