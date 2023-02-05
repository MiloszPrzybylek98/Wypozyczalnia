using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia
{
    public class Validator
    {

        public void WalidujNrTxt(TextBox txt,Button btn, string wartosc)
        {
            string numer = txt.Text;


            if (numer.All(char.IsDigit))
            {
                btn.Enabled = true;
            }
            else
            {
                MessageBox.Show($"W nr {wartosc} występuje inny znak niż liczba. Proszę poprawić nr {wartosc}");
                btn.Enabled = false;
            }
        }



    }
}
