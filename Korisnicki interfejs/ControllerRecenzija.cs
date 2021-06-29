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
    public class ControllerRecenzija
    {
    
            public static Korisnik k;
            public Iskustvo iskustvo= new Iskustvo();
            public static Ocena ocena;
            BindingList<Ocena> oceneSerija= new BindingList<Ocena>();
            FrmRegularniKorisnik frmocena;


            public ControllerRecenzija(FrmRegularniKorisnik frm)
            {
                ocena = new Ocena();
                this.frmocena = frm;
                k = frm.korisnik;
            }

            internal void srediFormu(ComboBox cmbserije)
            {

                try
                {
                    cmbserije.DataSource = (List<Serija>)Komunikacija.Instance.vratiListuSerija();
                                }
                catch (Exception)
                {
                    MessageBox.Show("Server je prekinuo rad");
                    frmocena.Close();
                }
            }

        internal object UcitajTipoveOcena()
        {
            List<TipOcene> lista = Komunikacija.Instance.VratiListuTipova();
            return lista;
        }

        internal void DodajOcenu(Ocena o, DataGridView dgvIskustva)
        {
            oceneSerija.Add(o);
            dgvIskustva.DataSource = oceneSerija;
        }

        internal bool dodajIskustvo(Iskustvo i)
        {

            try
            {
                iskustvo.Korisnik = i.Korisnik;
                iskustvo.Serija = i.Serija;
                iskustvo.OpisIskustva = i.OpisIskustva;
                iskustvo.Ocene = oceneSerija;
                foreach (var item in iskustvo.Ocene)
                {
                    Console.WriteLine(item.Ocjena);
                }
                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.DodajIskustvo(iskustvo);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show("Dodato je novo iskustvo za seriju: " + iskustvo.Serija.NazivSerije);
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti iskustvo");
                    return false;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }

        }

        internal void ObrisiOcenu(Ocena o, DataGridView dgvIskustva)
        {
            try
            {
                Ocena ocena = (Ocena)dgvIskustva.SelectedRows[0].DataBoundItem;

                oceneSerija.Remove(ocena);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
 }

