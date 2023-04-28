using Streamline2.UserControls;
using Streamline2.forms;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web.UI.WebControls;
using System.Web.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Newtonsoft.Json;
using System.Xml;
using System.IO;
using static Guna.UI2.Native.WinApi;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;
using Newtonsoft.Json.Linq;


namespace Streamline2.UserControls
{
    public partial class Apps : System.Windows.Forms.UserControl
    {
        public Apps()
        {
            InitializeComponent();
            UpdateImage(); // Call the UpdateImage method to display the image
            this.Load += new EventHandler(Apps_Load);

        }
        private void Apps_Load(object sender, EventArgs e)
        {
            Apps_Loader(sender, e);
        }

        public void Apps_Loader(object sender, EventArgs e)
        {
            // Load button data from JSON file
            var path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data", "ButtonData.json");
            var jsonData = File.Exists(path) ? File.ReadAllText(path) : null;
            var buttonDataList = JsonConvert.DeserializeObject<List<dynamic>>(jsonData) ?? new List<dynamic>();

            // Loop through button data and create corresponding buttons
            foreach (var buttonData in buttonDataList)
            {
                // Create the outer PictureBox
                var outerPictureBox = new PictureBox
                {
                    Name = buttonData.outerPictureBox.name,
                    Location = new Point(100, 100),
                    Width = 100,
                    Height = 100
                };

                var imageRawPath = buttonData.outerPictureBox.Image.ToString().Replace("\\", "\\\\");
                outerPictureBox.Image = File.Exists(imageRawPath)
                    ? System.Drawing.Image.FromFile(imageRawPath).GetThumbnailImage(100, 100, null, IntPtr.Zero)
                    : System.Drawing.Image.FromFile("C:\\Code Projects\\Streamline\\Streamline2\\Streamline2\\2.png")
                        .GetThumbnailImage(100, 100, null, IntPtr.Zero);

                // Create the inner button
                var innerButton = new System.Windows.Forms.Button
                {
                    Name = buttonData.innerButton.name,
                    Width = 30,
                    Height = 30,
                    Parent = outerPictureBox,
                    Location = new Point(63, 4),
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Image = System.Drawing.Image.FromFile("C:\\Code Projects\\Streamline\\Streamline2\\Streamline2\\menustrip.png")
                        .GetThumbnailImage(40, 40, null, IntPtr.Zero)
                };

                // Add event handlers to buttons
                outerPictureBox.Click += outerPictureBox_Click;
                innerButton.Click += innerButton_Click;

                var imagePath = buttonData.imagePath;

                // If the image path is not null or empty, set the image for the outer PictureBox
                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        outerPictureBox.Image = System.Drawing.Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to load image: " + ex.Message);
                    }
                }

