using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korisnicki_interfejs
{

    public static class ValidationHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                
                return false;
            }
            else
            {
                
                return true;
            }
        }

        public static bool IntValidation(TextBox txt)
        {
            if (!int.TryParse(txt.Text, out int _))
            {
               
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool DoubleValidation(TextBox txt)
        {
            if (!double.TryParse(txt.Text, out double _))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool StringValidation(TextBox txt)
        {
            if (txt.Text.Length >= 2 && Regex.IsMatch(txt.Text, @"^[a-zA-Z]+$"))
            {
                
                return true;
            }
            
            txt.ResetText();
            return false;
        }
        public static bool EmailValidation(TextBox txt)
        {
            try
            {
                MailAddress m = new MailAddress(txt.Text);

                return true;
            }
            catch (FormatException)
            {
                txt.ResetText();
                return false;
            }
           
        }


        public static bool EmptyDataGridViewValidation(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Bar jedna ocena mora biti dodata!");
                return false;
            }
            return true;
        }

        public static bool SelectionDataGridViewValidation(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Ne mozete selektovati vise od jednog reda!");
                return false;
            }
            return true;
        }

        public static bool DateTimeValidation(TextBox txt)
        {
            if (!DateTime.TryParseExact(txt.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    
    }
}
