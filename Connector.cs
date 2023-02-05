using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Reflection.Emit;

namespace Wypozyczalnia
{
    public class Connector
    {
         string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";

        public DataTable PobierzDaneDoDGV(string daneDoPobrania, string tabela, string warunek)
        {
            
        
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT  {daneDoPobrania}  FROM {tabela} {warunek} ", connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            return table;
           
        }

        public void DodajDaneDoTabeli(string tabelaDoDodania )
        {
            //INSERT INTO SprzeSprzetNarciarski(Nazwa, Typ, Rozmiar, Dostępność, Regał, Półka) 
            //    VALUES(@txtNazwaDodaj.text, @comboTypP.selectedItem, Dostępność = '1', @txtRegalDodaj.text, @txtPolkaDodaj.text)

                SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO Typ  FROM SprzetNarciarski", connectionString);


        }





        public void UzupelnijWorek()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT  FROM ", connectionString);


        }

        public void UzupelnijTypy(ComboBox dropdown)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Typ  FROM SprzetNarciarski", connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                dropdown.Items.Add(row["Typ"].ToString());
            }
        }

        public int PobierzCeneZamowieniaZWorka(int idWypozyczenia)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"SELECT SUM(Cena)  FROM Worek  Where WypozyczenieID = {idWypozyczenia}", connection))
                {
                    try
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception)
                    {

                        return 0;
                    }
                    

                }

            }



        }

        //public void InsertTabela(string tabela , List<string> lista, string warunek)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string sqlQuery = "INSERT INTO "+ tabela + " (";
        //        foreach (string item in lista) 
        //        {
        //            sqlQuery += item + ",";

        //        }
        //        sqlQuery = sqlQuery.Remove(sqlQuery.Length - 1);
        //        sqlQuery += ") VALUES(";

        //        foreach (string item in lista)
        //        {
        //            sqlQuery += "@"+item + ", ";

        //        }
        //        sqlQuery += ") ";
        //        sqlQuery += warunek;

        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
        //        {
        //            foreach (string item in lista)
        //            {
        //                command.Parameters.AddWithValue($"@{item}", item);
        //            }

        //            int result = command.ExecuteNonQuery();

        //        }

        //    }
        //}







    }
}
