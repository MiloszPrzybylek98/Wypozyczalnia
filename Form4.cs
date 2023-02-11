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
        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";
        public formPracownik()
        {
            InitializeComponent();
        }

        private void formPracownik_Load(object sender, EventArgs e)
        {
            comboTypDodaj.Items.Clear();
            comboTypP.Items.Clear();
            Connector connector = new Connector();
            connector.UzupelnijTypy(comboTypP);
            Connector connector1 = new Connector();
            connector1.UzupelnijTypy(comboTypDodaj);

            Connector connector2 = new Connector();          
            dgvMagazynP.DataSource = connector2.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka, Cena", "SprzetNarciarski", ";");


            dgvAktywneZamP.DataSource = connector2.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
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

            Connector connector1 = new Connector();
            connector1.UzupelnijTypy(comboTypDodaj);
            //formPracownik_Load(sender, e);


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
                dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "Worek", $"Where WypozyczenieID = {IndeksZbazy}");

                //dodać, że jeśli zamówienie nie jest wydane to nie można rozliczyć
            }

        }

        private void btnSzukajZamowienia_Click(object sender, EventArgs e)
        {
            int IdWyp = Convert.ToInt32(txtWyszukajAktywne.Text);
            Connector connector = new Connector();
            
            dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("*", "Wypozyczenia", $"WHERE IdWypozyczenia = {IdWyp} AND where CzyRozliczone = 0");
            dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV(" IdSprzet, Nazwa, Typ, Rozmiar, Regał, Półka, Cena", "Worek", $"Where WypozyczenieID = {IdWyp}");



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
                int Płatność = 0 ;
                int godz;
                if (teraz > DataZwrotu)
                {

                    godz = (int)nadgodziny.TotalHours;
                    Płatność = PłatnośćPodstawowa + (godz * 10);

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
                MessageBox.Show($"Należy pobrać od klienta: {Płatność} PLN. Płatność podstawowa:{PłatnośćPodstawowa} PLN, Nadpłata za nadgodziny: {Płatność - PłatnośćPodstawowa} PLN.");

                Connector connector = new Connector();
                dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
                //dodać, żeby z worka czyściło itemki i wracały na magazyn

            }


        }

        private void btnWydaj_Click(object sender, EventArgs e)
        {
            if (dgvAktywneZamP.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAktywneZamP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAktywneZamP.Rows[selectedRowIndex];
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
                dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0 ");


            }
        }

        private void btnUsunZamowienie_Click(object sender, EventArgs e)
        {

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
                    //Connector connector = new Connector();
                    //dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Regał, Półka", "Worek", $"Where WypozyczenieID = {IndeksZbazy}");
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

        }

        private void formPracownik_FormClosed(object sender, FormClosedEventArgs e)
        {
            formWybor form = new formWybor();
            form.Show();
        }

        private void formPracownik_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
           
        }
    }
}
