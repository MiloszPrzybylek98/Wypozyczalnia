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
    public partial class formWybor : Form
    {
        public formWybor()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-O35IPPN;Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True";

        private void btnModPracownika_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connection);
            //conn.Open();
            //if (conn.State == ConnectionState.Open)
            //{
            //    string passy = "select";
            //}

            formLogowaniePracownika form2 = new formLogowaniePracownika();
            this.Hide(); //ogarnac to
            form2.Visible = true;

           





        }
        
    }

}
