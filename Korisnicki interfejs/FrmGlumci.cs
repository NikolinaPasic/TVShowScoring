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
    public partial class FrmGlumci : Form
    {
        private ControllerPretraga kontroler;
        public FrmGlumci()
        {

            InitializeComponent();
            kontroler = new ControllerPretraga();
            dataGridView1.DataSource = (List<Glumac>)Komunikacija.Instance.vratiListuGlumaca();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidationHelpers.EmptyFieldValidation(txtNaziv))
            {
                MessageBox.Show("Unesite vrednost za pretragu");
                return;
            }
            Glumac glumac = new Glumac { Ime = txtNaziv.Text };

            dataGridView1.DataSource = kontroler.PronadjiGlumca(glumac);
        }
    }
}
