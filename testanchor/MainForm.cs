using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testanchor.Modellers;

namespace testanchor
{
    public partial class MainForm :MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Search_Modeller smm = new Search_Modeller();
            total_sader.Text = smm.total_sader();
            total_warid.Text = smm.total_warid();
            total_mut.Text = smm.total_mutf();
            total.Text = smm.total_all();
            total_deleted.Text = smm.total_deleted();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parent = ((Control)sender).Parent.Parent;
            parent.Visible = false;
            parent.Dispose();
            parent = null;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            About_Form ab = new About_Form();
            ab.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
