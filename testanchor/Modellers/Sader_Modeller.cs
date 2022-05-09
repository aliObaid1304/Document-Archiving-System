using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testanchor.Modellers
{
    class Sader_Modeller
    {

        public SqlConnection con;
        public SqlCommand cmd;
        private string last_record = "0";
        public int book_id { get; set; }
        public string book_number_sader { get; set; }
        public DateTime book_date_sader { get; set; }
        public string address_sader { get; set; }
        public string subject_sader { get; set; }
        public string notes_sader { get; set; }
        public string class_indecator { get; set; }
        public string post_source_sader { get; set; }
        public string post_type { get; set; }

        public string user_id { get; set; }

        public string is_active { get; set; }

        public string rec_amount { get; set; }
        public string rec_no { get; set; }
        public DateTime rec_date { get; set; }

        ArrayList arr = new ArrayList();

        public Boolean addtodb(ArrayList sader_arraylist)
        {

         //   MessageBox.Show(((Sader_Modeller)sader_arraylist[0]).book_number_sader);


            if (connection())
            {
                string s = "insert into Posts (book_number,book_date,from_to,subject,notes,class_indicator,recieve_type,book_source,amount,rec_no,rec_date,is_ative) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,0)";
                cmd = new SqlCommand(s, con);
              //  MessageBox.Show(((Sader_Modeller)sader_arraylist[0]).post_type);
                cmd.Parameters.AddWithValue("@p1", ((Sader_Modeller)sader_arraylist[0]).book_number_sader);
                cmd.Parameters.AddWithValue("@p2", ((Sader_Modeller)sader_arraylist[0]).book_date_sader);
                cmd.Parameters.AddWithValue("@p3", ((Sader_Modeller)sader_arraylist[0]).address_sader);
                cmd.Parameters.AddWithValue("@p4", ((Sader_Modeller)sader_arraylist[0]).subject_sader);
                cmd.Parameters.AddWithValue("@p5", ((Sader_Modeller)sader_arraylist[0]).notes_sader);
                cmd.Parameters.AddWithValue("@p6", ((Sader_Modeller)sader_arraylist[0]).class_indecator);
                cmd.Parameters.AddWithValue("@p7", ((Sader_Modeller)sader_arraylist[0]).post_type);
                cmd.Parameters.AddWithValue("@p8", ((Sader_Modeller)sader_arraylist[0]).post_source_sader);

                cmd.Parameters.AddWithValue("@p9", ((Sader_Modeller)sader_arraylist[0]).rec_amount);
                cmd.Parameters.AddWithValue("@p10", ((Sader_Modeller)sader_arraylist[0]).rec_no);
                cmd.Parameters.AddWithValue("@p11", ((Sader_Modeller)sader_arraylist[0]).rec_date);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            return true;
        }

        

        // update the record 
        public Boolean update_db(ArrayList sader_arraylist)
        {

            //   MessageBox.Show(((Sader_Modeller)sader_arraylist[0]).book_number_sader);


            if (connection())
            {
                try
                {

               
                book_id = ((Sader_Modeller)sader_arraylist[0]).book_id;
              //      MessageBox.Show("lkjkjijij :"+book_id.ToString());
                string s = "update Posts set book_number = @p1,book_date = @p2,from_to = @p3,subject =@p4,notes =@p5,class_indicator = @p6,recieve_type = @p7,book_source = @p8,amount = @p9,rec_no = @p10,rec_date = @p11 where id ='"+ book_id +"'";
                cmd = new SqlCommand(s, con);
                MessageBox.Show(((Sader_Modeller)sader_arraylist[0]).post_type);
                cmd.Parameters.AddWithValue("@p1", ((Sader_Modeller)sader_arraylist[0]).book_number_sader);
                cmd.Parameters.AddWithValue("@p2", ((Sader_Modeller)sader_arraylist[0]).book_date_sader);
                cmd.Parameters.AddWithValue("@p3", ((Sader_Modeller)sader_arraylist[0]).address_sader);
                cmd.Parameters.AddWithValue("@p4", ((Sader_Modeller)sader_arraylist[0]).subject_sader);
                cmd.Parameters.AddWithValue("@p5", ((Sader_Modeller)sader_arraylist[0]).notes_sader);
                cmd.Parameters.AddWithValue("@p6", ((Sader_Modeller)sader_arraylist[0]).class_indecator);
                cmd.Parameters.AddWithValue("@p7", ((Sader_Modeller)sader_arraylist[0]).post_type);
                cmd.Parameters.AddWithValue("@p8", ((Sader_Modeller)sader_arraylist[0]).post_source_sader);

                cmd.Parameters.AddWithValue("@p9", ((Sader_Modeller)sader_arraylist[0]).rec_amount);
                cmd.Parameters.AddWithValue("@p10", ((Sader_Modeller)sader_arraylist[0]).rec_no);
                cmd.Parameters.AddWithValue("@p11", ((Sader_Modeller)sader_arraylist[0]).rec_date);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return true;
        }









        public ArrayList list_all()
        {

            if (connection())
            {
                SqlCommand command = new SqlCommand("Select id,name from recieveing_type", con);
                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        //  MessageBox.Show(reader["id"].ToString());

                        RecievingType_Modeller rt = new RecievingType_Modeller();
                        rt.re_id = int.Parse(reader["id"].ToString());
                        rt.re_name = reader["name"].ToString();
                        arr.Add(rt);
                    }
                }
                con.Close();
            }
            return arr;
        }


        public bool connection()
        {
            try
            {
            //    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
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



        public Boolean addTheImportedExcel(ArrayList sader_arraylist)
        {

            //   MessageBox.Show(((Sader_Modeller)sader_arraylist[0]).book_number_sader);


            if (connection())
            {
                string s = "insert into Posts (book_number,book_date,from_to,subject,notes,class_indicator,recieve_type,book_source,amount,rec_no,rec_date,is_ative,user_id) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)";
                cmd = new SqlCommand(s, con);
             //   MessageBox.Show(((Sader_Modeller)sader_arraylist[0]).post_type);
                cmd.Parameters.AddWithValue("@p1", ((Sader_Modeller)sader_arraylist[0]).book_number_sader);
                cmd.Parameters.AddWithValue("@p2", ((Sader_Modeller)sader_arraylist[0]).book_date_sader);
                cmd.Parameters.AddWithValue("@p3", ((Sader_Modeller)sader_arraylist[0]).address_sader);
                cmd.Parameters.AddWithValue("@p4", ((Sader_Modeller)sader_arraylist[0]).subject_sader);
                cmd.Parameters.AddWithValue("@p5", ((Sader_Modeller)sader_arraylist[0]).notes_sader);
                cmd.Parameters.AddWithValue("@p6", ((Sader_Modeller)sader_arraylist[0]).class_indecator);
                cmd.Parameters.AddWithValue("@p7", ((Sader_Modeller)sader_arraylist[0]).post_type);
                cmd.Parameters.AddWithValue("@p8", ((Sader_Modeller)sader_arraylist[0]).post_source_sader);

                cmd.Parameters.AddWithValue("@p9", ((Sader_Modeller)sader_arraylist[0]).rec_amount);
                cmd.Parameters.AddWithValue("@p10", ((Sader_Modeller)sader_arraylist[0]).rec_no);
                cmd.Parameters.AddWithValue("@p11", ((Sader_Modeller)sader_arraylist[0]).rec_date);
                cmd.Parameters.AddWithValue("@p12", ((Sader_Modeller)sader_arraylist[0]).is_active);
                cmd.Parameters.AddWithValue("@p13", ((Sader_Modeller)sader_arraylist[0]).user_id);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            return true;
        }

        public string get_last_book_no()
        {
            var resultString="";
            if (connection())
            {
                //    SqlCommand command = new SqlCommand("Select id,name from recieveing_type", con);
                SqlCommand command = new SqlCommand("SELECT TOP 1 id ,book_source  FROM Posts ORDER BY id DESC", con);
                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        //  MessageBox.Show(reader["id"].ToString());
                        last_record = reader["book_source"].ToString();
                    }
                }
                con.Close();
            }

             
        //    MessageBox.Show(resultString);

            if(last_record == "0")
            {
                resultString = "1";
            }
            else
            {
                resultString = Regex.Match(last_record, @"\d+").Value;
            }
            return resultString;
        }

    }
}
