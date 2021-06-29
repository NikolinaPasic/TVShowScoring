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
    public partial class FrmSignIn : Form
    {
        private ControllerSignIn kontroler = new ControllerSignIn();
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidationHelpers.EmptyFieldValidation(txtIme) || !ValidationHelpers.EmptyFieldValidation(txtPrezime)|| !ValidationHelpers.EmptyFieldValidation(txtUsername)|| !ValidationHelpers.EmptyFieldValidation(txtpass)|| !ValidationHelpers.EmptyFieldValidation(txtEmail))
            {
                MessageBox.Show("Greska prilikom registracije!");
                return;
            }
            if(!ValidationHelpers.StringValidation(txtIme)|| !ValidationHelpers.StringValidation(txtPrezime) || !ValidationHelpers.StringValidation(txtUsername) || !ValidationHelpers.StringValidation(txtpass)||!ValidationHelpers.EmailValidation(txtEmail)){

                MessageBox.Show("Uneseni format nije ispravan");
                return;
            }
            

            Korisnik novi = new Korisnik { Username=txtUsername.Text, Ime=txtIme.Text,Email=txtEmail.Text,Prezime=txtPrezime.Text, Password=txtpass.Text};
            Boolean signal = kontroler.RegistrujSe(novi);
            if (signal)
            {
                Form1 frm = new Form1();
                this.Visible = false;
                frm.ShowDialog();
                this.Visible = true;
            }
            else
            {

                MessageBox.Show("Greska prilikom registracije");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
