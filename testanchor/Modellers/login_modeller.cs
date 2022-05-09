using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testanchor.Modellers
{
    class login_modeller
    {
        public SqlConnection con;
        public SqlCommand cmd;

        public string initail_login(string username, string password)
        {
            string id = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT id FROM users where username = '" + username + "' and password = '" + password + "'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader["id"].ToString();
                    }
                }
                con.Close();
            }

            return id;
        }



        public string checkaccount(string username, string password)
        {
            string indicator = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT indicator FROM users where username = '" + username + "' and password = '" + password + "'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        indicator = reader["indicator"].ToString();
                    }
                }
                con.Close();
            }

            return indicator;
        }

        public string login(string username, string password)
        {
            string key = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT auth_key FROM users where username = '" + username + "' and password = '"+ password + "'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        key = reader["auth_key"].ToString();
                    }
                }
                con.Close();
            }

            return key;
        }



        public string update_license(string username, string lis_key)
        {
            string key = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("update users set auth_key ='"+lis_key+"' where username = '" + username + "'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    key = "ok";  
                }
                con.Close();
            }

            return key;
        }



        


 


    }
}
