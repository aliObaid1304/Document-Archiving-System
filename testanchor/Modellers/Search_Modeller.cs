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
    class Search_Modeller
    {
        public SqlConnection con;
        public SqlCommand cmd;
        ArrayList arr = new ArrayList();




        public ArrayList get_all_search(int book_type, string book_number,string date_from, string date_to)
        {

            if (connection())
            {
                try {
                    SqlCommand command = new SqlCommand("Select Posts.id as id,book_number,book_date,from_to,subject,notes,class_indicator,user_id, " +
                        " recieveing_type.name as re_type, is_ative,book_source,amount,rec_no,rec_date from Posts " +
                         "  inner join recieveing_type on recieveing_type.id = Posts.recieve_type " +
                        " where is_ative=0 and class_indicator=" + book_type + " and book_number like  N'%" + book_number + "%'" +
                         " or class_indicator=" + book_type + " and book_number like  N'%" + book_number + "%'" +
                        "  and is_ative=0 and book_date between '" + date_from + "' and '" + date_to + "'",con);
                            // int result = command.ExecuteNonQuery();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                            Sader_Modeller sm = new Sader_Modeller();

                            sm.book_id = int.Parse(reader["id"].ToString());
                            sm.book_number_sader = reader["book_number"].ToString();
                            sm.book_date_sader = DateTime.Parse(reader["book_date"].ToString());
                            sm.address_sader = reader["from_to"].ToString();
                            sm.subject_sader = reader["subject"].ToString();
                            sm.notes_sader = reader["notes"].ToString();
                            sm.class_indecator = reader["class_indicator"].ToString();
                            sm.post_type = reader["re_type"].ToString();
                            sm.post_source_sader = reader["book_source"].ToString();
                            sm.rec_no = reader["rec_no"].ToString();
                            sm.rec_date = DateTime.Parse(reader["rec_date"].ToString());
                            sm.rec_amount = reader["amount"].ToString();

                            //
                         //   MessageBox.Show(sm.book_number_sader);
                            arr.Add(sm);
                        }
                            }
                con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return arr;
        }



        public ArrayList search_without_type_both(string book_number, string date_from, string date_to)
        {

            if (connection())
            {
                try
                {
                    SqlCommand command = new SqlCommand("Select Posts.id as id,book_number,book_date,from_to,subject,notes,class_indicator,user_id, " +
                        " recieveing_type.name as re_type, is_ative,book_source,amount,rec_no,rec_date from Posts " +
                        "  inner join recieveing_type on recieveing_type.id = Posts.recieve_type " +
                        " where is_ative=0 and book_number like  N'%" + book_number + "%'" +         
                        " and book_date between '" + date_from + "' and '" + date_to + "'"+
                        " or book_number like  N'%" + book_number + "%' and is_ative=0", con);
                    // int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sader_Modeller sm = new Sader_Modeller();
                           
                            sm.book_id =int.Parse(reader["id"].ToString()) ;
                            sm.book_number_sader = reader["book_number"].ToString();
                            sm.book_date_sader =DateTime.Parse(reader["book_date"].ToString());
                            sm.address_sader = reader["from_to"].ToString();
                            sm.subject_sader = reader["subject"].ToString();
                            sm.notes_sader = reader["notes"].ToString();
                            sm.class_indecator = reader["class_indicator"].ToString();
                            sm.post_type = reader["re_type"].ToString();
                            sm.post_source_sader = reader["book_source"].ToString();
                            sm.rec_no = reader["rec_no"].ToString();
                            sm.rec_date = DateTime.Parse(reader["rec_date"].ToString());
                            sm.rec_amount = reader["amount"].ToString();

                    //        MessageBox.Show(sm.book_number_sader);
                            arr.Add(sm);
                        }
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return arr;
        }

        public ArrayList search_without_type_with_number(string book_number, string date_from, string date_to)
        {

            if (connection())
            {
                try
                {
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return arr;
        }


        public ArrayList search_without_type_dates(string date_from, string date_to)
        {
           Console.WriteLine(date_from.ToString());
            if (connection())
            {
                try
                {
                    SqlCommand command = new SqlCommand("Select Posts.id as id,book_number,book_date,from_to,subject,notes,class_indicator,user_id, " +
                        " recieveing_type.name as re_type, is_ative,book_source,amount,rec_no,rec_date from Posts " +
                         "  inner join recieveing_type on recieveing_type.id = Posts.recieve_type " +
                        " where is_ative=0 and book_date between '" + date_from + "' and '" + date_to + "'", con);
                    // int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                           
                            Sader_Modeller sm = new Sader_Modeller();
                           
                            sm.book_id =int.Parse(reader["id"].ToString()) ;
                            sm.book_number_sader = reader["book_number"].ToString();
                            sm.book_date_sader =DateTime.Parse(reader["book_date"].ToString());
                            sm.address_sader = reader["from_to"].ToString();
                            sm.subject_sader = reader["subject"].ToString();
                            sm.notes_sader = reader["notes"].ToString();
                            sm.class_indecator = reader["class_indicator"].ToString();
                            sm.post_type = reader["re_type"].ToString();
                            sm.post_source_sader = reader["book_source"].ToString();
                            sm.rec_no = reader["rec_no"].ToString();
                            sm.rec_date = DateTime.Parse(reader["rec_date"].ToString());
                            sm.rec_amount = reader["amount"].ToString();

                          //  MessageBox.Show(sm.book_number_sader);
                            arr.Add(sm);
                        }
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return arr;
        }






        public ArrayList live_search(string keyword)
        {

            if (connection())
            {
                try
                {
                    SqlCommand command = new SqlCommand("Select Posts.id as id,book_number,book_date,from_to,subject,notes,class_indicator,user_id, " +
                        " recieveing_type.name as re_type, is_ative,book_source,amount,rec_no,rec_date from Posts " +
                        "  inner join recieveing_type on recieveing_type.id = Posts.recieve_type " +
                        " where is_ative=0 and book_number like N'%" + keyword + "%'" +
                        " or from_to like N'%" + keyword + "%' and is_ative=0" +
                        " or subject like N'%" + keyword + "%' and is_ative=0" +
                        " or notes like N'%" + keyword + "%' and is_ative=0", con);
                    // int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sader_Modeller sm = new Sader_Modeller();

                            sm.book_id = int.Parse(reader["id"].ToString());
                            sm.book_number_sader = reader["book_number"].ToString();
                            sm.book_date_sader = DateTime.Parse(reader["book_date"].ToString());
                            sm.address_sader = reader["from_to"].ToString();
                            sm.subject_sader = reader["subject"].ToString();
                            sm.notes_sader = reader["notes"].ToString();
                            sm.class_indecator = reader["class_indicator"].ToString();
                            sm.post_type = reader["re_type"].ToString();
                            sm.post_source_sader = reader["book_source"].ToString();
                            sm.rec_no = reader["rec_no"].ToString();
                            sm.rec_date = DateTime.Parse(reader["rec_date"].ToString());
                            sm.rec_amount = reader["amount"].ToString();

                            //        MessageBox.Show(sm.book_number_sader);
                            arr.Add(sm);
                        }
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return arr;
        }




    public string total_sader()
        {
            string total_sader="";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT count(id) as total FROM Posts where is_ative=0 and class_indicator = '1'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total_sader = reader["total"].ToString();
                    }
                }
                con.Close();
            }
            return total_sader;
    }


        public string total_warid()
        {
            string total_sader = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT count(id) as total FROM Posts where is_ative=0 and class_indicator = '2'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total_sader = reader["total"].ToString();
                    }
                }
                con.Close();
            }
            return total_sader;
        }




        public string total_mutf()
        {
            string total_sader = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT count(id) as total FROM Posts where is_ative=0 and class_indicator = '3' or class_indicator='4'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total_sader = reader["total"].ToString();
                    }
                }
                con.Close();
            }
            return total_sader;
        }




        public string total_all()
        {
            string total_sader = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT count(id) as total FROM Posts where is_ative=0", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total_sader = reader["total"].ToString();
                    }
                }
                con.Close();
            }
            return total_sader;
        }


        public string total_deleted()
        {
            string total_sader = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT count(id) as total FROM Posts where is_ative=1", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total_sader = reader["total"].ToString();
                    }
                }
                con.Close();
            }
            return total_sader;
        }


        public string get_total_documents()
        {
            string total_doc = "";
            if (connection())
            {
                SqlCommand command = new SqlCommand("SELECT total_doc as total FROM users", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total_doc = reader["total"].ToString();
                    }
                }
                con.Close();
            }
            return total_doc;
        }

        public bool update_total_documents(long new_total)
        {
            bool flag = false;
            if (connection())
            {
                SqlCommand command = new SqlCommand("update users set total_doc="+ new_total, con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    flag = true;
                }
                con.Close();
            }
            return flag ;
        }

        public bool unactivate()
        {
            bool flag = false;
            if (connection())
            {
                SqlCommand command = new SqlCommand("update users set indicator=0 , auth_key=''", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    flag = true;
                }
                con.Close();
            }
            return flag;
        }



        public int delete_record(int record)
        {
            int flag = 0;
            if (connection())
            {
                SqlCommand command = new SqlCommand("update Posts set is_ative  = 1 where id ='"+ record+"'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                        flag = 1;
                        MessageBox.Show("تم حذف الملف بنجاح");
                   
                }
                con.Close();
            }
            return flag;
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



        // export to external excel file
        public List<Sader_Modeller> ExportToExcel()
        {
            var newlist = new List<Sader_Modeller>();
            if (connection())
            {
                try
                {
                    SqlCommand command = new SqlCommand("Select Posts.id as id,book_number,book_date,from_to,subject,notes,class_indicator,user_id, " +
                        " recieve_type as re_type, is_ative,book_source,amount,rec_no,rec_date from Posts ", con);
                    // int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sader_Modeller sm = new Sader_Modeller();

                            sm.book_id = int.Parse(reader["id"].ToString());
                            sm.book_number_sader = reader["book_number"].ToString();
                            sm.book_date_sader = DateTime.Parse(reader["book_date"].ToString());
                            sm.address_sader = reader["from_to"].ToString();
                            sm.subject_sader = reader["subject"].ToString();
                            sm.notes_sader = reader["notes"].ToString();
                            sm.class_indecator = reader["class_indicator"].ToString();
                            sm.user_id = reader["user_id"].ToString();
                            sm.is_active = reader["is_ative"].ToString();
                            sm.post_type = reader["re_type"].ToString();
                            sm.post_source_sader = reader["book_source"].ToString();
                            sm.rec_no = reader["rec_no"].ToString();
                            sm.rec_date = DateTime.Parse(reader["rec_date"].ToString());
                            sm.rec_amount = reader["amount"].ToString();

                            //        MessageBox.Show(sm.book_number_sader);
                            newlist.Add(sm);
                        }
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return newlist;
        }
    }
}
