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

            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Typ  FROM SprzetNarciarski", connectionString);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //foreach (DataRow row in table.Rows)
            //{
            //    dropKategorie.Items.Add(row["Typ"].ToString());
            //}
            Connector connector = new Connector();
            connector.UzupelnijTypy(dropKategorie);

        }

        private void dropKategorie_SelectedValueChanged(object sender, EventArgs e)
        {

            string typ = dropKategorie.SelectedItem.ToString();
            
            Connector connector = new Connector();
            dataGridView1.DataSource = connector.PobierzDaneDoDGV("Nazwa, Typ, Rozmiar", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
            //DataTable dt = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
            //foreach (DataRow row in dt.Rows)
            //{
            //    if ((int)row["IdSprzet"] == 10)
            //    {
            //        MessageBox.Show("siema");
            //    }
            
            

        }

        private void btnDodajDoZamowienia_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            }

                        

        }
    }
}
