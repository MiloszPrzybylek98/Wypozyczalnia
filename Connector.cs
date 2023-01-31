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





    }
}
