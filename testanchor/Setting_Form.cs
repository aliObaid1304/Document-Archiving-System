using ExcelDataReader;
using Ganss.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using testanchor.Modellers;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;

namespace testanchor
{
    public partial class Setting_Form :MetroFramework.Forms.MetroForm
    {
        private static string fname = "";
        public Setting_Form()
        {
            InitializeComponent();
        }

        private void Setting_Form_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            panel1.Visible = false;
            upload_btn.Visible = false;
            metroLabel4.Visible = false;
            panel2.Visible = true;
          
        }
        private void export_data()
        {
            try
            {
                    var export_array = new List<Sader_Modeller>();
                    Search_Modeller serm = new Search_Modeller();
                    export_array = serm.ExportToExcel();
                if (export_array.Count != 0)
                {
                    ExcelMapper mapper = new ExcelMapper();
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.InitialDirectory = @"C:\";
                    saveFileDialog1.Title = "Save Excel Files";
                    //  saveFileDialog1.CheckFileExists = true;
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        mapper.Save(saveFileDialog1.FileName, export_array, "Data", true);
                    }
                }
                else
                {
                    MessageBox.Show("لاتوجد بيانات");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
              
            export_data();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var parent = ((Control)sender).Parent.Parent;
            parent.Visible = false;
            parent.Dispose();
            parent = null;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Excel File Dialog";
                fdlg.InitialDirectory = @"c:\";
                fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    fname = fdlg.FileName;
                    Import(fname);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("حدث خطا, اما قد يكون الملف غير صالح او لا يحتوي على بيانات");
            }
         



            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter="Excel files (*.xlsx)|*.xlsx", ValidateNames = true })
            //{
            //    if(ofd.ShowDialog()==DialogResult.OK)
            //    {
            //        //   FileStream fs = new File.Open(ofd.FileName, FileMode.Open, FileAccess.Read));
            //        using (Stream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
            //        {
            //            MessageBox.Show(ofd.FileName.ToString());
            //            //using (IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs))
            //            //{
            //            //    DataSet result = reader.

            //            //}


            //        }
            //    }
            //}
        }




        


