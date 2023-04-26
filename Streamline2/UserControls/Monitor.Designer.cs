namespace Streamline2.UserControls
{
    partial class Monitor
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
            this.components = new System.ComponentModel.Container();
            this.cputemp = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gpuname_label = new System.Windows.Forms.Label();
            this.gputemp_label = new System.Windows.Forms.Label();
            this.gpuusage_label = new System.Windows.Forms.Label();
            this.ramusage_label = new System.Windows.Forms.Label();
            this.cpuname_label = new System.Windows.Forms.Label();
            this.cputemp_label = new System.Windows.Forms.Label();
            this.cpuusage_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cputemp
            // 
            this.cputemp.AutoSize = true;
            this.cputemp.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.cputemp.ForeColor = System.Drawing.Color.White;
            this.cputemp.Location = new System.Drawing.Point(253, 130);
            this.cputemp.Name = "cputemp";
            this.cputemp.Size = new System.Drawing.Size(177, 96);
            this.cputemp.TabIndex = 1;
            this.cputemp.Text = "test";
            this.cputemp.Click += new System.EventHandler(this.cputemp_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // gpuname_label
            // 
            this.gpuname_label.AutoSize = true;
            this.gpuname_label.ForeColor = System.Drawing.Color.White;
            this.gpuname_label.Location = new System.Drawing.Point(299, 273);
            this.gpuname_label.Name = "gpuname_label";
            this.gpuname_label.Size = new System.Drawing.Size(72, 23);
            this.gpuname_label.TabIndex = 2;
            this.gpuname_label.Text = "label1";
            // 
            // gputemp_label
            // 
            this.gputemp_label.AutoSize = true;
            this.gputemp_label.ForeColor = System.Drawing.Color.White;
            this.gputemp_label.Location = new System.Drawing.Point(299, 321);
            this.gputemp_label.Name = "gputemp_label";
            this.gputemp_label.Size = new System.Drawing.Size(72, 23);
            this.gputemp_label.TabIndex = 3;
            this.gputemp_label.Text = "label2";
            // 
            // gpuusage_label
            // 
            this.gpuusage_label.AutoSize = true;
            this.gpuusage_label.ForeColor = System.Drawing.Color.White;
            this.gpuusage_label.Location = new System.Drawing.Point(299, 360);
            this.gpuusage_label.Name = "gpuusage_label";
            this.gpuusage_label.Size = new System.Drawing.Size(72, 23);
            this.gpuusage_label.TabIndex = 4;
            this.gpuusage_label.Text = "label2";
            // 
            // ramusage_label
            // 
            this.ramusage_label.AutoSize = true;
            this.ramusage_label.ForeColor = System.Drawing.Color.White;
            this.ramusage_label.Location = new System.Drawing.Point(299, 399);
            this.ramusage_label.Name = "ramusage_label";
            this.ramusage_label.Size = new System.Drawing.Size(72, 23);
            this.ramusage_label.TabIndex = 5;
            this.ramusage_label.Text = "label2";
            // 
            // cpuname_label
            // 
            this.cpuname_label.AutoSize = true;
            this.cpuname_label.ForeColor = System.Drawing.Color.White;
            this.cpuname_label.Location = new System.Drawing.Point(584, 255);
            this.cpuname_label.Name = "cpuname_label";
            this.cpuname_label.Size = new System.Drawing.Size(72, 23);
            this.cpuname_label.TabIndex = 6;
            this.cpuname_label.Text = "label1";
            // 
            // cputemp_label
            // 
            this.cputemp_label.AutoSize = true;
            this.cputemp_label.ForeColor = System.Drawing.Color.White;
            this.cputemp_label.Location = new System.Drawing.Point(584, 297);
            this.cputemp_label.Name = "cputemp_label";
            this.cputemp_label.Size = new System.Drawing.Size(163, 23);
            this.cputemp_label.TabIndex = 7;
            this.cputemp_label.Text = "cputemp_label";
            // 
            // cpuusage_label
            // 
            this.cpuusage_label.AutoSize = true;
            this.cpuusage_label.ForeColor = System.Drawing.Color.White;
            this.cpuusage_label.Location = new System.Drawing.Point(584, 336);
            this.cpuusage_label.Name = "cpuusage_label";
            this.cpuusage_label.Size = new System.Drawing.Size(72, 23);
            this.cpuusage_label.TabIndex = 8;
            this.cpuusage_label.Text = "label1";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cpuusage_label);
            this.Controls.Add(this.cputemp_label);
            this.Controls.Add(this.cpuname_label);
            this.Controls.Add(this.ramusage_label);
            this.Controls.Add(this.gpuusage_label);
            this.Controls.Add(this.gputemp_label);
            this.Controls.Add(this.gpuname_label);
            this.Controls.Add(this.cputemp);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Monitor";
            this.Size = new System.Drawing.Size(1582, 673);
            this.Load += new System.EventHandler(this.Monitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cputemp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label gpuname_label;
        private System.Windows.Forms.Label gputemp_label;
        private System.Windows.Forms.Label gpuusage_label;
        private System.Windows.Forms.Label ramusage_label;
        private System.Windows.Forms.Label cpuname_label;
        private System.Windows.Forms.Label cputemp_label;
        private System.Windows.Forms.Label cpuusage_label;
    }
}
