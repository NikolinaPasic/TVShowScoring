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
    public partial class FrmIzmenaSerije : Form
    {
       private ControllerIzmenaSerije kontroler;
        public FrmIzmenaSerije()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Serija s = (Serija)comboBox1.SelectedItem;
            txtNaziv.Text = s.NazivSerije;
            txtDobit.Text = s.DobitSerije.ToString();
            txtBrojSezona.Text = s.BrojSezona.ToString();
            txtOpis.Text = s.OpisSerije;
            cmbZanrovi.SelectedItem =(Zanr) s.Zanr;

        }
  

        private void FrmIzmenaSerije_Load(object sender, EventArgs e)
        {
            kontroler = new ControllerIzmenaSerije();
              cmbZanrovi.DataSource = Komunikacija.Instance.vratiListuZanrova();
            comboBox1.DataSource = Komunikacija.Instance.vratiListuSerija();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidationHelpers.EmptyFieldValidation(txtNaziv) || !ValidationHelpers.EmptyFieldValidation(txtBrojSezona) || !ValidationHelpers.EmptyFieldValidation(txtDobit))
            {
                MessageBox.Show("Popunite obavezna polja");
                return;
            }
            Serija s = (Serija)comboBox1.SelectedItem;
            s.NazivSerije = txtNaziv.Text;
            s.OpisSerije = txtOpis.Text;
            s.DobitSerije = Double.Parse(txtDobit.Text);
            s.BrojSezona = Int32.Parse(txtBrojSezona.Text);
            s.Zanr = (Zanr)cmbZanrovi.SelectedItem;
            bool uspelo = kontroler.IzmeniSeriju(s);
            if (uspelo)
            {
                this.Close();
            }
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
