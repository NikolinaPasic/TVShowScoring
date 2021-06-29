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
    public partial class FrmSerije : Form
    {
        private ControllerPretraga kontroler;
        private List<Serija> serije;
        private List<Serija> pretrazene= new List<Serija>();
        public FrmSerije()
        {
            InitializeComponent();
            kontroler = new ControllerPretraga();
            serije = (List<Serija>)Komunikacija.Instance.vratiListuSerija();
            foreach (var item in serije)
            {
                Console.WriteLine(item.ToString());
            }
            dataGridView1.DataSource = (List<Serija>)Komunikacija.Instance.vratiListuSerija();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSerije_Load(object sender, EventArgs e)
        {
            pretrazene.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidationHelpers.EmptyFieldValidation(txtNaziv)) {
                MessageBox.Show("Unesite vrednost za pretragu");
                return;
            }
            Serija serija = new Serija { NazivSerije = txtNaziv.Text };
            
            dataGridView1.DataSource = kontroler.PronadjiSeriju(serija);
           
        }
    }
}
