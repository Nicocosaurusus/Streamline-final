namespace Streamline2.UserControls
{
    partial class Apps
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.generator = new System.Windows.Forms.Panel();
            this.button_generator = new System.Windows.Forms.Button();
            this.path_input_main = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.generator.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.generator);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1582, 673);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // generator
            // 
            this.generator.Controls.Add(this.button_generator);
            this.generator.Location = new System.Drawing.Point(3, 3);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(100, 100);
            this.generator.TabIndex = 6;
            // 
            // button_generator
            // 
            this.button_generator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_generator.ForeColor = System.Drawing.Color.Gray;
            this.button_generator.Location = new System.Drawing.Point(32, 32);
            this.button_generator.Name = "button_generator";
            this.button_generator.Size = new System.Drawing.Size(35, 35);
            this.button_generator.TabIndex = 0;
            this.button_generator.Text = "+";
            this.button_generator.UseVisualStyleBackColor = false;
            this.button_generator.Click += new System.EventHandler(this.button_generator_Click);
            // 
            // path_input_main
            // 
            this.path_input_main.Location = new System.Drawing.Point(0, 0);
            this.path_input_main.Name = "path_input_main";
            this.path_input_main.Size = new System.Drawing.Size(200, 100);
            this.path_input_main.TabIndex = 6;
            // 
            // Apps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.path_input_main);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Apps";
            this.Size = new System.Drawing.Size(1582, 673);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.generator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel path_input_main;
        private System.Windows.Forms.Panel generator;
        private System.Windows.Forms.Button button_generator;
    }
}
