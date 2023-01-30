using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

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





    }
}
