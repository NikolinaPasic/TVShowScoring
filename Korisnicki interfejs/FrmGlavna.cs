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
    public partial class FrmGlavnaAdministrator : Form
    {
        public FrmGlavnaAdministrator(Korisnik k)
        {
            Console.WriteLine(k.Ime);
            InitializeComponent();
            lblPoruka.Text = "Dobrodošli " + k.Ime;
            customizeDesign();
        }   

        private void btnUnosSerije_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            FrmUnosSerije frm = new FrmUnosSerije();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
        private void customizeDesign() {
            pnlSerije.Visible = false;
            pnlGlumci.Visible = false;

        }
        private void hideSubmenu()
        {
            if (pnlSerije.Visible == true)
                pnlSerije.Visible = false;
            if (pnlGlumci.Visible == true)
                pnlGlumci.Visible = false;

        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else {
                submenu.Visible = false;
            }

        }

        private void btnSerije_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSerije);
        }

        private void btnPretragaSerije_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            FrmSerije frm = new FrmSerije();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGlumci_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlGlumci);
        }

        private void btnUnosGlumca_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            FrmUnosGlumca frm = new FrmUnosGlumca();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;

        }

        private void btnPretragaGlumca_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            this.Visible = false;
            FrmGlumci frm = new FrmGlumci();
            frm.ShowDialog();
            this.Visible = true;



        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIzmenaSerije frm = new FrmIzmenaSerije();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmIzmenaGlumca frm = new FrmIzmenaGlumca();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBrisanjeSerije frm = new FrmBrisanjeSerije();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
