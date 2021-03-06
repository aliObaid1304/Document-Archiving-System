using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections;
using WIA;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using testanchor.Modellers;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace testanchor
{
    public partial class sader : MetroFramework.Forms.MetroForm
    {


        public static string Path;
        public string book_number_sader;
        public DateTime book_date_sader;
        public string address_sader;
        public string subject_sader;
        public string notes_sader;
        public static int class_indecator = 0;
        public static int post_type_sader = 0;
        public static string post_source_sader = null;
        public static int re_id = 0;
        public static string re_name;
        public static int counter = 1;
        public static int las = 0;


        public static string rec_no = null;
        public static DateTime rec_date;
        public static string rec_amount = null;

        Sader_Modeller ss = new Sader_Modeller();
        ArrayList sader_arraylist = new ArrayList();
        ArrayList sader_arraylist_2 = new ArrayList();
        ArrayList listOfSystemDrawingImage = new ArrayList();
        ArrayList arraylistOfSelectedFile = new ArrayList();


        Stopwatch sw = new Stopwatch();
        int cmbCMIndex = 0;


        public sader()
        {
            InitializeComponent();
            Sader_Modeller rr = new Sader_Modeller();
            sader_arraylist_2 = rr.list_all();
            metroComboBox1.DisplayMember = "Text";
            metroComboBox1.ValueMember = "Value";


            //    MessageBox.Show(sader_arraylist_2.ToString());
            for (int i = 0; i < sader_arraylist_2.Count; i++)
            {
                //    MessageBox.Show(((RecievingType_Modeller)sader_arraylist_2[i]).re_name);
                //  metroComboBox1.Items.Add(((RecievingType_Modeller)sader_arraylist_2[i]).re_name);
                metroComboBox1.Items.Add(new { Text = ((RecievingType_Modeller)sader_arraylist_2[i]).re_name, Value = ((RecievingType_Modeller)sader_arraylist_2[i]).re_id });
            }
        }

        private void sader_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile(@"C:\Cairo-Bold.ttf");
            //foreach (Control c in this.Controls)
            //{
            //    c.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            //    metroLabel1.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            //}


            try
            {

                var deviceManager = new DeviceManager();
                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    listBox1.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show("! لا يوجد جهاز متصل ");
            }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (validation() == true && listOfSystemDrawingImage.Count != 0)
            {
                add_records_todb(listOfSystemDrawingImage);
            }
            else if (validation() == true && arraylistOfSelectedFile.Count != 0)
            {
                add_records_todb(arraylistOfSelectedFile);
            }

            else
            {
                MessageBox.Show("يجب ملئ الحقول المطلوبة و اجراء مسح ضوئي لملف واحد على الاقل");
            }

        }

        public bool validation()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            bool val = true;
            if (book_number.Text == "")
            {
                label1.Visible = true;
                val = false;
            }
            if (book_date.Value == null)
            {
                label2.Visible = true;
                val = false;
            }
            if (subject.Text == "")
            {
                label4.Visible = true;
                val = false;
            }
            if (from_to.Text == "")
            {
                label3.Visible = true;
                val = false;
            }


            if (metroComboBox1.SelectedIndex ==-1)
            {
                label5.Visible = true;
                val = false;
            }

            return val;


        }


        public void add_records_todb(ArrayList array_list_of_files)
        {
            sader_arraylist.Clear();
            Sader_Modeller rr = new Sader_Modeller();
            string last_record = rr.get_last_book_no();
            las = int.Parse(last_record);

            int last_id = las + 1;
            //   MessageBox.Show("new : " +las.ToString());

            Sader_Modeller sader_mo = new Sader_Modeller()
            {
                book_number_sader = book_number.Text,
                book_date_sader = book_date.Value,
                subject_sader = subject.Text,
                address_sader = from_to.Text,
                notes_sader = notes.Text,
                post_type = (metroComboBox1.SelectedItem as dynamic).Value.ToString(),
                post_source_sader = "E:\\archieve\\sader\\" + last_id + ".pdf",
                class_indecator = "1",
                rec_no = "",
                rec_date = book_date.Value,
                rec_amount = "",
            };

            sader_arraylist.Add(sader_mo);

            if (sader_mo.addtodb(sader_arraylist) == true)
            {



                string fileExt =System.IO.Path.GetExtension(array_list_of_files[0].ToString());
                if (fileExt == ".png" || fileExt == ".jpg")
                {
                    //   MessageBox.Show(sader_mo.address_sader);
                    PdfDocument document = new PdfDocument();
                    document.Info.Title = "Created By Echo IT-Solutions";
                    foreach (string fileSpec in array_list_of_files)
                    {
                        PdfPage page = document.AddPage();
                        XGraphics dfx = XGraphics.FromPdfPage(page);
                        DrawImage(dfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);
                    }
                    if (document.PageCount > 0)

                    {
                        document.Save("E:\\archieve\\sader\\" + last_id + ".pdf");
                        pictureBox1.Image = null;
                        pictureBox2.Image = null;
                        pictureBox3.Image = null;
                        pictureBox4.Image = null;
                        array_list_of_files.Clear();
                        MessageBox.Show("تمت اضافة الكتاب بنجاح");
                        book_date.Text = "";
                        from_to.Text = "";
                        subject.Text = "";
                        notes.Text = "";

                    }
                }
                else if (fileExt == ".pdf")
                {
                    
                    Console.WriteLine(array_list_of_files[0].ToString());
                    try {
                    
                        PdfDocument pdf = PdfReader.Open(array_list_of_files[0].ToString());
                        Console.WriteLine(pdf);
                        string pdfFilename = "E:\\archieve\\sader\\" + last_id + ".pdf";
                        pdf.Save(pdfFilename);       
                        pictureBox1.Image = null;
                        pictureBox2.Image = null;
                        pictureBox3.Image = null;
                        pictureBox4.Image = null;
                        array_list_of_files.Clear();
                        MessageBox.Show("تمت اضافة الكتاب بنجاح");
                        book_date.Text = "";
                        from_to.Text = "";
                        subject.Text = "";
                        notes.Text = "";

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("الملف غير صالح");
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("حدث خطأ يرجى اعادة المحاولة");
            }
        }



        private void bgwScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            {
                if (e.Cancelled) MessageBox.Show("Operation was canceled");
                else if (e.Error != null) MessageBox.Show(e.Error.Message);  
            }
        }

        private void bgwScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            sw.Start();
        }

        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel,
                          int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);



        }



        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private static void SaveImageToTiff(ImageFile image, string fileName)
        {
            
            ImageProcess imgProcess = new ImageProcess();
            object convertFilter = "Convert";
            string convertFilterID = imgProcess.FilterInfos.get_Item(ref convertFilter).FilterID;
            imgProcess.Filters.Add(convertFilterID, 0);
            SetWIAProperty(imgProcess.Filters[imgProcess.Filters.Count].Properties, "FormatID", WIA.FormatID.wiaFormatTIFF);
            image = imgProcess.Apply(image);
            image.SaveFile(fileName);
            MessageBox.Show("تمت عملية المسح الضوئي بنجاح");
        }




        private void scan_button_Click(object sender, EventArgs e)
        {
            if (arraylistOfSelectedFile.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("اذا تم استخدام عملية المسح الضوئي سيتم الغاء عملية اختيار الفايلات", "!!! انتباه", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    pictureBox1.Image = null;
                    pictureBox3.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;
                    arraylistOfSelectedFile.Clear();
                    try
                    {
                        CommonDialogClass commonDialogClass = new CommonDialogClass();
                        Device scannerDevice = commonDialogClass.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, false, false);
                        if (scannerDevice != null)
                        {
                            Item scannnerItem = scannerDevice.Items[1];
                            AdjustScannerSettings(scannnerItem, 150, 0, 0, 1250, 1700, 0, 0, cmbCMIndex);

                            object scanResult = commonDialogClass.ShowTransfer(scannnerItem, WIA.FormatID.wiaFormatTIFF, false);
                          
                            if (scanResult != null)
                            {
                                ImageFile image = (ImageFile)scanResult;
                                string fileName = "";
                                
                                try
                                {
                                    Path = @"E:\archieve\sader\temp\" + counter + ".jpg";
                                 
                                }
                                catch (Exception ex)
                                {
                                     Path = @"E:\archieve\sader\temp\" + counter + ".jpg";
                                }
                              

                                if (File.Exists(Path))
                                {
                                    File.Delete(Path);
                                }
                                SaveImageToTiff(image, Path);
                                listOfSystemDrawingImage.Add(Path);

                                if (pictureBox1.Image == null)
                                {
                                    pictureBox1.ImageLocation = Path;
                                }
                                else if (pictureBox2.Image == null)
                                {
                                    pictureBox2.ImageLocation = Path;
                                }

                                else if (pictureBox3.Image == null)
                                {
                                    pictureBox3.ImageLocation = Path;
                                }

                                else if (pictureBox4.Image == null)
                                {
                                    pictureBox4.ImageLocation = Path;
                                }
                                counter = counter + 1;
                            }
                        }
                      
                        }
                        catch (COMException ex)
                        {
                            // Display the exception in the console.
                            Console.WriteLine(ex.ToString());

                            uint errorCode = (uint)ex.ErrorCode;

                            // Catch 2 of the most common exceptions
                            if (errorCode == 0x80210006)
                            {
                                MessageBox.Show("! جهاز الماسح الضوئي قد يكون مشغول حاليا او غير متصل بالكومبيوتر");
                            }
                            else if (errorCode == 0x80210064)
                            {
                                MessageBox.Show("! تم الغاء عملية المسح الضوئي ");
                            }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("قد يكون الجهاز غير متصل بالكومبيوتر اوغير متصل بالكهرباء");
                        //   MessageBox.Show(ex.Message);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }

            else
            {
                try
                {

                    CommonDialogClass commonDialogClass = new CommonDialogClass();
                    Device scannerDevice = commonDialogClass.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, false, false);
                    if (scannerDevice != null)
                    {
                        Item scannnerItem = scannerDevice.Items[1];
                        AdjustScannerSettings(scannnerItem, 150, 0, 0, 1250, 1700, 0, 0, cmbCMIndex);

                        object scanResult = commonDialogClass.ShowTransfer(scannnerItem, WIA.FormatID.wiaFormatTIFF, false);                   
                        if (scanResult != null)
                        {
                            ImageFile image = (ImageFile)scanResult;
                            string fileName = "";

                            try
                            {
                                
                                Path = @"E:\archieve\sader\temp\" + counter + ".jpg";
                                if (File.Exists(Path))
                                {
                                    File.Delete(Path);
                                }
                                SaveImageToTiff(image, Path);
                                listOfSystemDrawingImage.Add(Path);

                                if (pictureBox1.Image == null)
                                {
                                    pictureBox1.ImageLocation = Path;
                                }
                                else if (pictureBox2.Image == null)
                                {
                                    pictureBox2.ImageLocation = Path;
                                }

                                else if (pictureBox3.Image == null)
                                {
                                    pictureBox3.ImageLocation = Path;
                                }

                                else if (pictureBox4.Image == null)
                                {
                                    pictureBox4.ImageLocation = Path;
                                }
                                counter = counter + 1;

                            }
                            catch (COMException ex)
                            {
                                // Display the exception in the console.
                                Console.WriteLine(ex.ToString());

                                uint errorCode = (uint)ex.ErrorCode;

                                // Catch 2 of the most common exceptions
                                if (errorCode == 0x80210006)
                                {
                                    MessageBox.Show("! جهاز الماسح الضوئي قد يكون مشغول حاليا او غير متصل بالكومبيوتر");
                                }
                                else if (errorCode == 0x80210064)
                                {
                                    MessageBox.Show("! تم الغاء عملية المسح الضوئي ");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("قد يكون الجهاز غير متصل بالكومبيوتر اوغير متصل بالكهرباء");
                    //   MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   MessageBox.Show((metroComboBox1.SelectedItem as dynamic).Value.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listOfSystemDrawingImage.Count >= 1)
            {
                if (listOfSystemDrawingImage[0].ToString() != null)
                {
                    string Path = listOfSystemDrawingImage[0].ToString();
                    Image_View im = new Image_View();
                    im.load_image(Path);
                    im.Show();
                }
            }
            else if (arraylistOfSelectedFile.Count >= 1)
            {
                if (arraylistOfSelectedFile[0].ToString() != null)
                {
                    string Path = arraylistOfSelectedFile[0].ToString();
                    Image_View im = new Image_View();
                    im.load_image(Path);
                    im.Show();
                }
            }


        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listOfSystemDrawingImage.Count >= 2)
            {
                if (listOfSystemDrawingImage[1].ToString() != null)
                {
                    string Path = listOfSystemDrawingImage[1].ToString();
                    Image_View im = new Image_View();
                    im.load_image(Path);
                    im.Show();
                }
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (listOfSystemDrawingImage.Count >= 3)
            {
                if (listOfSystemDrawingImage[2].ToString() != null)
                {
                    string Path = listOfSystemDrawingImage[2].ToString();
                    Image_View im = new Image_View();
                    im.load_image(Path);
                    im.Show();
                }
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (listOfSystemDrawingImage.Count >= 4)
            {
                if (listOfSystemDrawingImage[3].ToString() != null)
                {
                    string Path = listOfSystemDrawingImage[3].ToString();
                    Image_View im = new Image_View();
                    im.load_image(Path);
                    im.Show();
                }
            }
        }


        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parent = ((Control)sender).Parent.Parent;
            parent.Visible = false;
            parent.Dispose();
            parent = null;
        }

        private void book_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void select_button_Click(object sender, EventArgs e)
        {

            if (listOfSystemDrawingImage.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("اذا تم اختيار الملفات عن طريقك سيتم الغاء ملفات الماسح الضوئي", "!!! انتباه", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    listOfSystemDrawingImage.Clear();
                    OpenFileDialog openFileDialog1 = new OpenFileDialog
                    {
                        Title = "اختر الملف",
                        CheckFileExists = true,
                        CheckPathExists = true,
                        Filter = "image files|*.jpg;*.png;*.pdf",
                        FilterIndex = 2,
                        RestoreDirectory = true,
                        ReadOnlyChecked = true,
                        ShowReadOnly = true
                    };
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        arraylistOfSelectedFile.Clear();
                        pictureBox1.Image = null;
                        pictureBox2.Image = null;
                        pictureBox3.Image = null;
                        pictureBox4.Image = null;

                        arraylistOfSelectedFile.Add(openFileDialog1.FileName);
                     //   MessageBox.Show(openFileDialog1.FileName);
                        pictureBox1.ImageLocation = openFileDialog1.FileName;
                    }
                    //   MessageBox.Show(openFileDialog1.FileName);
                }
                else if (dialogResult == DialogResult.No)
                {
                    arraylistOfSelectedFile.Clear();
                }

            }
            else
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "اختر الملف",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "image files|*.jpg;*.png;*.pdf",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    arraylistOfSelectedFile.Clear();
                    arraylistOfSelectedFile.Add(openFileDialog1.FileName);
                  //  MessageBox.Show(openFileDialog1.FileName);
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                }
                //listOfSystemDrawingImage.Clear();
                //arraylistOfSelectedFile.Add(openFileDialog1.FileName);
                //pictureBox1.ImageLocation = openFileDialog1.FileName;
            }

        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }


    }
}
