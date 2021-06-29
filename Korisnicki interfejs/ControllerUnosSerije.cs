using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{
    public class ControllerUnosSerije
    {
        public static Serija serija;
        public BindingList<Uloga> listaUloga= new BindingList<Uloga>();
        FrmUnosSerije frm;

        public ControllerUnosSerije(FrmUnosSerije frmunos)
        {
            serija = new Serija();
            this.frm = frmunos;

        }
        internal void DodajUlogu(Uloga u, TextBox txtNaziv, RichTextBox txtOpis,DataGridView uloge)
        {
            listaUloga.Add(u);
            txtOpis.Clear();
            uloge.DataSource = listaUloga;
        }

        internal void ObrisiUlogu(DataGridView dataGridView1)
        {
            try
            {
                Uloga u = (Uloga)dataGridView1.SelectedRows[0].DataBoundItem;

                listaUloga.Remove(u);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal bool dodajSeriju(Serija s)
        {
            try
            {
                serija.Zanr = s.Zanr;
                serija.NazivSerije = s.NazivSerije;
                serija.OpisSerije = s.OpisSerije;
                serija.DobitSerije = s.DobitSerije;
                serija.BrojSezona = s.BrojSezona;
                serija.uloge = listaUloga;
                foreach (var item in serija.uloge)
                {
                    Console.WriteLine(item.Opis);
                }
                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.DodajSeriju(serija);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show("Dodata je nova serija po imenu: " + s.NazivSerije);
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti seriju");
                    return false;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