public System.Data.DataTable Import(String path)
{

    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
    Microsoft.Office.Interop.Excel.Workbook workBook = app.Workbooks.Open(path, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

    Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.ActiveSheet;

            int index = 0;
            object rowIndex = 2;

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("book_number");
            dt.Columns.Add("book_date");
            dt.Columns.Add("from_to");
            dt.Columns.Add("subject");
            dt.Columns.Add("notes");
            dt.Columns.Add("class_indicator");
            dt.Columns.Add("book_source");
            dt.Columns.Add("recieve_type");
            dt.Columns.Add("user_id");
            dt.Columns.Add("is_ative");
            dt.Columns.Add("amount");
            dt.Columns.Add("rec_no");
            dt.Columns.Add("rec_date");
            
            DataRow row;

    while (((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 1]).Value2 != null)
    {
                row = dt.NewRow();
                string x= ((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex,3]).Value2.ToString();
                double d = double.Parse(x);
                DateTime conv = DateTime.FromOADate(d);
                

                string y = ((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 14]).Value2.ToString();
                double dd = double.Parse(y);
                DateTime conv2 = DateTime.FromOADate(dd);
           //     row = dt.NewRow();

                row[0] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 1]).Value2);
                row[1] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 2]).Value2);
                row[2] = conv;//Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 3]).Value2);
                row[3] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 4]).Value2);
                row[4] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 5]).Value2);
                row[5] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 6]).Value2);

                row[6] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 7]).Value2);
                row[7] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 8]).Value2);
                row[8] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 9]).Value2);
                row[9] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 10]).Value2);
                row[10] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 11]).Value2);
                row[11] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 12]).Value2);
                row[12] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 13]).Value2);
                row[13] = conv2; //Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 14]).Value2);
                index++;

                rowIndex = 2 + index;
                dt.Rows.Add(row);
                     dataGridView1.DataSource = dt;
            }
    app.Workbooks.Close();
   
    return dt;
}




        /*   private void loaddata()
           {

               Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
               Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
               Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
               Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

               int rowCount = xlRange.Rows.Count;
               int colCount = xlRange.Columns.Count;

               // dt.Column = colCount;  
               dataGridView1.ColumnCount = colCount;
               dataGridView1.RowCount = rowCount;


               for (int i = 1; i <= rowCount; i++)
               {
                   for (int j = 1; j <= colCount; j++)
                   {
                       //write the value to the Grid  



                       if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                       {
                           if(j == 12)
                           {
                               try
                               {
                                   string da = xlRange.Cells[i, j].Value2;
                                   DateTime dateTime = DateTime.Parse(da);
                                   MessageBox.Show(dateTime.ToString());
                               }
                               catch(Exception ex)
                               {
                                   MessageBox.Show(ex.Message);
                               }
                           }
                           dataGridView1.Rows[i - 1].Cells[j - 1].Value = xlRange.Cells[i, j].Value2;

                        //   
                       }
                       // Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");  

                       //add useful things here!     
                   }
               }

               //cleanup  
               GC.Collect();
               GC.WaitForPendingFinalizers();

               //rule of thumb for releasing com objects:  
               //  never use two dots, all COM objects must be referenced and released individually  
               //  ex: [somthing].[something].[something] is bad  

               //release com objects to fully kill excel process from running in the background  
               Marshal.ReleaseComObject(xlRange);
               Marshal.ReleaseComObject(xlWorksheet);

               //close and release  
               xlWorkbook.Close();
               Marshal.ReleaseComObject(xlWorkbook);

               //quit and release  
               xlApp.Quit();
               Marshal.ReleaseComObject(xlApp);
           }
           */
        private void upload_btn_Click(object sender, EventArgs e)
        {
            using (var loading_form = new LoadingForm(uplaodalldata))
            {
                loading_form.ShowDialog(this);

            }
        }
        private void uplaodalldata()
        {
            ArrayList sader_arraylist = new ArrayList();

            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    //double d = double.Parse(dataGridView1.Rows[i].Cells["book_date"].Value.ToString());
                    //DateTime conv = DateTime.FromOADate(d);
                    //double dd = double.Parse(dataGridView1.Rows[i].Cells["rec_date"].Value.ToString());
                    //DateTime convv = DateTime.FromOADate(dd);

                 //   MessageBox.Show(dataGridView1.Rows[i].Cells["book_number"].Value.ToString());
                    Sader_Modeller sader_mo = new Sader_Modeller()
                    {

                        book_number_sader = dataGridView1.Rows[i].Cells["book_number"].Value.ToString(),
                        book_date_sader = Convert.ToDateTime(dataGridView1.Rows[i].Cells["book_date"].Value),
                        subject_sader = dataGridView1.Rows[i].Cells["subject"].Value.ToString(),
                        address_sader = dataGridView1.Rows[i].Cells["from_to"].Value.ToString(),
                        notes_sader = dataGridView1.Rows[i].Cells["notes"].Value.ToString(),
                        post_type = dataGridView1.Rows[i].Cells["recieve_type"].Value.ToString(),
                        post_source_sader = dataGridView1.Rows[i].Cells["book_source"].Value.ToString(),
                        class_indecator = dataGridView1.Rows[i].Cells["class_indicator"].Value.ToString(),
                        rec_no = dataGridView1.Rows[i].Cells["rec_no"].Value.ToString(),
                        rec_date = Convert.ToDateTime(dataGridView1.Rows[i].Cells["rec_date"].Value),
                        rec_amount = dataGridView1.Rows[i].Cells["amount"].Value.ToString(),
                        is_active = dataGridView1.Rows[i].Cells["is_ative"].Value.ToString(),
                        user_id = dataGridView1.Rows[i].Cells["user_id"].Value.ToString(),
                    };
                    sader_arraylist.Add(sader_mo);
                    sader_mo.addtodb(sader_arraylist);
                }




                //   MessageBox.Show(dataGridView1.Rows.Cells[1].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_post_button_Click(object sender, EventArgs e)
        {
          
        }

        private void add_post_button_Click_1(object sender, EventArgs e)
        {
            string id = "";
            string pick_password = password.Text;
            login_modeller lg = new login_modeller();
            id = lg.import_export_permsision(pick_password);
            if (id != "")
            {
                panel2.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                panel1.Visible = true;
                upload_btn.Visible = true;
                metroLabel4.Visible = true;

            }
        }
    }
}
