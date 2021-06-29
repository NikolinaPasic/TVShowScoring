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
    public partial class FrmBrisanjeSerije : Form
    {
        private ControllerIzmenaSerije kontroler;
        public FrmBrisanjeSerije()
        {

            InitializeComponent();
            kontroler = new ControllerIzmenaSerije();
        }

        private void FrmBrisanjeSerije_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Komunikacija.Instance.vratiListuSerija();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Serija s = (Serija)comboBox1.SelectedItem;
            kontroler.ObrisiSeriju(s);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
