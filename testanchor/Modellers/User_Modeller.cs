using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testanchor.Modellers
{
    class User_Modeller
    {
        public SqlConnection con;
        public SqlCommand cmd;
        ArrayList arr = new ArrayList();

        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string auth_key_modeller { get; set; }



        public Boolean addtodb(ArrayList sader_arraylist)
        {

            //   MessageBox.Show(((Sader_Modeller)sader_arraylist[0]).book_number_sader);

            try
            {
                if (connection())
                {
                    string s = "update users set name = @p1 ,username = @p2,password = @p3, indicator=1 where id = 1";
                    cmd = new SqlCommand(s, con);
                    // MessageBox.Show(((User_Modeller)sader_arraylist[0]).name.ToString());
                    cmd.Parameters.AddWithValue("@p1", ((User_Modeller)sader_arraylist[0]).name);
                    cmd.Parameters.AddWithValue("@p2", ((User_Modeller)sader_arraylist[0]).username);
                    cmd.Parameters.AddWithValue("@p3", ((User_Modeller)sader_arraylist[0]).password);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        public bool connection()
        {
            try
            {
               // con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
               con = new SqlConnection("Integrated security=true;Initial Catalog=archive;Data source=DESKTOP-3N1JA5J\\SQLEXPRESS");

                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("! لا يمكن الاتصال بقواعد البيانات ");
                return false;
            }
        }
    }
}
