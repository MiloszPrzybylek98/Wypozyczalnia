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

namespace Wypozyczalnia
{
    public partial class formEkranKlienta : Form
    {
        public formEkranKlienta()
        {
            InitializeComponent();
        }
        string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";

        private void formEkranKlienta_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Typ  FROM SprzetNarciarski", connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                dropKategorie.Items.Add(row["Typ"].ToString());
            }
        }

        private void dropKategorie_SelectedValueChanged(object sender, EventArgs e)
        {

            string typ = dropKategorie.SelectedItem.ToString();
            
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT Nazwa, Typ, Rozmiar  FROM SprzetNarciarski WHERE Typ = '" + typ + "'"+"AND Dostępność = 1", connectionString);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            Connector connector = new Connector();
            dataGridView1.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");

        }

        private void btnDodajDoZamowienia_Click(object sender, EventArgs e)
        {

        }
    }
}
