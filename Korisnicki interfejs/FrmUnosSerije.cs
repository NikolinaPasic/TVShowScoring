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
    public partial class FrmUnosSerije : Form
    {
        private ControllerUnosSerije kontroler;
        public FrmUnosSerije()
        {
            InitializeComponent();
            kontroler = new ControllerUnosSerije(this);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUnosSerije_Load(object sender, EventArgs e)
        {
            //cmbSerije.DataSource = Komunikacija.Instance.vratiListuSerija();
            cmbZanrovi.DataSource = Komunikacija.Instance.vratiListuZanrova();
            cmbGlumci.DataSource = Komunikacija.Instance.vratiListuGlumaca();
            dataGridView1.DataSource = kontroler.listaUloga;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Uloga u = new Uloga { Glumac=(Glumac)cmbGlumci.SelectedItem, Opis=txtOpisUloge.Text};
            kontroler.DodajUlogu(u,txtNaziv,txtOpisUloge,dataGridView1);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDodajSeriju_Click(object sender, EventArgs e)
        {
            if (!ValidationHelpers.EmptyFieldValidation(txtNaziv) || !ValidationHelpers.EmptyFieldValidation(txtBrojSezona) || !ValidationHelpers.EmptyFieldValidation(txtDobit)) {
                MessageBox.Show("Popunite obavezna polja");
                return;
            }
            if (!ValidationHelpers.DoubleValidation(txtDobit) || !ValidationHelpers.IntValidation(txtBrojSezona) || Int32.Parse(txtBrojSezona.Text) < 1) {
                MessageBox.Show("Greska prilikom validacije");
                return;
            }
            Serija s = new Serija { NazivSerije = txtNaziv.Text, BrojSezona = Int32.Parse(txtBrojSezona.Text), DobitSerije = Double.Parse(txtDobit.Text), OpisSerije = txtOpis.Text, Zanr = (Zanr)cmbZanrovi.SelectedItem };
            bool uspelo = kontroler.dodajSeriju(s);
            if (uspelo == true)
            {
                this.Close();
            }
        }

        private void btnObrisiUlogu_Click(object sender, EventArgs e)
        {
            
            kontroler.ObrisiUlogu(dataGridView1);
        }
    }
}
