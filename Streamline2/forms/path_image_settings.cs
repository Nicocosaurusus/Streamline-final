using Newtonsoft.Json;
using Streamline2.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Security.Policy;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Web.UI;


namespace Streamline2.forms
{
    public partial class path_image_settings : Form
    {
        //private System.Windows.Forms.PictureBox openerPictureBox; // Add a private field to store the PictureBox control
        private PictureBox openerPictureBox;
        public System.Windows.Forms.PictureBox OpenerPictureBox { get; set; }
        Apps myUserControl = new Apps();


        public path_image_settings()
        {
            InitializeComponent();
            this.openerPictureBox = openerPictureBox;


            System.Drawing.Image originalImage1 = System.Drawing.Image.FromFile("C:\\Users\\nicolas.wolf\\OneDrive - UMB AG\\Pics\\gradient.png");
            int newWidth1 = 399;
            int newHeight1 = 477;
            System.Drawing.Image thumbnailImage1 = originalImage1.GetThumbnailImage(newWidth1, newHeight1, null, IntPtr.Zero);
            pictureBox1.Image = thumbnailImage1;
        }

        private void path_image_settings_Load(object sender, EventArgs e)
        {
            //int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;
            //Console.WriteLine(innerButtonNumber);
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

            int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;


            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data\\ButtonData.json");
            string fullPath = Path.GetFullPath(path);
            string json = File.ReadAllText(fullPath);
            JArray buttonDataArray = JArray.Parse(json);

            JObject buttonDataObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == "outerPictureBox" + innerButtonNumber.ToString()) as JObject;

            if (buttonDataObject != null)
            {
                string tag = buttonDataObject["innerButton"]["Tag"].ToString();
                JObject innerButtonObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == tag) as JObject;
                if (innerButtonObject != null)
                {
                    innerButtonObject["outerPictureBox"]["Path"] = UserInputPath.Text;
                    string output = JsonConvert.SerializeObject(buttonDataArray, Formatting.Indented);
                    File.WriteAllText(fullPath, output);
                }
            }

            Streamline streamlineForm = Application.OpenForms.OfType<Streamline>().FirstOrDefault();
            streamlineForm.LoadAppsControl();


        }

        private void image_upload_Click_1(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog class
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the filter for image files
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            // Set the title of the OpenFileDialog window
            openFileDialog1.Title = "Select Image File";

            int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;
            //Console.WriteLine(innerButtonNumber);

            // Show the OpenFileDialog window and wait for the user to select an image file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the file path of the selected image file
                string filePath = openFileDialog1.FileName;

                string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data\\ButtonData.json");
                string fullPath = Path.GetFullPath(path);
                string json = File.ReadAllText(fullPath);
                JArray buttonDataArray = JArray.Parse(json);

                JObject buttonDataObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == "outerPictureBox" + innerButtonNumber.ToString()) as JObject;

                if (buttonDataObject != null)
                {
                    string tag = buttonDataObject["innerButton"]["Tag"].ToString();
                    JObject innerButtonObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == tag) as JObject;
                    if (innerButtonObject != null)
                    {
                        innerButtonObject["outerPictureBox"]["Image"] = filePath;
                        string output = JsonConvert.SerializeObject(buttonDataArray, Formatting.Indented);
                        File.WriteAllText(fullPath, output);
                    }
                }
            }
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            /*Streamline streamline = new Streamline();
            Apps apps = streamline.Controls.Find("apps", true).FirstOrDefault() as Apps;
            apps.Apps_Loader(sender, e);*/
            this.Close();
        }


        private void guna2TileButton2_Click_1(object sender, EventArgs e)
        {
            int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;

            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data\\ButtonData.json");
            string fullPath = Path.GetFullPath(path);
            string json = File.ReadAllText(fullPath);
            JArray buttonDataArray = JArray.Parse(json);

            JObject buttonDataObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == "outerPictureBox" + innerButtonNumber.ToString()) as JObject;
            if (buttonDataObject != null)
            {
                string tag = buttonDataObject["innerButton"]["Tag"].ToString();
                JObject objectToDelete = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == tag) as JObject;
                if (objectToDelete != null)
                {
                    buttonDataArray.Remove(objectToDelete);
                    string updatedJson = buttonDataArray.ToString();
                    File.WriteAllText(path, updatedJson);
                }
            }
            Streamline streamlineForm = Application.OpenForms.OfType<Streamline>().FirstOrDefault();
            streamlineForm.LoadAppsControl();

            this.Close();
        }

        private void guna2TileButton3_Click_1(object sender, EventArgs e)
        {
            int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;


            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data\\ButtonData.json");
            string fullPath = Path.GetFullPath(path);
            string json = File.ReadAllText(fullPath);
            JArray buttonDataArray = JArray.Parse(json);

            JObject buttonDataObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == "outerPictureBox" + innerButtonNumber.ToString()) as JObject;

            if (buttonDataObject != null)
            {
                string tag = buttonDataObject["innerButton"]["Tag"].ToString();
                JObject innerButtonObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == tag) as JObject;
                if (innerButtonObject != null)
                {
                    innerButtonObject["outerPictureBox"]["Path"] = UserInputPath.Text;
                    string output = JsonConvert.SerializeObject(buttonDataArray, Formatting.Indented);
                    File.WriteAllText(fullPath, output);
                }
            }

            Streamline streamlineForm = Application.OpenForms.OfType<Streamline>().FirstOrDefault();
            streamlineForm.LoadAppsControl();

            this.Close();
        }
    }
}
