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
        private PictureBox openerPictureBox;

        public PictureBox OpenerPictureBox
        {
            get => openerPictureBox;
            set => openerPictureBox = value;
        }

        public path_image_settings()
        {
            InitializeComponent();

            openerPictureBox = new PictureBox();

            Image originalImage = Image.FromFile(@"C:\\Users\nicolas.wolf\\OneDrive - UMB AG\\Pics\\gradient.png");
            int newWidth = 399;
            int newHeight = 477;
            Image thumbnailImage = originalImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
            pictureBox1.Image = thumbnailImage;
        }

        private void path_image_settings_Load(object sender, EventArgs e)
        {
            // int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;
            // Console.WriteLine(innerButtonNumber);
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;
            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data", "ButtonData.json");
            string json = File.ReadAllText(path);
            JArray buttonDataArray = JArray.Parse(json);
            JObject buttonDataObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == $"outerPictureBox{innerButtonNumber}") as JObject;

            if (buttonDataObject != null)
            {
                string tag = buttonDataObject["innerButton"]["Tag"].ToString();
                JObject innerButtonObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == tag) as JObject;

                if (innerButtonObject != null)
                {
                    innerButtonObject["outerPictureBox"]["Path"] = UserInputPath.Text;
                    File.WriteAllText(path, JsonConvert.SerializeObject(buttonDataArray, Formatting.Indented));
                }
            }

            Streamline streamlineForm = Application.OpenForms.OfType<Streamline>().FirstOrDefault();
            streamlineForm?.LoadAppsControl();
        }

        private void image_upload_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG",
                Title = "Select Image File"
            };

            var innerButtonNumber = Properties.Settings.Default.innerButtonNumber;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;

                var path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data", "ButtonData.json");
                var buttonDataArray = JArray.Parse(File.ReadAllText(path));

                var buttonDataObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == $"outerPictureBox{innerButtonNumber}") as JObject;

                if (buttonDataObject != null)
                {
                    var tag = buttonDataObject["innerButton"]["Tag"].ToString();
                    var innerButtonObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == tag) as JObject;
                    if (innerButtonObject != null)
                    {
                        innerButtonObject["outerPictureBox"]["Image"] = filePath;
                        File.WriteAllText(path, JsonConvert.SerializeObject(buttonDataArray, Formatting.Indented));
                    }
                }
            }
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TileButton2_Click_1(object sender, EventArgs e)
        {
            int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;

            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data\\ButtonData.json");
            JArray buttonDataArray = JArray.Parse(File.ReadAllText(path));

            var buttonDataObject = buttonDataArray
                .FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == "outerPictureBox" + innerButtonNumber.ToString()) as JObject;

            if (buttonDataObject != null)
            {
                string tag = buttonDataObject["innerButton"]["Tag"].ToString();
                buttonDataArray.Remove(buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == tag));
                File.WriteAllText(path, buttonDataArray.ToString());
            }

            var streamlineForm = Application.OpenForms.OfType<Streamline>().FirstOrDefault();
            streamlineForm.LoadAppsControl();
            Close();
        }


        private void guna2TileButton3_Click_1(object sender, EventArgs e)
        {
            // Get the inner button number from the application settings
            int innerButtonNumber = Properties.Settings.Default.innerButtonNumber;

            // Load the button data from the JSON file
            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data", "ButtonData.json");
            JArray buttonDataArray = JArray.Parse(File.ReadAllText(path));

            // Find the button data object for the currently selected outer button
            JObject outerButtonDataObject = buttonDataArray
                .FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == $"outerPictureBox{innerButtonNumber}") as JObject;

            if (outerButtonDataObject != null)
            {
                // Get the tag of the inner button associated with the outer button
                string innerButtonTag = outerButtonDataObject["innerButton"]["Tag"].ToString();

                // Find the button data object for the inner button
                JObject innerButtonDataObject = buttonDataArray
                    .FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == innerButtonTag) as JObject;

                if (innerButtonDataObject != null)
                {
                    // Update the path of the inner button with the user input path
                    innerButtonDataObject["outerPictureBox"]["Path"] = UserInputPath.Text;

                    // Save the updated button data to the JSON file
                    string output = JsonConvert.SerializeObject(buttonDataArray, Formatting.Indented);
                    File.WriteAllText(path, output);
                }
            }

            // Refresh the apps control on the streamline form
            Streamline streamlineForm = Application.OpenForms.OfType<Streamline>().FirstOrDefault();
            streamlineForm?.LoadAppsControl();

            // Close the form
            this.Close();
        }
    }
}
