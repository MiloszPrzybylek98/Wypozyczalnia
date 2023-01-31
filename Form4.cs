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
    }
}
