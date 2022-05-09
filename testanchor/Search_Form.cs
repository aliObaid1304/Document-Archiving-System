using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testanchor.Modellers;

namespace testanchor
{
    public partial class Search_Form : MetroFramework.Forms.MetroForm
    {
        public static ArrayList search_array = new ArrayList();
        public static int book_type;
        public static string book_number;
        public static DateTime date_from;
        public static DateTime date_to;
        public static int selected_id;



        public Search_Form()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            //       dateTimePicker1.Value ;
        }

        private void Search_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["amount"].Visible = false;
            dataGridView1.Columns["rec_no"].Visible = false;
            dataGridView1.Columns["rec_date"].Visible = false;


            comboBox1.Items.Add(new { Text = "صادر", Value = 1 });
            comboBox1.Items.Add(new { Text = "وارد", Value = 2 });
            comboBox1.Items.Add(new { Text = "متفرقة", Value = 3 });
            comboBox1.Items.Add(new { Text = "وصل", Value = 4 });

            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            comboBox1.Visible = false;
            metroTextBox2.Visible = false;

            metroLabel1.Visible = false;
            metroLabel2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;



            DataGridViewButtonColumn update = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(update);
            update.HeaderText = "تعديل";
            update.Text = "تعديل";
            update.Name = "update";
            update.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn del = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(del);
            del.HeaderText = "حذف";
            del.Text = "حذف";
            del.Name = "del";
            del.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn lnk = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(lnk);
            lnk.HeaderText = "اضغط لفتح الملف";
            lnk.Name = "Link";
            lnk.Text = "افتح الملف";
            lnk.UseColumnTextForButtonValue = true;

        }


        public void loadDataset(String keyword)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            search_array.Clear();
            try

            {

                Search_Modeller smm = new Search_Modeller();
 
                search_array = smm.live_search(keyword);
                for (int i = 0; i < search_array.Count; i++)
                {
                
                        string date2 = "";
                        string date1 = ((Sader_Modeller)search_array[i]).book_date_sader.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                        if (((Sader_Modeller)search_array[i]).rec_date != null)
                        {
                            date2 = ((Sader_Modeller)search_array[i]).rec_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            date2 = "";
                        }
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                        row.Cells[0].Value = ((Sader_Modeller)search_array[i]).book_id;
                        row.Cells[1].Value = ((Sader_Modeller)search_array[i]).book_number_sader;
                        row.Cells[2].Value = date1;
                        row.Cells[3].Value = ((Sader_Modeller)search_array[i]).address_sader;
                        row.Cells[4].Value = ((Sader_Modeller)search_array[i]).subject_sader;
                        row.Cells[5].Value = ((Sader_Modeller)search_array[i]).notes_sader;
                        row.Cells[6].Value = ((Sader_Modeller)search_array[i]).post_type;
                        row.Cells[7].Value = ((Sader_Modeller)search_array[i]).class_indecator;
                        row.Cells[8].Value = ((Sader_Modeller)search_array[i]).rec_no;
                        row.Cells[9].Value = date2;
                        row.Cells[10].Value = ((Sader_Modeller)search_array[i]).rec_amount;
                        dataGridView1.Rows.Add(row);              
                }












                //string connetionString;
                //connetionString = "Integrated security=true;Initial Catalog=archive;Data source=DESKTOP-3N1JA5J\\SQLEXPRESS";
                //string sql = "";
                //if (!string.IsNullOrEmpty(keyword))
                //    sql = "SELECT id, book_number As 'رقم الكتاب', book_date As 'تاريخ الكتاب' FROM Posts where  book_number like '%" + keyword + "%'  or notes like '%" + keyword + "%'";
                //else
                //    sql = "SELECT id, book_number As 'رقم الكتاب', book_date As 'تاريخ الكتاب' FROM Posts";
                //SqlConnection connection = new SqlConnection(connetionString);
                //SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                //ds = new DataSet();
                //connection.Open();
                //dataadapter.Fill(ds, "Posts");
                //connection.Close();
                //dataGridView1.
                //dataGridView1.DataSource = ds;
                //// dataGridView1.Columns['Book_number'].ValueType = "dwdwdwd";
                //dataGridView1.DataMember = "Posts";


            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
                loadDataset(metroTextBox1.Text);
            else
                loadDataset("");
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            // MessageBox.Show(dataGridView1.Rows[(dataGridView1.CurrentRow.Index)].Cells[0].Value.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            try {
                //update button -> datagridview
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && e.ColumnIndex == 11)
                {
                 //   MessageBox.Show("update: " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    selected_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                  //  MessageBox.Show("first "+selected_id.ToString());
                    update_book_form up = new update_book_form();
                    up.Show();
                    
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    search_array.Clear();
                }

                // delete button
                else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 e.RowIndex >= 0 && e.ColumnIndex == 12)
                {

                    DialogResult dialogResult = MessageBox.Show("هل انت متاكد من حذف الملف؟", "!!! انتباه", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            Search_Modeller delete_file = new Search_Modeller();
                            int x = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                            delete_file.delete_record(x);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("لا يمكن حذف الملف");
                        }

                    }
                    else if ((dialogResult == DialogResult.No))
                    {
                        MessageBox.Show("تم الغاء عملية الحذف");
                    }
                  
                    // MessageBox.Show("delete file: " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }

                // open file button of the datagrideview
                else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && e.ColumnIndex == 13)
                {
             //       MessageBox.Show("Open File Link: " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    int x = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                  //  MessageBox.Show(getlink(x));            
                    try
                    {
                        System.Diagnostics.Process.Start(getlink(x));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("لا يمكن فتح الملف او قد يكون الملف محذوف او تالف ");
                    }



                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        public string getlink(int id)
        {
            string lnk = "";
            for (int i = 0; i < search_array.Count; i++)
            {
                if(((Sader_Modeller)search_array[i]).book_id==id)
                {
                    lnk = ((Sader_Modeller)search_array[i]).post_source_sader;
                }
            }
            return lnk;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show((comboBox1.SelectedItem as dynamic).Value.ToString());
          if((comboBox1.SelectedItem as dynamic).Value.ToString() =="4")
            {
                dataGridView1.Columns["amount"].Visible = true;
                dataGridView1.Columns["rec_no"].Visible = true;
                dataGridView1.Columns["rec_date"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["amount"].Visible = false;
                dataGridView1.Columns["rec_no"].Visible = false;
                dataGridView1.Columns["rec_date"].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parent = ((Control)sender).Parent.Parent;
            parent.Visible = false;
            parent.Dispose();
            parent = null;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            search_array.Clear();
            if (comboBox1.SelectedIndex == -1)
            {
                if (typeandnumber.Checked == true && dates.Checked == true)
                {
                    Search_Modeller sm = new Search_Modeller();
                    book_number = metroTextBox2.Text;
                    date_from = dateTimePicker2.Value;
                    date_to = dateTimePicker1.Value;
                string date1_format = date_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                string date2_format = date_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                search_array = sm.search_without_type_both(book_number, date1_format, date2_format);
                    for (int i = 0; i < search_array.Count; i++)
                    {
                        try
                        {
                            string date2 = "";
                            string date1 = ((Sader_Modeller)search_array[i]).book_date_sader.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                            if (((Sader_Modeller)search_array[i]).rec_date != null)
                            {
                                date2 = ((Sader_Modeller)search_array[i]).rec_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                date2 = "";
                            }
                            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                            row.Cells[0].Value = ((Sader_Modeller)search_array[i]).book_id;
                            row.Cells[1].Value = ((Sader_Modeller)search_array[i]).book_number_sader;
                            row.Cells[2].Value = date1;
                            row.Cells[3].Value = ((Sader_Modeller)search_array[i]).address_sader;
                            row.Cells[4].Value = ((Sader_Modeller)search_array[i]).subject_sader;
                            row.Cells[5].Value = ((Sader_Modeller)search_array[i]).notes_sader;
                            row.Cells[6].Value = ((Sader_Modeller)search_array[i]).post_type;
                            row.Cells[7].Value = get_book_type(((Sader_Modeller)search_array[i]).class_indecator);
                            row.Cells[8].Value = ((Sader_Modeller)search_array[i]).rec_no;
                            row.Cells[9].Value = date2;
                            row.Cells[10].Value = ((Sader_Modeller)search_array[i]).rec_amount;
                            dataGridView1.Rows.Add(row);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if(typeandnumber.Checked == true) 
                {
                  
                    Search_Modeller sm = new Search_Modeller();
                    book_number = metroTextBox2.Text;
                    date_from = dateTimePicker2.Value;
                    date_to = dateTimePicker1.Value;
                string date1_format = date_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                string date2_format = date_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                search_array = sm.search_without_type_with_number(book_number, date1_format, date2_format);
                    for (int i = 0; i < search_array.Count; i++)
                    {
                        try
                        {
                            string date2 = "";
                            string date1 = ((Sader_Modeller)search_array[i]).book_date_sader.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                            if (((Sader_Modeller)search_array[i]).rec_date != null)
                            {
                                 date2 = ((Sader_Modeller)search_array[i]).rec_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                 date2 = "";
                            }

                            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                            row.Cells[0].Value = ((Sader_Modeller)search_array[i]).book_id;
                            row.Cells[1].Value = ((Sader_Modeller)search_array[i]).book_number_sader;
                            row.Cells[2].Value = date1;
                            row.Cells[3].Value = ((Sader_Modeller)search_array[i]).address_sader;
                            row.Cells[4].Value = ((Sader_Modeller)search_array[i]).subject_sader;
                            row.Cells[5].Value = ((Sader_Modeller)search_array[i]).notes_sader;
                            row.Cells[6].Value = ((Sader_Modeller)search_array[i]).post_type;
                            row.Cells[7].Value = get_book_type(((Sader_Modeller)search_array[i]).class_indecator);
                            row.Cells[8].Value = ((Sader_Modeller)search_array[i]).rec_no;
                            row.Cells[9].Value = date2;
                            row.Cells[10].Value = ((Sader_Modeller)search_array[i]).rec_amount;
                            dataGridView1.Rows.Add(row);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }


                }
                else if (dates.Checked == true)
                {
               
                    Search_Modeller sm = new Search_Modeller();
                    book_number = metroTextBox2.Text;
                    date_from = dateTimePicker2.Value.Date;
                    date_to = dateTimePicker1.Value.Date;

                string date1_format = date_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                string date2_format = date_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                search_array = sm.search_without_type_dates(date1_format, date2_format);
                    for (int i = 0; i < search_array.Count; i++)
                    {
                      
                        try
                        {
                            string date2 = "";
                            string date1 = ((Sader_Modeller)search_array[i]).book_date_sader.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                            if (((Sader_Modeller)search_array[i]).rec_date != null)
                            {
                                date2 = ((Sader_Modeller)search_array[i]).rec_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                date2 = "";
                            }

               //         MessageBox.Show(date1.ToString() + "// Date 2 : " + date2.ToString());
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                            row.Cells[0].Value = ((Sader_Modeller)search_array[i]).book_id;
                            row.Cells[1].Value = ((Sader_Modeller)search_array[i]).book_number_sader;
                            row.Cells[2].Value = date1;
                            row.Cells[3].Value = ((Sader_Modeller)search_array[i]).address_sader;
                            row.Cells[4].Value = ((Sader_Modeller)search_array[i]).subject_sader;
                            row.Cells[5].Value = ((Sader_Modeller)search_array[i]).notes_sader;
                            row.Cells[6].Value = ((Sader_Modeller)search_array[i]).post_type;
                            row.Cells[7].Value = get_book_type(((Sader_Modeller)search_array[i]).class_indecator);
                            row.Cells[8].Value = ((Sader_Modeller)search_array[i]).rec_no;
                            row.Cells[9].Value = date2;
                            row.Cells[10].Value = ((Sader_Modeller)search_array[i]).rec_amount;
                            dataGridView1.Rows.Add(row);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            else if(comboBox1.SelectedIndex > -1)
            {
               
                Search_Modeller sm = new Search_Modeller();
                book_type = (comboBox1.SelectedItem as dynamic).Value;
          //      MessageBox.Show(book_type.ToString());
                book_number = metroTextBox2.Text;
                date_from = dateTimePicker2.Value;
                date_to = dateTimePicker1.Value;

                string date1_format = date_from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                string date2_format = date_to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                search_array = sm.get_all_search(book_type, book_number, date1_format, date2_format);
                for (int i = 0; i < search_array.Count; i++)
                {
                    try
                    {
                        string date2 = "";
                        string date1 = ((Sader_Modeller)search_array[i]).book_date_sader.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                        if (((Sader_Modeller)search_array[i]).rec_date != null)
                        {
                            date2 = ((Sader_Modeller)search_array[i]).rec_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            date2 = "";
                        }
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                        row.Cells[0].Value = ((Sader_Modeller)search_array[i]).book_id;
                        row.Cells[1].Value = ((Sader_Modeller)search_array[i]).book_number_sader;
                        row.Cells[2].Value = date1;
                        row.Cells[3].Value = ((Sader_Modeller)search_array[i]).address_sader;
                        row.Cells[4].Value = ((Sader_Modeller)search_array[i]).subject_sader;
                        row.Cells[5].Value = ((Sader_Modeller)search_array[i]).notes_sader;
                        row.Cells[6].Value = ((Sader_Modeller)search_array[i]).post_type;
                        row.Cells[7].Value = get_book_type(((Sader_Modeller)search_array[i]).class_indecator);
                        row.Cells[8].Value = ((Sader_Modeller)search_array[i]).rec_no;
                        row.Cells[9].Value = date2;
                        row.Cells[10].Value = ((Sader_Modeller)search_array[i]).rec_amount;
                        dataGridView1.Rows.Add(row);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


        }

        private void typeandnumber_CheckedChanged(object sender, EventArgs e)
        {
            if(typeandnumber.Checked==true)
            {
                metroLabel3.Visible = true;
                metroLabel4.Visible = true;
                comboBox1.Visible = true;
                metroTextBox2.Visible = true;
            }
            else if(typeandnumber.Checked == false)
            {
                metroLabel3.Visible = false;
                metroLabel4.Visible = false;
                comboBox1.Visible = false;
                metroTextBox2.Visible = false;


            }
        }

        private void dates_CheckedChanged(object sender, EventArgs e)
        {
            if (dates.Checked == true)
            {
                metroLabel1.Visible = true;
                metroLabel2.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
            }
            else if (dates.Checked == false)
            {
                metroLabel1.Visible = false;
                metroLabel2.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
        }

        public ArrayList dataarray()
        {
            return search_array;
        }

        public int send_id()
        {
            return selected_id;
        }

        public string get_book_type(string x)
        {
            string book ="";
            if(x == "1")
            {
                book = "صادر";
            }
            else if (x == "2")
            {
                book = "وارد";
            }
            else if (x == "3")
            {
                book = "متفرقة";
            }
            else if (x == "4")
            {
                book = "وصل";
            }
            return book;
        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