                // Add buttons to the flowLayoutPanel
                var index = flowLayoutPanel1.Controls.Count - 1; // get second last index
                flowLayoutPanel1.Controls.Add(outerPictureBox); // add control to the end
                flowLayoutPanel1.Controls.SetChildIndex(outerPictureBox, index); // set control index
            }
        }

        public void UpdateImage()
        {
            //string imagePath = Properties.Settings.Default.ImageFilePath;
            //app1.Image = System.Drawing.Image.FromFile(imagePath);
        }


        private int outerPictureBoxCounter = Properties.Settings.Default.outer_counter;
        private int innerButtonCounter = Properties.Settings.Default.outer_counter;
        private string userInput = "";

        public void button_generator_Click(object sender, EventArgs e)
        {
            // Create the outer PictureBox
            var outerPictureBox = new PictureBox
            {
                Name = $"outerPictureBox{++outerPictureBoxCounter}",
                Location = new Point(100, 100),
                Width = 100,
                Height = 100,
                Tag = userInput
            };
            var originalImage = System.Drawing.Image.FromFile(@"C:\Code Projects\Streamline\Streamline2\Streamline2\2.png");
            var newWidth = 100;
            var newHeight = 100;
            var thumbnailImage = originalImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
            outerPictureBox.Image = thumbnailImage;
            flowLayoutPanel1.Controls.Add(outerPictureBox);

            // Create the inner button
            var innerButton = new System.Windows.Forms.Button
            {
                Name = $"innerButton{++innerButtonCounter}",
                Width = 30,
                Height = 30,
                Parent = outerPictureBox,
                Location = new Point(65, 5),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            var originalImage1 = System.Drawing.Image.FromFile(@"C:\Code Projects\Streamline\Streamline2\Streamline2\menustrip.png");
            var newWidth1 = 40;
            var newHeight1 = 40;
            var thumbnailImage1 = originalImage1.GetThumbnailImage(newWidth1, newHeight1, null, IntPtr.Zero);
            innerButton.Image = thumbnailImage1;
            innerButton.Tag = outerPictureBox.Name;

            var index = flowLayoutPanel1.Controls.IndexOf(outerPictureBox);
            if (index > 0)
            {
                flowLayoutPanel1.Controls.SetChildIndex(outerPictureBox, index - 1);
            }

            outerPictureBox.Click += outerPictureBox_Click;
            innerButton.Click += innerButton_Click;

            // Save the button configuration to the JSON file
            SaveButtonDataToJson(outerPictureBox, innerButton);

            // Save the counter values to the application settings
            Properties.Settings.Default.outer_counter = outerPictureBoxCounter;
            Properties.Settings.Default.inner_counter = innerButtonCounter;
            Properties.Settings.Default.Save();
        }
        private void SaveButtonDataToJson(System.Windows.Forms.PictureBox outerPictureBox, System.Windows.Forms.Button innerButton)
        {
            // Construct the button data object
            string outerPictureBoxName = outerPictureBox.Name;
            string outerPictureBoxPath = outerPictureBox.Tag.ToString();
            string outerPictureBoxImage = outerPictureBox.Image.ToString();

            string innerButtonName = innerButton.Name;
            string innerButtonTag = outerPictureBox.Name;

            var buttonData = new
            {
                outerPictureBox = new
                {
                    name = outerPictureBoxName,
                    Path = outerPictureBoxPath,
                    Image = outerPictureBoxImage
                },
                innerButton = new
                {
                    name = innerButtonName,
                    Tag = innerButtonTag
                }
            };
            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data\\ButtonData.json");
            string fullPath = Path.GetFullPath(path);

            // Read the existing JSON data from the file (if any)
            string jsonData = File.Exists(fullPath) ? File.ReadAllText(fullPath) : null;

            // Deserialize the existing data (or create a new empty list)
            var buttonList = JsonConvert.DeserializeObject<List<dynamic>>(jsonData) ?? new List<dynamic>();

            // Add the new button data to the list
            buttonList.Add(buttonData);

            // Serialize the updated list and write it back to the file
            string updatedJsonData = JsonConvert.SerializeObject(buttonList, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fullPath, updatedJsonData);
        }
        private void outerPictureBox_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox outerPictureBox = (System.Windows.Forms.PictureBox)sender;
            string buttonName1 = outerPictureBox.Name; // get the full name
            //Console.WriteLine(buttonName1);
            int buttonNumbers1 = int.Parse(new string(buttonName1.Where(char.IsDigit).ToArray()));
            //Console.WriteLine(buttonNumbers1);

            string path = Path.Combine(Environment.CurrentDirectory, "..", "..", "App_Data\\ButtonData.json");
            string fullPath = Path.GetFullPath(path);
            string json = File.ReadAllText(fullPath);
            JArray buttonDataArray = JArray.Parse(json);

            JObject buttonDataObject = buttonDataArray.FirstOrDefault(x => x["outerPictureBox"]["name"].ToString() == "outerPictureBox" + buttonNumbers1.ToString()) as JObject;

            try
            {
                string path1 = buttonDataObject["outerPictureBox"]["Path"].ToString();
                Process.Start(path1);
            }
            catch (Exception ex)
            {
                Process.Start("http://gamedev.com/");
            }


        }


        private void innerButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button innerButton = (System.Windows.Forms.Button)sender;
            string buttonName = innerButton.Name; // get the number and name
            int buttonNumbers = int.Parse(buttonName.Substring(11)); // get only the buttonnumber
            Properties.Settings.Default.innerButtonNumber = buttonNumbers;
            Properties.Settings.Default.Save();



            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            int buttonNumber = int.Parse(clickedButton.Name.Substring(11));

            System.Windows.Forms.PictureBox parentPictureBox = clickedButton.Parent as System.Windows.Forms.PictureBox;
            if (parentPictureBox != null)
            {
                var form = new path_image_settings();
                form.OpenerPictureBox = parentPictureBox;
                form.ShowDialog();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generator_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}