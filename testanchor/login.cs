using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testanchor.Modellers;
namespace testanchor
{
    public partial class login : MetroFramework.Forms.MetroForm
    {

        public string login_key = "";
        public static string reponse_key = "";
        public static string api_result = "";
        public static string u = "";
        public static string p = "";

        login_modeller lg = new login_modeller();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void add_post_button_Click(object sender, EventArgs e)
        {
           
        }

        public void login_function()
        {
            
             u = username.Text;
             p = password.Text;

            string indc_check = lg.checkaccount(u, p);
            if(indc_check.Equals("0"))
            {
                this.Hide();
                Auth_form fm = new Auth_form();
                fm.Show();
            }
            else if (indc_check.Equals("1"))
            {
               
                login_key = lg.login(u, p);

                if (login_key == "")
                {
                    using (var loading_form = new LoadingForm(GoToAPI))
                    {
                        loading_form.ShowDialog(this);
                    }

                }
                else
                {
                    Auth_form au = new Auth_form();
                    string mac_address = au.getmymacaddress();
                    string auth_key = "";
                    auth_key = au.DecryAuthKey(login_key);
                    if ((auth_key.Equals(mac_address)))
                    {
                        this.Hide();
                        Form1 fm = new Form1();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم او الرمز السري خطا, يرجى اعادة المحاولة");
                    }
                }
            }
            

        }

        public void GoToAPI()
        {
            string new_key = getitems(u, p);
            if (new_key.Equals("not_authorise"))
            {
                MessageBox.Show("النسخة الحالية غير مفعلة, يرجى الاتصال بمركز ايكو لغرض تفعيل النسخة");
            }
            else if (new_key.Equals("nokey"))
            {
                MessageBox.Show("لايوجد مفتاح");
            }
            else if (new_key.Equals("login_error"))
            {
                MessageBox.Show("اسم المستخدم او الرمز السري خطا");
            }
            else if (new_key.Equals("error_auth"))
            {
                MessageBox.Show("انت غير مخول لاستخدام النظام");
            }
            else if (new_key.Length == 100)
            {
                string update_key = lg.update_license(u, new_key);
                if (update_key.Equals("ok"))
                {
                    MessageBox.Show("مبروك تم تفعيل النسخة الحاليه مدى الحياة");

                }
            }
        }


        private string getitems(string username, string password)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string url = String.Format("https://ecitso.com/ar_license_ath/check_key.php?auth_key=echo2020ar&username=" + username+ "&password="+ password);
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObject.GetResponse();
            string stringResultTest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                stringResultTest = sr.ReadToEnd();
                Console.WriteLine(stringResultTest);
                sr.Close();
            }

            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Comments> objList = (List<Comments>)serializer.Deserialize(stringResultTest, typeof(List<Comments>));
            foreach (Comments obj in objList)
            {
                reponse_key = obj.status;
              //  MessageBox.Show("Response : " + reponse_key);
              
            }
            return reponse_key;
        }

        private void add_post_button_Click_1(object sender, EventArgs e)
        {
            string u = username.Text;
            string p = password.Text;

            login_modeller initail_lg = new login_modeller();
            string log = initail_lg.initail_login(u, p);
            if (log == "")
            {
                MessageBox.Show("اسم المستخدم او الرمز السري خطا");
                
            }
            else
            {

                if (CheckForInternetConnection() == true)
                {
                    //MessageBox.Show("vfvfv");   
                    Search_Modeller sm = new Search_Modeller();
                    long total_in_table = long.Parse(sm.total_all());
                    long total_in_users = long.Parse(sm.get_total_documents());
                    long counting = total_in_users + 250;

                    if (total_in_table > counting)
                    {
                        //     MessageBox.Show("innn");
                        //  MessageBox.Show(u + "  p :" + p + " total :" + total_in_table);
                        string response = check_valdi(u, p, total_in_table);
                        //    MessageBox.Show("response : " + response);
                        if (response.Equals("updated_total"))
                        {
                            //  MessageBox.Show("updated");
                            sm.update_total_documents(total_in_table);
                            login_function();
                        }
                        else if (response.Equals("lisn_finished"))
                        {

                            sm.unactivate();
                            MessageBox.Show(" تم انتهاء تفعيل نسختك الحالية يرجى الاتصال بمركز ايكو");
                        }
                        else if (response.Equals("ok"))
                        {
                            MessageBox.Show("ok");
                            login_function();
                        }
                        else if (response.Equals("error_auth"))
                        {
                            MessageBox.Show("انت لا تستخدم هذه النسخة طبقا للقوانين يرجى حذفها والا سوف تعرض نفسك للمسألة القانونية");

                            sm.unactivate();
                            this.Hide();
                        }
                    }
                    else
                    {
                        login_function();
                    }
                }
                else
                {
                    login_function();
                }
                
            }
        }



        private string check_valdi(string username, string password,long total_doc)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string url = String.Format("https://ecitso.com/ar_license_ath/check_valdi.php?auth_key=echo2020ar&username=" + username + "&password=" + password+ "&total_doc="+ total_doc);
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObject.GetResponse();
            string stringResultTest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                stringResultTest = sr.ReadToEnd();
                Console.WriteLine(stringResultTest);
                sr.Close();
            }

            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Comments> objList = (List<Comments>)serializer.Deserialize(stringResultTest, typeof(List<Comments>));
            foreach (Comments obj in objList)
            {
                reponse_key = obj.status;
                //  MessageBox.Show("Response : " + reponse_key);

            }
            return reponse_key;
        }


        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
