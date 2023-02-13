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
        public int ZamowienieId = 0;
        public int IDKlienta = 0;
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
            btnWypozycz.Enabled = false;
            Connector connector = new Connector();
            dgvPracownicy.DataSource = connector.PobierzDaneDoDGV("*", "Pracownicy", "");
            Connector connector1 = new Connector();
            connector1.UzupelnijTypy(comboTypA);
            connector1.UzupelnijTypy(comboTypDodajA);

            RefreshDataGridView();

            dgvWszystkieZamowienia.DataSource = connector.PobierzDaneDoDGV("*", "Wypozyczenia", "WHERE CzyWydane = 1 OR CzyWydane = 0");
            Connector connector2 = new Connector();
            dgvMagazynA.DataSource = connector2.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");

            dgvAktywneZamA.DataSource = connector2.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");

            //if (dgvAktywneZamA.Rows.Count > 0)
            //{
            //    dgvAktywneZamA.CurrentRow.Selected = false;
            //}

            //dropKategorie.Enabled = false;

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

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            btnNoweZamowienie.Enabled = true;

            Connector connector = new Connector();



            string Imie = txtImie.Text;
            string Nazwisko = txtNazwisko.Text;
            string Pesel = txtPesel.Text;
            string Telefon = txtNrKontaktowy.Text;
            int dni = (int)dropCzasWypozyczenia.SelectedItem;
            DateTime data = DateTime.Now;
            DateTime dataOddania = data.AddDays(dni);
            int KwotaZamowienia = connector.PobierzCeneZamowieniaZWorka(ZamowienieId);
            int Płatność = KwotaZamowienia * dni;
            int CzyRozliczone = 0;
            int CzyWydane = 0;


            if (Pesel.Length == 11 && Telefon.Length == 9)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("INSERT INTO Klienci (Imie, Nazwisko, Pesel, Telefon) VALUES(@Imię, @Nazwisko, @Pesel,  @Telefon); SELECT SCOPE_IDENTITY() ", connection))
                        {

                            command.Parameters.AddWithValue("@Imię", Imie);
                            command.Parameters.AddWithValue("@Nazwisko", Nazwisko);
                            command.Parameters.AddWithValue("@Pesel", Pesel);
                            command.Parameters.AddWithValue("@Telefon", Telefon);
                            IDKlienta = Convert.ToInt32(command.ExecuteScalar());

                        }

                    }
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Wypozyczenia  SET KlientId= @KlientId, Data_wypożyczenia = @Data_wypożyczenia, Data_zwrotu = @Data_zwrotu, Płatność= @Płatność, CzyRozliczone= @CzyRozliczone, CzyWydane = @CzyWydane Where IdWypozyczenia = @IdWypozyczenia  ", connection))
                        {

                            command.Parameters.AddWithValue("@KlientId", IDKlienta);
                            command.Parameters.AddWithValue("@Data_Wypożyczenia", data);
                            command.Parameters.AddWithValue("@Data_zwrotu", dataOddania);
                            command.Parameters.AddWithValue("@Płatność", Płatność);
                            command.Parameters.AddWithValue("@CzyRozliczone", CzyRozliczone);
                            command.Parameters.AddWithValue("@CzyWydane", CzyWydane);
                            command.Parameters.AddWithValue("@IdWypozyczenia", ZamowienieId);
                            command.ExecuteNonQuery();


                        }

                    }




                    MessageBox.Show($"Twój numer zamówienia to: {ZamowienieId}. Poczekaj na klienta z podanym numerem.");
                    txtImie.Clear();
                    txtNazwisko.Clear();
                    textBox3.Clear();
                    txtNrKontaktowy.Clear();
                    dropCzasWypozyczenia.Items.Clear();

                    dgvWyborSprzetuA.DataSource = null;
                    dgvWorekA.DataSource = null;
                }
                catch (Exception)
                {

                    MessageBox.Show("Błąd przy złożeniu zamówienia. Proszę spróbować ponownie");
                    txtImie.Clear();
                    txtNazwisko.Clear();
                    textBox3.Clear();
                    txtNrKontaktowy.Clear();
                    dropCzasWypozyczenia.Items.Clear();

                    dgvWyborSprzetuA.DataSource = null;
                    dgvWorekA.DataSource = null;



                }





            }
            else
            {
                MessageBox.Show("Zła długość peselu lub nr telefonu. Proszę poprawić");
            }

            btnWypozycz.Enabled = false;
            dgvMagazynA.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");

            dgvAktywneZamA.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
            //dgvAktywneZamA.CurrentRow.Selected = false;

            LblSumaZamowienia.Text = Płatność.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnSzukajZamowienia_Click(object sender, EventArgs e)
        {
            int IdWyp = Convert.ToInt32(txtWyszukajAktywne.Text);
            Connector connector = new Connector();

            dgvAktywneZamA.DataSource = connector.PobierzDaneDoDGV("*", "Wypozyczenia", $"WHERE IdWypozyczenia = {IdWyp} AND where CzyRozliczone = 0");
            dgvWorekZamA.DataSource = connector.PobierzDaneDoDGV(" IdSprzet, Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "Worek", $"Where WypozyczenieID = {IdWyp}");

        }

        private void btnNoweZamowienie_Click(object sender, EventArgs e)
        {
            btnDodajDoZamowienia.Enabled = true;
            btnUsunZzamowienia.Enabled = true;
            dropKategorie.Enabled = true;
            btnWypozycz.Enabled = true;
            txtImie.Clear();
            txtNazwisko.Clear();
            textBox3.Clear();
            txtNrKontaktowy.Clear();
            dropCzasWypozyczenia.Items.Clear();
            //DateTime data = DateTime.Now;
            //DateTime dataOddania = data.AddDays(dni);
            //int KwotaZamowienia = connector.PobierzCeneZamowieniaZWorka(ZamowienieId);
            //int Płatność = KwotaZamowienia * dni;
            //int CzyRozliczone = 0;
            //int CzyWydane = 0;
            dgvWyborSprzetuA.DataSource = null;
            dgvWorekA.DataSource = null;


            object[] doby = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            dropCzasWypozyczenia.Items.AddRange(doby);
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Typ  FROM SprzetNarciarski", connectionString);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //foreach (DataRow row in table.Rows)
            //{
            //    dropKategorie.Items.Add(row["Typ"].ToString());
            //}
            Connector connector = new Connector();
            dropKategorie.Items.Clear();
            connector.UzupelnijTypy(dropKategorie);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Wypozyczenia DEFAULT VALUES; SELECT SCOPE_IDENTITY()", connection))
                {

                    ZamowienieId = Convert.ToInt32(command.ExecuteScalar());
                    //ten using dodaje nam nowe wypozyczenie do tabeli i zwraca nam IdWypozyczenia

                }
            }


            btnNoweZamowienie.Enabled = false;
        }

        private void btnCzyscSzukanie_Click(object sender, EventArgs e)
        {
            txtWyszukajAktywne.Clear();
            Connector connector = new Connector();
            dgvAktywneZamA.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
            dgvWorekZamA.DataSource = null;
        }

        private void btnUsunZamowienie_Click(object sender, EventArgs e)
        {
            if (dgvAktywneZamA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego.");
                return;
            }

            // Pobierz wartość klucza głównego zaznaczonego wiersza
            int id = (int)dgvAktywneZamA.SelectedRows[0].Cells["IdWypozyczenia"].Value;

            // Skonfiguruj połączenie z bazą danych

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Skonstruuj zapytanie SQL
                string query = "DELETE FROM Worek WHERE WypozyczenieID = @IdWypozyczenia";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Dodaj wartość klucza głównego do parametru zapytania
                    command.Parameters.AddWithValue("@IdWypozyczenia", id);

                    // Wykonaj zapytanie
                    int rowsAffected = command.ExecuteNonQuery();

                    
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Skonstruuj zapytanie SQL
                string query = "DELETE FROM Wypozyczenia WHERE IdWypozyczenia = @IdWypozyczenia";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Dodaj wartość klucza głównego do parametru zapytania
                    command.Parameters.AddWithValue("@IdWypozyczenia", id);

                    // Wykonaj zapytanie
                    int rowsAffected = command.ExecuteNonQuery();

                    Connector connector = new Connector();
                    dgvAktywneZamA.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");

                }
            }
        }

        private void btnRozlicz_Click(object sender, EventArgs e)
        {
            if (dgvAktywneZamA.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAktywneZamA.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAktywneZamA.Rows[selectedRowIndex];
                int IndeksZbazy = Convert.ToInt32(selectedRow.Cells["IdWypozyczenia"].Value);
                int PłatnośćPodstawowa = Convert.ToInt32(selectedRow.Cells["Płatność"].Value);
                DateTime teraz = DateTime.Now;
                DateTime DataZwrotu = Convert.ToDateTime(selectedRow.Cells["Data_zwrotu"].Value);
                TimeSpan nadgodziny = teraz - DataZwrotu;
                int Płatność = 0;
                int godz;
                if (teraz > DataZwrotu)
                {

                    godz = (int)nadgodziny.TotalHours;
                    Płatność = PłatnośćPodstawowa + (godz * 5);

                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int rozliczenie = 1;
                    using (SqlCommand command = new SqlCommand($"UPDATE Wypozyczenia  SET CzyRozliczone= @CzyRozliczone, Płatność = @Płatność Where IdWypozyczenia = @IdWypozyczenia  ", connection))
                    {


                        command.Parameters.AddWithValue("@CzyRozliczone", rozliczenie);
                        command.Parameters.AddWithValue("@IdWypozyczenia", IndeksZbazy);
                        command.Parameters.AddWithValue("@Płatność", Płatność);
                        command.ExecuteNonQuery();


                    }

                }

                int[] tablica = new int[dgvWorekZamA.Rows.Count];
                List<int> list = new List<int>();

                if (dgvWorekZamA.Rows.Count > 0)
                {

                    foreach (DataGridViewRow item in dgvWorekZamA.Rows)
                    {
                        list.Add((int)item.Cells[0].Value);
                    }


                }

                string idiki = "'";
                foreach (var item in list)
                {
                    idiki += "" + item.ToString() + ",";

                }
                idiki = idiki.Remove(idiki.Length - 1);
                idiki += "'";





                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int dostepnosc = 1;
                    using (SqlCommand command = new SqlCommand($"DECLARE @intArray varchar(200) SET @intArray = {idiki};  UPDATE SprzetNarciarski  SET Dostępność= @Dostępność Where IdSprzet IN (select * from STRING_SPLIT(@intArray, ',')) ; ", connection))
                    {


                        command.Parameters.AddWithValue("@Dostępność", dostepnosc);
                        command.Parameters.AddWithValue("@Idiki", idiki);
                        command.ExecuteNonQuery();


                    }

                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand($"DELETE FROM Worek where WypozyczenieID = @WypozyczenieID;", connection))
                    {


                        command.Parameters.AddWithValue("@WypozyczenieID", IndeksZbazy);

                        command.ExecuteNonQuery();


                    }

                }





                MessageBox.Show($"Należy pobrać od klienta: {Płatność} PLN. Płatność podstawowa:{PłatnośćPodstawowa} PLN, Nadpłata za nadgodziny: {Płatność - PłatnośćPodstawowa} PLN.");

                Connector connector = new Connector();
                dgvAktywneZamA.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
                //dodać, żeby z worka czyściło itemki i wracały na magazyn

            }
        }

        private void btnWydaj_Click(object sender, EventArgs e)
        {
            if (dgvAktywneZamA.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAktywneZamA.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAktywneZamA.Rows[selectedRowIndex];
                int IndeksZbazy = Convert.ToInt32(selectedRow.Cells["IdWypozyczenia"].Value);
                //Connector connector = new Connector();
                //dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Regał, Półka", "Worek", $"Where WypozyczenieID = {IndeksZbazy}");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int wydane = 1;
                    using (SqlCommand command = new SqlCommand($"UPDATE Wypozyczenia  SET CzyWydane= @CzyWydane Where IdWypozyczenia = @IdWypozyczenia  ", connection))
                    {


                        command.Parameters.AddWithValue("@CzyWydane", wydane);
                        command.Parameters.AddWithValue("@IdWypozyczenia", IndeksZbazy);
                        command.ExecuteNonQuery();


                    }

                }

                Connector connector = new Connector();
                dgvAktywneZamA.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0 ");

            }
        }

        private string dodaj()
        {
            string typ = dropKategorie.SelectedItem.ToString();

            return typ;
        }

        private void btnDodajDoZamowienia_Click(object sender, EventArgs e)
        {

            string typ = dodaj();
            Connector connector = new Connector();
            DataTable dt = new DataTable();
            if (typ == "Wszystko")
            {
                dt = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "SprzetNarciarski", "WHERE  Dostępność = 1");

            }
            else
            {
                dt = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");

            }


            int selectedRow = dgvWyborSprzetuA.SelectedRows[0].Index;
            DataTable dt2 = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.Table.Rows.IndexOf(dr) == selectedRow)
                {
                    dt2.ImportRow(dr);
                }
            }

            int IdSprzetu = (int)dt2.Rows[0][0]; // tym ID dodajemy sprzęt do worka
            string Nazwa = dt2.Rows[0][1].ToString();
            string Typ = dt2.Rows[0][2].ToString();
            string Rozmiar = dt2.Rows[0][3].ToString();
            int Regal = (int)dt2.Rows[0][4];
            int Polka = (int)dt2.Rows[0][5];
            int Cena = (int)dt2.Rows[0][6];


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Worek VALUES(@WypozyczenieID, @SprzętID, @Nazwa, @Typ, @Rozmiar, @Regał, @Półka, @Cena)", connection))
                {

                    command.Parameters.AddWithValue("@WypozyczenieID", ZamowienieId);
                    command.Parameters.AddWithValue("@SprzętID", IdSprzetu);
                    command.Parameters.AddWithValue("@Nazwa", Nazwa);
                    command.Parameters.AddWithValue("@Typ", Typ);
                    command.Parameters.AddWithValue("@Rozmiar", Rozmiar);
                    command.Parameters.AddWithValue("@Regał", Regal);
                    command.Parameters.AddWithValue("@Półka", Polka);
                    command.Parameters.AddWithValue("@Cena", Cena);
                    command.ExecuteNonQuery();

                }

            }

            int dost = 0;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand($"UPDATE SprzetNarciarski SET Dostępność = @dost WHERE IdSprzet = @IdSprzetu  ", connection))
                {

                    command.Parameters.AddWithValue("@dost", dost);
                    command.Parameters.AddWithValue("@IdSprzetu", IdSprzetu);
                    command.ExecuteNonQuery();

                }

            }

            dropKategorie_SelectedValueChanged(sender, e);

            dgvWorekA.DataSource = connector.PobierzDaneDoDGV("WypozyczenieID, SprzętID,Nazwa, Typ, Rozmiar, Cena", "Worek", $"Where WypozyczenieID = {ZamowienieId}");
            dgvWorekA.Columns[0].Visible = false;
            dgvWorekA.Columns[1].Visible = false;

            LblSumaZamowienia.Text = connector.PobierzCeneZamowieniaZWorka(ZamowienieId).ToString();


        }

        private void btnUsunZzamowienia_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)(dgvWorekA.DataSource);
            int selectedRow = dgvWorekA.SelectedRows[0].Index;

            DataTable dt2 = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.Table.Rows.IndexOf(dr) == selectedRow)
                {
                    dt2.ImportRow(dr);
                }
            }

            int IdWypozyczenia = (int)dt2.Rows[0][0];
            int IdSprzetu = (int)dt2.Rows[0][1];



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"DELETE FROM Worek WHERE WypozyczenieID ={IdWypozyczenia} AND SprzętID ={IdSprzetu};", connection))
                {


                    command.ExecuteNonQuery();


                }
            }



            int dost = 1;




            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command = new SqlCommand($"UPDATE SprzetNarciarski SET Dostępność = @dost WHERE IdSprzet = @IdSprzetu  ", connection))
                {

                    command.Parameters.AddWithValue("@dost", dost);
                    command.Parameters.AddWithValue("@IdSprzetu", IdSprzetu);
                    command.ExecuteNonQuery();

                }

            }
            dropKategorie_SelectedValueChanged(sender, e);

            Connector connector = new Connector();
            dgvWorekA.DataSource = connector.PobierzDaneDoDGV("WypozyczenieID, SprzętID,Nazwa, Typ, Rozmiar, Cena", "Worek", $"Where WypozyczenieID = {IdWypozyczenia}");
            dgvWorekA.Columns[0].Visible = false;
            dgvWorekA.Columns[1].Visible = false;
            LblSumaZamowienia.Text = connector.PobierzCeneZamowieniaZWorka(ZamowienieId).ToString();

        }

        private void dropKategorie_SelectedValueChanged(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            string typ = dropKategorie.SelectedItem.ToString();
            if (typ == "Wszystko")
            {
                dgvWyborSprzetuA.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Cena", "SprzetNarciarski", "WHERE  Dostępność = 1");
            }
            else
            {

                dgvWyborSprzetuA.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Cena", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
            }
        }

        private void dgvAktywneZamA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAktywneZamA.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAktywneZamA.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAktywneZamA.Rows[selectedRowIndex];
                int IndeksZbazy = Convert.ToInt32(selectedRow.Cells["IdWypozyczenia"].Value);
                Connector connector = new Connector();
                dgvWorekZamA.DataSource = connector.PobierzDaneDoDGV("SprzętID,Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "Worek", $"Where WypozyczenieID = {IndeksZbazy}");

                //dodać, że jeśli zamówienie nie jest wydane to nie można rozliczyć
            }
        }

        private void dropKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string typ = dropKategorie.SelectedItem.ToString();
                if (typ == "Wszystko")
                {
                    Connector connector2 = new Connector();
                    dgvMagazynA.DataSource = connector2.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");
                }
                else
                {
                    Connector connector = new Connector();
                    dgvMagazynA.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", "WHERE Typ = '" + typ + "'");
                }

            }
            catch (Exception)
            {


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.WalidujNrTxt(textBox3, btnWypozycz, "pesel");
        }

        private void txtNrKontaktowy_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.WalidujNrTxt(txtNrKontaktowy, btnWypozycz, "nr kontaktowy");
        }
    }
}
