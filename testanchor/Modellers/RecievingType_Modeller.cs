using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testanchor.Modellers
{
    class RecievingType_Modeller
    {

        public SqlCommand cmd;
        public SqlConnection con;

        public int re_id { get; set; }
        public string re_name { get; set; }

        // get all types of reciving posts




        public bool connection()
        {
            try
            {
              //  con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
               con = new SqlConnection("Integrated security=true;Initial Catalog=archive;Data source=DESKTOP-3N1JA5J\\SQLEXPRESS");

                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
