using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testanchor
{
    public partial class Image_View : MetroFramework.Forms.MetroForm
    {
        public Image_View()
        {
            InitializeComponent();
        }

        private void Image_View_Load(object sender, EventArgs e)
        {
            
        }

        public void load_image(string Path)
        {
            pictureBox1.ImageLocation = Path;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
