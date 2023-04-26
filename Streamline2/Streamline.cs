using Streamline2.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Streamline2
{
    public partial class Streamline : Form
    {

        public Streamline()
        {
            InitializeComponent();
            Dashboard uc = new Dashboard();
            addUserControl(uc);
            this.Load += new EventHandler(Streamline_Load);
        }
        private void Streamline_Load(object sender, EventArgs e)
        {
            //internetsite.Image = System.Drawing.Image.FromFile(@"C:\Users\Administrator\Pictures\forestfloor.jpg");

            internetsite.Image = System.Drawing.Image.FromFile("C:\\Code Projects\\Streamline\\Streamline2\\Streamline2\\2.png");
            // Load the image from a file
            /*Bitmap image = new Bitmap("C:\\Code Projects\\Streamline\\Streamline2\\Streamline2\\1.png");
            main.BackgroundImage = image;
            main.BackgroundImageLayout = ImageLayout.Zoom;
            main.Size = new Size(image.Width, image.Height);*/

        }




        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            main.Controls.Clear();
            main.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void top_panel_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void internetsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gamedev.com/");
        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com");
        }

        private void Message_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void Call_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void Facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard uc = new Dashboard();
            addUserControl(uc);
        }

        private void Monitor_Click(object sender, EventArgs e)
        {
            Monitor uc = new Monitor();
            addUserControl(uc);
        }
        public void Apps_Click(object sender, EventArgs e)
        {
            Apps uc = new Apps();
            addUserControl(uc);
        }
        public void LoadAppsControl() // used for reloading in image_path_settings
        {
            Apps uc = new Apps();
            addUserControl(uc);
        }


        private void main_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
