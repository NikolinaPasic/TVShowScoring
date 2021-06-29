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
    public partial class FrmRegularniKorisnik : Form
    {
        ControllerRecenzija kontroler;
        DataTable temp;
        DataTable serija;
       public Korisnik korisnik;
        int j = 0;
        public FrmRegularniKorisnik(Korisnik k )
        {
            InitializeComponent();
            kontroler = new ControllerRecenzija(this);
            korisnik = k;
            Console.WriteLine(k.KorisnikID);
            kontroler.srediFormu(comboBox1);
            cmbTipoviIskustva.DataSource = kontroler.UcitajTipoveOcena();
            label1.Text = "Dobrodošli " + k.Ime;
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegularniKorisnik_Load(object sender, EventArgs e)
        {        
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            
            Ocena o = new Ocena { RedniBrojOcene=j++, TipOcene=(TipOcene)cmbTipoviIskustva.SelectedItem,Ocjena=Int32.Parse(txtOcena.Text)};
            kontroler.DodajOcenu(o, dgvIskustva);
        }

        private void btnSacuvajIskustvo_Click(object sender, EventArgs e)
        {
            if (!ValidationHelpers.EmptyDataGridViewValidation(dgvIskustva) || Double.Parse(txtOcena.Text) < 1 || Double.Parse(txtOcena.Text) > 10 || !ValidationHelpers.DoubleValidation(txtOcena)) {
                MessageBox.Show("Pogresan format");
                return;
            }
            Iskustvo i = new Iskustvo {Serija=(Serija)comboBox1.SelectedItem,Korisnik=korisnik,OpisIskustva=txtOpisIskustva.Text};
            bool uspelo = kontroler.dodajIskustvo(i);
            if (uspelo == true)
            {
                this.Close();
            }
        }

        private void btnObrisiUlogu_Click(object sender, EventArgs e)
        {
            Ocena o = (Ocena)dgvIskustva.SelectedRows[0].DataBoundItem;
            kontroler.ObrisiOcenu(o,dgvIskustva);
        }
    }
}
