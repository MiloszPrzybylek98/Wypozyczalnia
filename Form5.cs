using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia
{
    public partial class FormAdmin : Form
    {
        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = txtImieP.Text;
            string nazwisko = txtNazwiskoP.Text;
            string pesel = txtPeselP.Text;
            string miasto = txtMiastoP.Text;
            string ulica = txtUlicaP.Text;
            string kodPoczt = txtKodPocztaP.Text;
            string nrTel = txtTelefonP.Text;
            string nrDomu = txtNrDomuP.Text;
            string login = txtLoginP.Text;
            string haslo = txtHasloP.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Pracownicy (Imię, Nazwisko,Pesel, Miejscowość, Kod_pocztowy ,Ulica, NumerDomu, Telefon, Login, Hasło) VALUES(@Imię, @Nazwisko, @Pesel, @Miejscowość, @Kod_pocztowy, @Ulica, @NumerDomu, @Telefon, @Login, @Hasło)", connection))
                {

                    command.Parameters.AddWithValue("@Imię", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@Pesel", pesel);
                    command.Parameters.AddWithValue("@Miejscowość", miasto);
                    command.Parameters.AddWithValue("@Kod_pocztowy", kodPoczt);
                    command.Parameters.AddWithValue("@Ulica", ulica);
                    command.Parameters.AddWithValue("@NumerDomu", nrDomu);
                    command.Parameters.AddWithValue("@Telefon", nrTel);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Hasło", haslo);
                    int result = command.ExecuteNonQuery();

                }

            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Connector connector= new Connector();           
            dgvPracownicy.DataSource = connector.PobierzDaneDoDGV("*", "Pracownicy", "");
        }
    }
}
