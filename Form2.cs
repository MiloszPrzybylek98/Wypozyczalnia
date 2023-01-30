using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia
{
    public partial class formLogowaniePracownika : Form
    {
        public formLogowaniePracownika()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            string isValid = ValidateCredentials(login, password, connectionString);

            if (isValid == "A")
            {
                // logowanie zakończone powodzeniem
                // tutaj można przejść do kolejnej formy lub wykonać inne operacje
                FormAdmin form5 = new FormAdmin();
                form5.Show();
                this.Hide();
            }
            if (isValid == "B")
            {
                // logowanie zakończone powodzeniem
                // tutaj można przejść do kolejnej formy lub wykonać inne operacje
                formPracownik form4 = new formPracownik();
                form4.Show();
                this.Hide();
            }

        }
        private string ValidateCredentials(string login, string password, string connectionString)
        {
            // tutaj należy wykonać połączenie z bazą danych i sprawdzić czy podany login i hasło istnieją
            // przykładowo:
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Pracownicy WHERE Login=@login AND Hasło=@password", connection))
                {
                    string A = "A";
                    string B = "B";
                    string C = "C";
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    int result = (int)command.ExecuteScalar();
                    if (result > 0 && login == "jkowalski")
                    {


                        return A;
                    }
                    if(result >0 && login != "jkowalski")
                    {
                        return B;
                    }
                    else
                    {
                        return C;
                    }
                }

            }
        }

    }
}
