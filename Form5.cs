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

        private void RefreshDataGridView()
        {
            Connector connector = new Connector();
            dgvMagazynA.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka", "SprzetNarciarski", ";");

            dgvMagazynA.Columns[0].Visible = false;
        }



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
            Connector connector = new Connector();
            dgvPracownicy.DataSource = connector.PobierzDaneDoDGV("*", "Pracownicy", "");
            Connector connector1 = new Connector();
            connector1.UzupelnijTypy(comboTypA);
            connector1.UzupelnijTypy(comboTypDodajA);

            RefreshDataGridView();
        }

        private void btnDodajSprzetDoMagazynu_Click(object sender, EventArgs e)
        {
            string typ = comboTypDodajA.SelectedItem.ToString();
            string nazwa = txtNazwaDodaj.Text;
            string rozmiar = txtRozmiarDodaj.Text;
            int dostepnosc = 1;
            int regal = (int)numRegalDodaj.Value;
            int polka = (int)numPolkaDodaj.Value;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO SprzetNarciarski( Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka) VALUES(@Nazwa, @Typ, @Rozmiar, @Dostępność, @Regal, @Polka)", connection))
                {

                    command.Parameters.AddWithValue("@Nazwa", nazwa);
                    command.Parameters.AddWithValue("@Typ", typ);
                    command.Parameters.AddWithValue("@Dostępność", dostepnosc);
                    command.Parameters.AddWithValue("@Rozmiar", rozmiar);
                    command.Parameters.AddWithValue("@Regal", regal);
                    command.Parameters.AddWithValue("@Polka", polka);
                    int result = command.ExecuteNonQuery();

                }

            }
            RefreshDataGridView();
        }

        private void comboTypA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typ = comboTypA.SelectedItem.ToString();

            Connector connector = new Connector();
            dgvMagazynA.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka", "SprzetNarciarski", "WHERE Typ = '" + typ + "'");
        }

        private void btnUsunSprzetZmagazynu_Click(object sender, EventArgs e)
        {
            if (dgvMagazynA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego wiersza.");
                return;
            }

            // Pobierz wartość klucza głównego zaznaczonego wiersza
            int id = (int)dgvMagazynA.SelectedRows[0].Cells["IdSprzet"].Value;

            // Skonfiguruj połączenie z bazą danych

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Skonstruuj zapytanie SQL
                string query = "DELETE FROM SprzetNarciarski WHERE IdSprzet = @IdSprzet";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Dodaj wartość klucza głównego do parametru zapytania
                    command.Parameters.AddWithValue("@IdSprzet", id);

                    // Wykonaj zapytanie
                    int rowsAffected = command.ExecuteNonQuery();

                    RefreshDataGridView();

                }
            }
        }

        private void dgvPracownicy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nrTel = txtTelefonP.Text;
            string nrDomu = txtNrDomuP.Text;

            //txtLoginA.Text = dgvPracownicy.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtImieP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNazwiskoP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtPeselP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMiastoP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUlicaP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtKodPocztaP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTelefonP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtNrDomuP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtLoginP.Text = dgvPracownicy.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnModifikujPracownika_Click(object sender, EventArgs e)
        {
            if (dgvPracownicy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego pracownika.");
                return;
            }

            string imie = txtImieP.Text;
            string nazwisko = txtNazwiskoP.Text;
            //string pesel = txtPeselP.Text;
            string miasto = txtMiastoP.Text;
            string ulica = txtUlicaP.Text;
            string kodPoczt = txtKodPocztaP.Text;
            string nrTel = txtTelefonP.Text;
            string nrDomu = txtNrDomuP.Text;
            string login = txtLoginP.Text;
            int id = (int)dgvPracownicy.SelectedRows[0].Cells["IdPracownik"].Value;



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Pracownicy SET Imię = @Imię, Nazwisko = @Nazwisko, Miejscowość = @Miejscowość, Kod_pocztowy = @Kod_pocztowy, Ulica = @Ulica, NumerDomu = @NumerDomu, Telefon = @Telefon, Login = @Login WHERE IdPracownik = @IdPracownik", connection))
                {
                    command.Parameters.AddWithValue("@IdPracownik", id);
                    command.Parameters.AddWithValue("@Imię", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    //command.Parameters.AddWithValue("@Pesel", pesel);
                    command.Parameters.AddWithValue("@Miejscowość", miasto);
                    command.Parameters.AddWithValue("@Kod_pocztowy", kodPoczt);
                    command.Parameters.AddWithValue("@Ulica", ulica);
                    command.Parameters.AddWithValue("@NumerDomu", nrDomu);
                    command.Parameters.AddWithValue("@Telefon", nrTel);
                    command.Parameters.AddWithValue("@Login", login);

                    int result = command.ExecuteNonQuery();

                    Connector connector = new Connector();
                    dgvPracownicy.DataSource = connector.PobierzDaneDoDGV("*", "Pracownicy", "");

                }

            }
        }

        private void btnUsunPracownika_Click(object sender, EventArgs e)
        {
            if (dgvPracownicy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego pracownika.");
                return;
            }

            // Pobierz wartość klucza głównego zaznaczonego wiersza
            int id = (int)dgvPracownicy.SelectedRows[0].Cells["IdPracownik"].Value;

            // Skonfiguruj połączenie z bazą danych

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Skonstruuj zapytanie SQL
                string query = "DELETE FROM Pracownicy WHERE IdPracownik = @IdPracownik";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Dodaj wartość klucza głównego do parametru zapytania
                    command.Parameters.AddWithValue("@IdPracownik", id);

                    // Wykonaj zapytanie
                    int rowsAffected = command.ExecuteNonQuery();

                    Connector connector = new Connector();
                    dgvPracownicy.DataSource = connector.PobierzDaneDoDGV("*", "Pracownicy", "");

                }
            }
        }

        private void btnZmienHaslo_Click(object sender, EventArgs e)
        {
            


            string updateSql = "UPDATE Pracownicy SET Hasło = @haslo WHERE Login = @login";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(updateSql, connection))
                {
                    command.Parameters.AddWithValue("@haslo", txtHasloA.Text);
                    command.Parameters.AddWithValue("@login", txtLoginP.Text);

                    command.ExecuteNonQuery();

                    Connector connector = new Connector();
                    dgvPracownicy.DataSource = connector.PobierzDaneDoDGV("*", "Pracownicy", "");


                }
            }
        }

        private void txtPowHasloA_TextChanged(object sender, EventArgs e)
        {
            if (txtHasloA.Text == txtPowHasloA.Text)
            {
                btnZmienHaslo.Enabled = true;
            }
            else
            {
                btnZmienHaslo.Enabled = false;

            }
        }
    }
}
