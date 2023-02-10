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
            Connector connector = new Connector();
            connector.UzupelnijTypy(comboTypP);
            Connector connector1 = new Connector();
            connector1.UzupelnijTypy(comboTypDodaj);

            Connector connector2 = new Connector();          
            dgvMagazynP.DataSource = connector2.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka", "SprzetNarciarski", ";");


            dgvAktywneZamP.DataSource = connector2.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "where CzyRozliczone = 0");
        }

        private void comboTypP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typ = comboTypP.SelectedItem.ToString();

            Connector connector = new Connector();
            dgvMagazynP.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka", "SprzetNarciarski", "WHERE Typ = '" + typ + "'");
        }

        private void btnDodajSprzetDoMagazynu_Click(object sender, EventArgs e)
        {
            string typ = comboTypDodaj.SelectedItem.ToString();
            string nazwa = txtNazwaDodaj.Text;
            string rozmiar = txtRozmiarDodaj.Text;
            int dostepnosc = 1;
            int regal = (int)numRegalDodaj.Value;
            int polka = (int)numPolkaDodaj.Value;



            //INSERT INTO SprzetNarciarski(Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka) VALUES(@Nazwa, @Typ, @Dostępność = '1', @Regal, @Polka)




            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO SprzetNarciarski(Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka) VALUES(@Nazwa, @Typ, @Rozmiar, @Dostępność, @Regal, @Polka)", connection))
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
                dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Regał, Półka", "Worek", $"Where WypozyczenieID = {IndeksZbazy}");


            }

        }

        private void btnSzukajZamowienia_Click(object sender, EventArgs e)
        {
            int IdWyp = Convert.ToInt32(txtWyszukajAktywne.Text);
            Connector connector = new Connector();
            
            dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("*", "Wypozyczenia", $"WHERE IdWypozyczenia = {IdWyp} AND where CzyRozliczone = 0");
            dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Regał, Półka", "Worek", $"Where WypozyczenieID = {IdWyp}");



            //foreach (var item in dt.Rows)
            //{

            //    foreach (DataColumn items in item. )
            //    {

            //    }



            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        using (SqlCommand command = new SqlCommand($"SELECT * from Wypozyczenia Where KlientId = @KlientId ", connection))
            //        {
            //            int id = (int)item.;
            //            command.Parameters.AddWithValue("@KlientID", item);   
            //            DataRow dr = (DataRow)command.ExecuteScalar();
            //            dt2.Rows.Add(dr);


            //        }
            //    }

            //}



            //foreach (var item in dt.Rows)
            //{
            //    dt2.Rows.Add( connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", $"Where KlientId = {item}"));
            //}

            //dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", "Where ");
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
                //Connector connector = new Connector();
                //dgvWorekZamP.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar, Regał, Półka", "Worek", $"Where WypozyczenieID = {IndeksZbazy}");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int rozliczenie = 1;
                    using (SqlCommand command = new SqlCommand($"UPDATE Wypozyczenia  SET CzyRozliczone= @CzyRozliczone Where IdWypozyczenia = @IdWypozyczenia  ", connection))
                    {


                        command.Parameters.AddWithValue("@CzyRozliczone", rozliczenie);
                        command.Parameters.AddWithValue("@IdWypozyczenia", IndeksZbazy);
                        command.ExecuteNonQuery();


                    }

                }

                Connector connector = new Connector();
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
                dgvAktywneZamP.DataSource = connector.PobierzDaneDoDGV("IdWypozyczenia, KlientId, Data_Wypożyczenia, Data_zwrotu, Płatność, CzyRozliczone, CzyWydane", " Wypozyczenia", ";");


            }
        }
    }
}
