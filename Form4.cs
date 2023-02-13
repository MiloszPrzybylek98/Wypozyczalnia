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
    public partial class formPracownik : Form
    {
        public int ZamowienieId = 0;
        public int IDKlienta = 0;

        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";
        public formPracownik()
        {
            InitializeComponent();
        }

        private void formPracownik_Load(object sender, EventArgs e)
        {
            btnWypozycz.Enabled= false;
            comboTypDodaj.Items.Clear();
            comboTypP.Items.Clear();
            Connector connector = new Connector();
            connector.UzupelnijTypy(comboTypP);
            Connector connector1 = new Connector();
            connector1.UzupelnijTypy(comboTypDodaj);
            comboTypDodaj.Items.RemoveAt(0);

            Connector connector2 = new Connector();          
            dgvMagazynP.DataSource = connector2.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");

            dgvAktywneZamP.DataSource = connector2.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");           
            
            dropKategorie.Enabled= false;       
        }

        private void comboTypP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string typ = comboTypP.SelectedItem.ToString();
                if (typ =="Wszystko")
                {
                    Connector connector2 = new Connector();
                    dgvMagazynP.DataSource = connector2.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");
                }
                else
                {
                    Connector connector = new Connector();
                    dgvMagazynP.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", "WHERE Typ = '" + typ + "'");
                }              
            }
            catch (Exception)
            {
             
            }          
        }

        private void btnDodajSprzetDoMagazynu_Click(object sender, EventArgs e)
        {
            string typ = comboTypDodaj.SelectedItem.ToString();
            string nazwa = txtNazwaDodaj.Text;
            string rozmiar = txtRozmiarDodaj.Text;
            int dostepnosc = 1;
            int regal = (int)numRegalDodaj.Value;
            int polka = (int)numPolkaDodaj.Value;
            int cena = (int)numCena.Value;

            //INSERT INTO SprzetNarciarski(Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka) VALUES(@Nazwa, @Typ, @Dostępność = '1', @Regal, @Polka)

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO SprzetNarciarski(Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka,Cena) VALUES(@Nazwa, @Typ, @Rozmiar, @Dostępność, @Regal, @Polka, @Cena)", connection))
                {

                    command.Parameters.AddWithValue("@Nazwa", nazwa);
                    command.Parameters.AddWithValue("@Typ", typ);
                    command.Parameters.AddWithValue("@Dostępność", dostepnosc);
                    command.Parameters.AddWithValue("@Rozmiar", rozmiar);
                    command.Parameters.AddWithValue("@Regal", regal);
                    command.Parameters.AddWithValue("@Polka", polka);
                    command.Parameters.AddWithValue("@Cena", cena);
                    int result = command.ExecuteNonQuery();                 
                }
            }

            comboTypDodaj.Items.Clear();
            
            txtNazwaDodaj.Clear();
            txtRozmiarDodaj.Clear();
            
            numRegalDodaj.ResetText();
            numPolkaDodaj.ResetText();
            numCena.ResetText();
            Connector connector = new Connector();
            connector.UzupelnijTypy(comboTypDodaj);
            comboTypDodaj.Items.RemoveAt(0);
            
            dgvMagazynP.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");
        }

        private void dgvAktywneZamP_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvAktywneZamP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAktywneZamP.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAktywneZamP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAktywneZamP.Rows[selectedRowIndex];
                int IndeksZbazy = Convert.ToInt32(selectedRow.Cells["IdWypozyczenia"].Value);
                Connector connector = new Connector();
                dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV("SprzętID,Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "Worek", $"Where WypozyczenieID = {IndeksZbazy}");

                //dodać, że jeśli zamówienie nie jest wydane to nie można rozliczyć
            }

            int[] tablica = new int[dgvWorekZamP.Rows.Count];
            List<int> list = new List<int>();

            if (dgvWorekZamP.Rows.Count > 0)
            {
                
                foreach (DataGridViewRow item in dgvWorekZamP.Rows)
                {
                    list.Add((int)item.Cells[0].Value);
                }
            }

            string idiki = "(";
            foreach (var item in list)
            {
                idiki += item.ToString()+",";

            }
            idiki = idiki.Remove(idiki.Length - 1);
            idiki += ")";
        }

        private void btnSzukajZamowienia_Click(object sender, EventArgs e)
        {
            try
            {
                int IdWyp = Convert.ToInt32(txtWyszukajAktywne.Text);
                Connector connector = new Connector();

                dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("*", "Wypozyczenia", $"WHERE IdWypozyczenia = {IdWyp} AND where CzyRozliczone = 0");
                dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV(" IdSprzet, Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "Worek", $"Where WypozyczenieID = {IdWyp}");
            }
            catch (Exception)
            {

                MessageBox.Show("Podaj poprawne ID zamówienia");
            }
            //connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "Where ");
        }

        private void btnCzyscSzukanie_Click(object sender, EventArgs e)
        {
            txtWyszukajAktywne.Clear();
            Connector connector= new Connector();   
            dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
            dgvWorekZamP.DataSource = null;
        }

        private void btnRozlicz_Click(object sender, EventArgs e)
        {
            if (dgvAktywneZamP.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAktywneZamP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAktywneZamP.Rows[selectedRowIndex];
                int IndeksZbazy = Convert.ToInt32(selectedRow.Cells["IdWypozyczenia"].Value);
                int PłatnośćPodstawowa = Convert.ToInt32(selectedRow.Cells["Płatność"].Value);
                DateTime teraz = DateTime.Now;
                DateTime DataZwrotu = Convert.ToDateTime(selectedRow.Cells["Data_zwrotu"].Value);
                TimeSpan nadgodziny = teraz - DataZwrotu;
                int Płatność = 0;
                int godz;
                //tutaj jest rozliczenie nadgodzin
                if (teraz > DataZwrotu)
                {
                    godz = (int)nadgodziny.TotalHours;
                    if (godz > 0)
                    {
                        Płatność = PłatnośćPodstawowa + (godz * 5);
                    }
                    else
                    {
                        Płatność = PłatnośćPodstawowa;
                    }
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

                List<int> list = new List<int>();

                if (dgvWorekZamP.Rows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgvWorekZamP.Rows)
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
                dgvWorekZamP.DataSource = null;

                //tutaj tekst dla klienta ile hajsu
                MessageBox.Show($"Należy pobrać od klienta: {Płatność} PLN. Płatność podstawowa:{PłatnośćPodstawowa} PLN, Nadpłata za nadgodziny: {Płatność - PłatnośćPodstawowa} PLN.");

                Connector connector = new Connector();
                dgvMagazynP.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");
                dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
            }
        }

        private void btnWydaj_Click(object sender, EventArgs e)
        {
            if (dgvAktywneZamP.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAktywneZamP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAktywneZamP.Rows[selectedRowIndex];
                int IndeksZbazy = Convert.ToInt32(selectedRow.Cells["IdWypozyczenia"].Value);
                
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
                dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0 ");
            }
        }

        private void btnUsunZamowienie_Click(object sender, EventArgs e)
        {
            if (dgvAktywneZamP.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAktywneZamP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAktywneZamP.Rows[selectedRowIndex];
                int IndeksZbazy = Convert.ToInt32(selectedRow.Cells["IdWypozyczenia"].Value);


                List<int> list = new List<int>();

                if (dgvWorekZamP.Rows.Count > 0)
                {

                    foreach (DataGridViewRow item in dgvWorekZamP.Rows)
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

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand($"DELETE FROM Wypozyczenia where IdWypozyczenia = @WypozyczenieID;", connection))
                    {
                        command.Parameters.AddWithValue("@WypozyczenieID", IndeksZbazy);

                        command.ExecuteNonQuery();
                    }

                }
              
                Connector connector = new Connector();
                dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
                dgvMagazynP.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");
                dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV("SprzętID,Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "Worek", $"Where WypozyczenieID = {IndeksZbazy}");
                //dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
                //dodać, żeby z worka czyściło itemki i wracały na magazyn
            }           
        }

        private void btnUsunSprzetZmagazynu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMagazynP.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dgvMagazynP.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvMagazynP.Rows[selectedRowIndex];
                    int IndeksZbazy = Convert.ToInt32(selectedRow.Cells["IdSprzet"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"DELETE FROM SprzetNarciarski WHERE IdSprzet = @IdSprzet  ", connection))
                        {
                            command.Parameters.AddWithValue("@IdSprzet", IndeksZbazy);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                formPracownik_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Nie można usunąć sprzętu, obecnie jest wypożyczony.");
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
                    dgvMagazynP.DataSource = connector2.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");
                }
                else
                {
                    Connector connector = new Connector();
                    dgvMagazynP.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", "WHERE Typ = '" + typ + "'");
                }
            }
            catch (Exception)
            {

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
                    txtPesel.Clear();
                    txtNrKontaktowy.Clear();
                    dropCzasWypozyczenia.Items.Clear();

                    dgvWyborSprzetu.DataSource = null;
                    dgvWorek.DataSource = null;
                }
                catch (Exception)
                {

                    MessageBox.Show("Błąd przy złożeniu zamówienia. Proszę spróbować ponownie");
                    txtImie.Clear();
                    txtNazwisko.Clear();
                    txtPesel.Clear();
                    txtNrKontaktowy.Clear();
                    dropCzasWypozyczenia.Items.Clear();

                    dgvWyborSprzetu.DataSource = null;
                    dgvWorek.DataSource = null;



                }





            }
            else
            {
                MessageBox.Show("Zła długość peselu lub nr telefonu. Proszę poprawić");
            }

            btnWypozycz.Enabled= false;
            dgvMagazynP.DataSource = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");

            dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
            dgvAktywneZamP.CurrentRow.Selected = false;

            LblSumaZamowienia.Text = Płatność.ToString();
        }

        private void formPracownik_FormClosed(object sender, FormClosedEventArgs e)
        {
            formWybor form = new formWybor();
            form.Show();
        }

        private void formPracownik_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
           
        }



        private void btnNoweZamowienie_Click(object sender, EventArgs e)
        {
            btnDodajDoZamowienia.Enabled = true;
            btnUsunZzamowienia.Enabled=true;
            dropKategorie.Enabled = true;
            btnWypozycz.Enabled = true;
            txtImie.Clear();
            txtNazwisko.Clear();
            txtPesel.Clear();
            txtNrKontaktowy.Clear();
            dropCzasWypozyczenia.Items.Clear();
            //DateTime data = DateTime.Now;
            //DateTime dataOddania = data.AddDays(dni);
            //int KwotaZamowienia = connector.PobierzCeneZamowieniaZWorka(ZamowienieId);
            //int Płatność = KwotaZamowienia * dni;
            //int CzyRozliczone = 0;
            //int CzyWydane = 0;
            dgvWyborSprzetu.DataSource = null;
            dgvWorek.DataSource = null;


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
            dropKategorie.Items.Clear() ;
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

        private void txtPesel_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.WalidujNrTxt(txtPesel, btnWypozycz, "pesel");

        }

        private void txtNrKontaktowy_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.WalidujNrTxt(txtNrKontaktowy, btnWypozycz, "nr kontaktowy");
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


            int selectedRow = dgvWyborSprzetu.SelectedRows[0].Index;
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

            dgvWorek.DataSource = connector.PobierzDaneDoDGV("WypozyczenieID, SprzętID,Nazwa, Typ, Rozmiar, Cena", "Worek", $"Where WypozyczenieID = {ZamowienieId}");
            dgvWorek.Columns[0].Visible = false;
            dgvWorek.Columns[1].Visible = false;

            LblSumaZamowienia.Text = connector.PobierzCeneZamowieniaZWorka(ZamowienieId).ToString();



        }

        private string dodaj()
        {
            string typ = dropKategorie.SelectedItem.ToString();

            return typ;
        }

        private void dropKategorie_SelectedValueChanged(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            string typ = dropKategorie.SelectedItem.ToString();
            if (typ == "Wszystko")
            {
                dgvWyborSprzetu.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Cena", "SprzetNarciarski", "WHERE  Dostępność = 1");
            }
            else
            {

                dgvWyborSprzetu.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Cena", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
            }

        }

        private void btnUsunZzamowienia_Click(object sender, EventArgs e)
        {
            if(dgvWorek.Rows.Count > 0)
            {
                DataTable dt = (DataTable)(dgvWorek.DataSource);
                int selectedRow = dgvWorek.SelectedRows[0].Index;

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
                dgvWorek.DataSource = connector.PobierzDaneDoDGV("WypozyczenieID, SprzętID,Nazwa, Typ, Rozmiar, Cena", "Worek", $"Where WypozyczenieID = {IdWypozyczenia}");
                dgvWorek.Columns[0].Visible = false;
                dgvWorek.Columns[1].Visible = false;
                LblSumaZamowienia.Text = connector.PobierzCeneZamowieniaZWorka(ZamowienieId).ToString();
            }

            

        }
    }
}
