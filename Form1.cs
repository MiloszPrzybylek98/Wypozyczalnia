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


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Wypozyczenia DEFAULT VALUES", connection))
                {

                    //command.Parameters.AddWithValue("@Nazwa", nazwa);
                    //command.Parameters.AddWithValue("@Typ", typ);
                    //command.Parameters.AddWithValue("@Dostępność", dostepnosc);
                    //command.Parameters.AddWithValue("@Rozmiar", rozmiar);
                    //command.Parameters.AddWithValue("@Regal", regal);
                    //command.Parameters.AddWithValue("@Polka", polka);
                    int result = command.ExecuteNonQuery();

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
           DataTable dt = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
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

            int IdDoBazy = (int)dt2.Rows[0][0];
            //trzeba dodać tworzenie nowego zamówienia w momencie ładowania forma i pobrać jego ID
            //w momencie dodania itemka do zamowienia: musimy zmienic dostępność przemiotu w sprzęcie na 0, dodać do worka wraz z id zamowienia i id sprzetu
            //potem w dgv po prawo wyświetlamy zawartość worka(najłatwiej)
            //aktualizujemy sprzety do wypozyczenia(po prostu pobrać)
            //jesli chcemy usunac z worka to wywalamy i zmieniamy dostepnosc na 1
            //trzeba dodac cos z pieniedzmi d bazy danych, jakies ceny produktow za dobe czy cos(też to można wyświetlać)
            




            dt2.Columns.RemoveAt(0);
            dataGridView2.DataSource = dt2;
            
            



            //foreach(DataRow row in dt.Rows)
            //{
            //    if (row.Table.Rows.IndexOf(row) == 1)
            //    {
            //        row.Table.Rows.Remove(row);
            //    }
            //}

            //DataTable dr = dt.Clone();
            // dr.NewRow();
            // var data = dt.Rows()
            // dr.Rows.Add(new object[] { dt.Rows[selectedRow] });
            //dr.Table.Rows.Add((DataRow)dt.Rows[selectedRow].); 


            //(DataRow)


            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    

            //}

            //DataTable dt = connector.PobierzDaneDoDGV("IdSprzet, Nazwa, Typ, Rozmiar", "SprzetNarciarski", "WHERE Typ = '" + typ + "'" + "AND Dostępność = 1");
            //foreach (DataRow row in dt.Rows)
            //{
            //    if ((int)row["IdSprzet"] == 10)
            //    {
            //        MessageBox.Show("siema");
            //    }






        }

        private void dropKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
