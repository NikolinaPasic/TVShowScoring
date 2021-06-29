using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            button1.Enabled = true;
            buttonZaustavi.Enabled = false;
            server = new Server(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (server.Pokreni())
            {
                button1.Enabled = false;
                buttonZaustavi.Enabled = true;
                MessageBox.Show("Pokrenut server");
            }
            else
            {
                MessageBox.Show("Neuspesno pokretanje servera");
            }
        }

        private void buttonZaustavi_Click_1(object sender, EventArgs e)
        {
            if (server.Zaustavi())
            {
                button1.Enabled = true;
                buttonZaustavi.Enabled = false;
                MessageBox.Show("Server je zaustavljen");
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            server.Zaustavi();
            Application.Exit();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }
    }
}
