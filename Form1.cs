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

namespace Wypozyczalnia
{
    public partial class formEkranKlienta : Form
    {
        public int ZamowienieId = 0;


        public formEkranKlienta()
        {
            InitializeComponent();
        }
        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";

        public void formEkranKlienta_Load(object sender, EventArgs e)
        {

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

            string typ = dropKategorie.SelectedItem.ToString();
            
            Connector connector = new Connector();
            dataGridView1.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
            
            
            

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
           DataTable dt = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Regał, Półka", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
           int selectedRow = dataGridView1.SelectedRows[0].Index;
            //dt.AcceptChanges();
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


            //trzeba dodać tworzenie nowego zamówienia w momencie ładowania forma i pobrać jego ID
            //w momencie dodania itemka do zamowienia: musimy zmienic dostępność przemiotu w sprzęcie na 0, dodać do worka wraz z id zamowienia i id sprzetu
            //potem w dgv po prawo wyświetlamy zawartość worka(najłatwiej)
            //aktualizujemy sprzety do wypozyczenia(po prostu pobrać)
            //jesli chcemy usunac z worka to wywalamy i zmieniamy dostepnosc na 1
            //trzeba dodac cos z pieniedzmi d bazy danych, jakies ceny produktow za dobe czy cos(też to można wyświetlać)
            //(Imię, Nazwisko,Pesel, Miejscowość, Kod_pocztowy ,Ulica, NumerDomu, Telefon, Login, Hasło)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Worek VALUES(@WypozyczenieID, @SprzętID, @Nazwa, @Typ, @Rozmiar, @Regał, @Półka)", connection))
                {

                    command.Parameters.AddWithValue("@WypozyczenieID", ZamowienieId);
                    command.Parameters.AddWithValue("@SprzętID", IdSprzetu);
                    command.Parameters.AddWithValue("@Nazwa", Nazwa);
                    command.Parameters.AddWithValue("@Typ", Typ);
                    command.Parameters.AddWithValue("@Rozmiar", Rozmiar);
                    command.Parameters.AddWithValue("@Regał", Regal);
                    command.Parameters.AddWithValue("@Półka", Polka);
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

            dataGridView2.DataSource = connector.PobierzDaneDoDGV("WypozyczenieID, SprzętID,Nazwa, Typ, Rozmiar", "Worek", $"Where WypozyczenieID = {ZamowienieId}");
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;










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
            dataGridView2.DataSource = connector.PobierzDaneDoDGV("WypozyczenieID, SprzętID,Nazwa, Typ, Rozmiar", "Worek", $"Where WypozyczenieID = {IdWypozyczenia}");
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;


        }
    }
}
