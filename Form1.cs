using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Threading;
using System.Net;

namespace Wypozyczalnia
{
    public partial class formEkranKlienta : Form
    {
        public int ZamowienieId = 0;
        public int IDKlienta = 0;


        public formEkranKlienta()
        {
            InitializeComponent();
        }
        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";

        public void formEkranKlienta_Load(object sender, EventArgs e)
        {
            txtImie.Clear();
            txtNazwisko.Clear();
            txtPeselK.Clear();
            txtNrKontaktowy.Clear();
            dropCzasWypozyczenia.Items.Clear();
            //DateTime data = DateTime.Now;
            //DateTime dataOddania = data.AddDays(dni);
            //int KwotaZamowienia = connector.PobierzCeneZamowieniaZWorka(ZamowienieId);
            //int Płatność = KwotaZamowienia * dni;
            //int CzyRozliczone = 0;
            //int CzyWydane = 0;
            dataGridView1.DataSource = null;
            dataGridView2.DataSource= null;


            object[] doby = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14 };
            dropCzasWypozyczenia.Items.AddRange(doby);
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Typ  FROM SprzetNarciarski", connectionString);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //foreach (DataRow row in table.Rows)
            //{
            //    dropKategorie.Items.Add(row["Typ"].ToString());
            //}
            Connector connector = new Connector();
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









            




        }

        private void dropKategorie_SelectedValueChanged(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            string typ = dropKategorie.SelectedItem.ToString();
            if (typ=="Wszystko")
            {
                dataGridView1.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Cena", "SprzetNarciarski", "WHERE  Dostępność = 1");
            }
            else
            {
                
                dataGridView1.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Cena", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
            }
            
            
            
            

        }

        private string dodaj()
        {
            string typ = dropKategorie.SelectedItem.ToString() ;

            return typ;
        }
        

        private void btnDodajDoZamowienia_Click(object sender, EventArgs e)
        {


            string typ =  dodaj() ;
            Connector connector = new Connector();
            DataTable dt = new DataTable();
            if (typ =="Wszystko")
            {
                 dt = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "SprzetNarciarski", "WHERE  Dostępność = 1");
                
            }
            else
            {
                 dt = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");

            }
            
                
            


           
           
            int selectedRow = dataGridView1.SelectedRows[0].Index;
            DataTable dt2 = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                if(dr.Table.Rows.IndexOf(dr) == selectedRow)
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

            dataGridView2.DataSource = connector.PobierzDaneDoDGV("WypozyczenieID, SprzętID,Nazwa, Typ, Rozmiar, Cena", "Worek", $"Where WypozyczenieID = {ZamowienieId}");
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;

            LblSumaZamowienia.Text = connector.PobierzCeneZamowieniaZWorka(ZamowienieId).ToString();
            











        }

        private void dropKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUsunZzamowienia_Click(object sender, EventArgs e)
        {

            DataTable dt = (DataTable)(dataGridView2.DataSource);
            int selectedRow = dataGridView2.SelectedRows[0].Index;

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
            dataGridView2.DataSource = connector.PobierzDaneDoDGV("WypozyczenieID, SprzętID,Nazwa, Typ, Rozmiar, Cena", "Worek", $"Where WypozyczenieID = {IdWypozyczenia}");
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            LblSumaZamowienia.Text = connector.PobierzCeneZamowieniaZWorka(ZamowienieId).ToString();


        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            
            Connector connector = new Connector();

            

            string Imie = txtImie.Text;
            string Nazwisko = txtNazwisko.Text;
            string Pesel = txtPeselK.Text;
            string Telefon = txtNrKontaktowy.Text;
            int dni = (int)dropCzasWypozyczenia.SelectedItem;
            DateTime data = DateTime.Now;
            DateTime dataOddania = data.AddDays(dni);
            int KwotaZamowienia = connector.PobierzCeneZamowieniaZWorka(ZamowienieId);
            int Płatność = KwotaZamowienia * dni;
            int CzyRozliczone = 0;
            int CzyWydane = 0;
            

            //List<string> Sprzęt = new List<string>() { Imie,Nazwisko,Pesel, Telefon}; proba dodania za pomoca metody z connectora


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


                    
                    
                    

                    MessageBox.Show($"Twój numer zamówienia to: {ZamowienieId}. Proszę podejść do stanowiska i podać numer zamówienia w celu odbioru sprzętu.");
                    txtImie.Clear();
                    txtNazwisko.Clear();
                    txtPeselK.Clear();
                    txtNrKontaktowy.Clear();
                    dropCzasWypozyczenia.Items.Clear();

                    dataGridView1.DataSource = null;
                    dataGridView2.DataSource = null;
                }
                catch (Exception)
                {

                    MessageBox.Show("Błąd przy złożeniu zamówienia. Proszę spróbować ponownie");
                    txtImie.Clear();
                    txtNazwisko.Clear();
                    txtPeselK.Clear();
                    txtNrKontaktowy.Clear();
                    dropCzasWypozyczenia.Items.Clear();

                    dataGridView1.DataSource = null;
                    dataGridView2.DataSource = null;



                }
                lblCenaZamowienia.Text = Płatność.ToString();





            }
            else
            {
                MessageBox.Show("Zła długość peselu lub nr telefonu. Proszę poprawić");
            }

            
            
        }



        private void txtNrKontaktowy_TextChanged(object sender, EventArgs e)
        {
           
            Validator validator = new Validator();
            validator.WalidujNrTxt(txtNrKontaktowy, btnWypozycz, "nr kontaktowy");
        }

        private void txtPeselK_TextChanged(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.WalidujNrTxt(txtPeselK, btnWypozycz, "pesel");
        }
    }
}
