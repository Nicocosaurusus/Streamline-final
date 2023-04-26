namespace Streamline2.forms
{
    partial class path_image_settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.top_panel = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.image_description = new System.Windows.Forms.Label();
            this.path_description = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.commit_button_Click = new Guna.UI2.WinForms.Guna2TileButton();
            this.image_upload = new Guna.UI2.WinForms.Guna2TileButton();
            this.UserInputPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.top_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.top_panel.Controls.Add(this.guna2ControlBox1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(420, 40);
            this.top_panel.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(380, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // image_description
            // 
            this.image_description.AutoSize = true;
            this.image_description.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.image_description.ForeColor = System.Drawing.Color.White;
            this.image_description.Location = new System.Drawing.Point(26, 20);
            this.image_description.Name = "image_description";
            this.image_description.Size = new System.Drawing.Size(277, 33);
            this.image_description.TabIndex = 6;
            this.image_description.Text = "search for an image";
            // 
            // path_description
            // 
            this.path_description.AutoSize = true;
            this.path_description.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.path_description.ForeColor = System.Drawing.Color.White;
            this.path_description.Location = new System.Drawing.Point(23, 24);
            this.path_description.Name = "path_description";
            this.path_description.Size = new System.Drawing.Size(345, 33);
            this.path_description.TabIndex = 4;
            this.path_description.Text = "input the path to your file";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.top_panel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // commit_button_Click
            // 
            this.commit_button_Click.BackColor = System.Drawing.Color.Black;
            this.commit_button_Click.BorderRadius = 10;
            this.commit_button_Click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.commit_button_Click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.commit_button_Click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.commit_button_Click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.commit_button_Click.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.commit_button_Click.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commit_button_Click.ForeColor = System.Drawing.Color.White;
            this.commit_button_Click.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.commit_button_Click.Location = new System.Drawing.Point(228, 128);
            this.commit_button_Click.Name = "commit_button_Click";
            this.commit_button_Click.Size = new System.Drawing.Size(140, 43);
            this.commit_button_Click.TabIndex = 9;
            this.commit_button_Click.Text = "commit";
            this.commit_button_Click.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // image_upload
            // 
            this.image_upload.BorderRadius = 20;
            this.image_upload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.image_upload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.image_upload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.image_upload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.image_upload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.image_upload.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.image_upload.ForeColor = System.Drawing.Color.White;
            this.image_upload.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.image_upload.Location = new System.Drawing.Point(59, 76);
            this.image_upload.Name = "image_upload";
            this.image_upload.Size = new System.Drawing.Size(100, 100);
            this.image_upload.TabIndex = 10;
            this.image_upload.Text = "+";
            this.image_upload.TextOffset = new System.Drawing.Point(4, -8);
            this.image_upload.Click += new System.EventHandler(this.image_upload_Click_1);
            // 
            // UserInputPath
            // 
            this.UserInputPath.BorderColor = System.Drawing.Color.Transparent;
            this.UserInputPath.BorderRadius = 10;
            this.UserInputPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserInputPath.DefaultText = "";
            this.UserInputPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserInputPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserInputPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserInputPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserInputPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserInputPath.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.UserInputPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserInputPath.Location = new System.Drawing.Point(29, 74);
            this.UserInputPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserInputPath.Name = "UserInputPath";
            this.UserInputPath.PasswordChar = '\0';
            this.UserInputPath.PlaceholderText = "";
            this.UserInputPath.SelectedText = "";
            this.UserInputPath.Size = new System.Drawing.Size(339, 43);
            this.UserInputPath.TabIndex = 11;
            this.UserInputPath.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.guna2TileButton2);
            this.panel1.Controls.Add(this.guna2TileButton3);
            this.panel1.Controls.Add(this.image_upload);
            this.panel1.Controls.Add(this.image_description);
            this.panel1.Location = new System.Drawing.Point(13, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 208);
            this.panel1.TabIndex = 13;
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.BorderRadius = 10;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(20)))));
            this.guna2TileButton2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2TileButton2.Location = new System.Drawing.Point(32, 171);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(140, 43);
            this.guna2TileButton2.TabIndex = 15;
            this.guna2TileButton2.Text = "Delete";
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click_1);
            // 
            // guna2TileButton3
            // 
            this.guna2TileButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton3.BorderRadius = 10;
            this.guna2TileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(170)))), ((int)(((byte)(31)))));
            this.guna2TileButton3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.guna2TileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.guna2TileButton3.Location = new System.Drawing.Point(218, 162);
            this.guna2TileButton3.Name = "guna2TileButton3";
            this.guna2TileButton3.Size = new System.Drawing.Size(140, 43);
            this.guna2TileButton3.TabIndex = 14;
            this.guna2TileButton3.Text = "SAVE";
            this.guna2TileButton3.Click += new System.EventHandler(this.guna2TileButton3_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.UserInputPath);
            this.panel2.Controls.Add(this.path_description);
            this.panel2.Controls.Add(this.commit_button_Click);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 189);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // path_image_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(420, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "path_image_settings";
            this.Text = "path_image_settings";
            this.Load += new System.EventHandler(this.path_image_settings_Load);
            this.top_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label image_description;
        private System.Windows.Forms.Label path_description;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TileButton commit_button_Click;
        private Guna.UI2.WinForms.Guna2TileButton image_upload;
        private Guna.UI2.WinForms.Guna2TextBox UserInputPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}