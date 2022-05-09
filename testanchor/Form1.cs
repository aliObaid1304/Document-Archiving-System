using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testanchor
{
    public partial class Form1:MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string title = "حسابات" + (metroTabControl1.TabCount + 1).ToString();
            string title = "   الرئيسية  ";
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            TabPage myTabPage = new TabPage(title);

            metroTabControl1.TabPages.Add(myTabPage);

            MainForm inventoryForm = new MainForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myTabPage.Controls.Add(inventoryForm);
            try
            {
                inventoryForm.Show();
                metroTabControl1.SelectedTab = myTabPage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sending_SideBar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            //string title = "حسابات" + (metroTabControl1.TabCount + 1).ToString();
            string title = "   الصادر  ";

            TabPage myTabPage = new TabPage(title);

            metroTabControl1.TabPages.Add(myTabPage);

            sader inventoryForm = new sader() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myTabPage.Controls.Add(inventoryForm);
            try
            {
                inventoryForm.Show();
                metroTabControl1.SelectedTab = myTabPage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reports_Click(object sender, EventArgs e)
        {
            //string title = "حسابات" + (metroTabControl1.TabCount + 1).ToString();
            string title = "   بحث  ";
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
            TabPage myTabPage = new TabPage(title);

            metroTabControl1.TabPages.Add(myTabPage);

            Search_Form inventoryForm = new Search_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myTabPage.Controls.Add(inventoryForm);
            try
            {
                inventoryForm.Show();
                metroTabControl1.SelectedTab = myTabPage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mutafarqa_Click(object sender, EventArgs e)
        {
            //string title = "حسابات" + (metroTabControl1.TabCount + 1).ToString();
            string title = "   المتفرقة  ";
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            TabPage myTabPage = new TabPage(title);

            metroTabControl1.TabPages.Add(myTabPage);

            mutafareqa inventoryForm = new mutafareqa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myTabPage.Controls.Add(inventoryForm);
            try
            {
                inventoryForm.Show();
                metroTabControl1.SelectedTab = myTabPage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Recieving_SideBar_Click(object sender, EventArgs e)
        {
            //string title = "حسابات" + (metroTabControl1.TabCount + 1).ToString();
            string title = "   الوارد  ";
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            TabPage myTabPage = new TabPage(title);

            metroTabControl1.TabPages.Add(myTabPage);

            warid inventoryForm = new warid() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myTabPage.Controls.Add(inventoryForm);
            try
            {
                inventoryForm.Show();
                metroTabControl1.SelectedTab = myTabPage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string title = "حسابات" + (metroTabControl1.TabCount + 1).ToString();
            string title = "   الرئيسية  ";
            panel7.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            TabPage myTabPage = new TabPage(title);

            metroTabControl1.TabPages.Add(myTabPage);

            MainForm inventoryForm = new MainForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myTabPage.Controls.Add(inventoryForm);
            try
            {
                inventoryForm.Show();
                metroTabControl1.SelectedTab = myTabPage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login ll = new login();
            ll.Show();
            //login ll = new login();
            //ll.Close();
            //ll.Dispose();
            //this.Close();
            //this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //string title = "حسابات" + (metroTabControl1.TabCount + 1).ToString();
            string title = " Back-Up ";
            panel7.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            TabPage myTabPage = new TabPage(title);

            metroTabControl1.TabPages.Add(myTabPage);

            Setting_Form inventoryForm = new Setting_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myTabPage.Controls.Add(inventoryForm);
            try
            {
                inventoryForm.Show();
                metroTabControl1.SelectedTab = myTabPage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
