namespace MonitorController
{
    partial class MainForm
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
            this.btnLoadMonitors = new System.Windows.Forms.Button();
            this.LstMonitors = new System.Windows.Forms.ListBox();
            this.frmBrightnessSlider = new System.Windows.Forms.GroupBox();
            this.tbrBrightness = new System.Windows.Forms.TrackBar();
            this.fraCapatibilities = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCurrentBrightnessValue = new System.Windows.Forms.Label();
            this.lblCurrentBrightness = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBrightnessMaximumValue = new System.Windows.Forms.Label();
            this.lblBrightnessMaximum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBrightnessMinimumValue = new System.Windows.Forms.Label();
            this.lblBrightnessMinimum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSupportsBrightnessValue = new System.Windows.Forms.Label();
            this.lblSupportsBrightness = new System.Windows.Forms.Label();
            this.pnlSupportDdc = new System.Windows.Forms.Panel();
            this.lblSupportsDdcValue = new System.Windows.Forms.Label();
            this.lblSupportsDdc = new System.Windows.Forms.Label();
            this.frmBrightnessSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).BeginInit();
            this.fraCapatibilities.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSupportDdc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadMonitors
            // 
            this.btnLoadMonitors.Location = new System.Drawing.Point(13, 13);
            this.btnLoadMonitors.Name = "btnLoadMonitors";
            this.btnLoadMonitors.Size = new System.Drawing.Size(375, 23);
            this.btnLoadMonitors.TabIndex = 0;
            this.btnLoadMonitors.Text = "Load available monitors";
            this.btnLoadMonitors.UseVisualStyleBackColor = true;
            this.btnLoadMonitors.Click += new System.EventHandler(this.OnButtonLoadClick);
            // 
            // LstMonitors
            // 
            this.LstMonitors.FormattingEnabled = true;
            this.LstMonitors.Location = new System.Drawing.Point(13, 43);
            this.LstMonitors.Name = "LstMonitors";
            this.LstMonitors.Size = new System.Drawing.Size(377, 69);
            this.LstMonitors.TabIndex = 1;
            this.LstMonitors.SelectedIndexChanged += new System.EventHandler(this.LstMonitors_SelectedIndexChanged);
            // 
            // frmBrightnessSlider
            // 
            this.frmBrightnessSlider.Controls.Add(this.tbrBrightness);
            this.frmBrightnessSlider.Location = new System.Drawing.Point(13, 116);
            this.frmBrightnessSlider.Name = "frmBrightnessSlider";
            this.frmBrightnessSlider.Size = new System.Drawing.Size(111, 241);
            this.frmBrightnessSlider.TabIndex = 3;
            this.frmBrightnessSlider.TabStop = false;
            this.frmBrightnessSlider.Text = "Brightness Controll";
            // 
            // tbrBrightness
            // 
            this.tbrBrightness.Enabled = false;
            this.tbrBrightness.Location = new System.Drawing.Point(41, 30);
            this.tbrBrightness.Maximum = 0;
            this.tbrBrightness.Name = "tbrBrightness";
            this.tbrBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrBrightness.Size = new System.Drawing.Size(45, 196);
            this.tbrBrightness.TabIndex = 0;
            this.tbrBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbrBrightness.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // fraCapatibilities
            // 
            this.fraCapatibilities.Controls.Add(this.panel4);
            this.fraCapatibilities.Controls.Add(this.panel3);
            this.fraCapatibilities.Controls.Add(this.panel2);
            this.fraCapatibilities.Controls.Add(this.panel1);
            this.fraCapatibilities.Controls.Add(this.pnlSupportDdc);
            this.fraCapatibilities.Location = new System.Drawing.Point(140, 116);
            this.fraCapatibilities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fraCapatibilities.Name = "fraCapatibilities";
            this.fraCapatibilities.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fraCapatibilities.Size = new System.Drawing.Size(248, 241);
            this.fraCapatibilities.TabIndex = 4;
            this.fraCapatibilities.TabStop = false;
            this.fraCapatibilities.Text = "Capatibilities";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCurrentBrightnessValue);
            this.panel4.Controls.Add(this.lblCurrentBrightness);
            this.panel4.Location = new System.Drawing.Point(14, 109);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 20);
            this.panel4.TabIndex = 31;
            // 
            // lblCurrentBrightnessValue
            // 
            this.lblCurrentBrightnessValue.AutoSize = true;
            this.lblCurrentBrightnessValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCurrentBrightnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBrightnessValue.Location = new System.Drawing.Point(168, 0);
            this.lblCurrentBrightnessValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentBrightnessValue.Name = "lblCurrentBrightnessValue";
            this.lblCurrentBrightnessValue.Size = new System.Drawing.Size(21, 13);
            this.lblCurrentBrightnessValue.TabIndex = 29;
            this.lblCurrentBrightnessValue.Text = "50";
            // 
            // lblCurrentBrightness
            // 
            this.lblCurrentBrightness.AutoSize = true;
            this.lblCurrentBrightness.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCurrentBrightness.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentBrightness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentBrightness.Name = "lblCurrentBrightness";
            this.lblCurrentBrightness.Size = new System.Drawing.Size(95, 13);
            this.lblCurrentBrightness.TabIndex = 28;
            this.lblCurrentBrightness.Text = "Current brightness:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblBrightnessMaximumValue);
            this.panel3.Controls.Add(this.lblBrightnessMaximum);
            this.panel3.Location = new System.Drawing.Point(14, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 20);
            this.panel3.TabIndex = 30;
            // 
            // lblBrightnessMaximumValue
            // 
            this.lblBrightnessMaximumValue.AutoSize = true;
            this.lblBrightnessMaximumValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBrightnessMaximumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessMaximumValue.Location = new System.Drawing.Point(161, 0);
            this.lblBrightnessMaximumValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrightnessMaximumValue.Name = "lblBrightnessMaximumValue";
            this.lblBrightnessMaximumValue.Size = new System.Drawing.Size(28, 13);
            this.lblBrightnessMaximumValue.TabIndex = 27;
            this.lblBrightnessMaximumValue.Text = "100";
            // 
            // lblBrightnessMaximum
            // 
            this.lblBrightnessMaximum.AutoSize = true;
            this.lblBrightnessMaximum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBrightnessMaximum.Location = new System.Drawing.Point(0, 0);
            this.lblBrightnessMaximum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrightnessMaximum.Name = "lblBrightnessMaximum";
            this.lblBrightnessMaximum.Size = new System.Drawing.Size(113, 13);
            this.lblBrightnessMaximum.TabIndex = 26;
            this.lblBrightnessMaximum.Text = "Brightness Maximimum";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBrightnessMinimumValue);
            this.panel2.Controls.Add(this.lblBrightnessMinimum);
            this.panel2.Location = new System.Drawing.Point(14, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 20);
            this.panel2.TabIndex = 29;
            // 
            // lblBrightnessMinimumValue
            // 
            this.lblBrightnessMinimumValue.AutoSize = true;
            this.lblBrightnessMinimumValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBrightnessMinimumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessMinimumValue.Location = new System.Drawing.Point(175, 0);
            this.lblBrightnessMinimumValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrightnessMinimumValue.Name = "lblBrightnessMinimumValue";
            this.lblBrightnessMinimumValue.Size = new System.Drawing.Size(14, 13);
            this.lblBrightnessMinimumValue.TabIndex = 25;
            this.lblBrightnessMinimumValue.Text = "0";
            // 
            // lblBrightnessMinimum
            // 
            this.lblBrightnessMinimum.AutoSize = true;
            this.lblBrightnessMinimum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBrightnessMinimum.Location = new System.Drawing.Point(0, 0);
            this.lblBrightnessMinimum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrightnessMinimum.Name = "lblBrightnessMinimum";
            this.lblBrightnessMinimum.Size = new System.Drawing.Size(103, 13);
            this.lblBrightnessMinimum.TabIndex = 24;
            this.lblBrightnessMinimum.Text = "Brightness Minimum:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSupportsBrightnessValue);
            this.panel1.Controls.Add(this.lblSupportsBrightness);
            this.panel1.Location = new System.Drawing.Point(14, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 16);
            this.panel1.TabIndex = 28;
            // 
            // lblSupportsBrightnessValue
            // 
            this.lblSupportsBrightnessValue.AutoSize = true;
            this.lblSupportsBrightnessValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSupportsBrightnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupportsBrightnessValue.Location = new System.Drawing.Point(170, 0);
            this.lblSupportsBrightnessValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupportsBrightnessValue.Name = "lblSupportsBrightnessValue";
            this.lblSupportsBrightnessValue.Size = new System.Drawing.Size(19, 13);
            this.lblSupportsBrightnessValue.TabIndex = 23;
            this.lblSupportsBrightnessValue.Text = "---";
            // 
            // lblSupportsBrightness
            // 
            this.lblSupportsBrightness.AutoSize = true;
            this.lblSupportsBrightness.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSupportsBrightness.Location = new System.Drawing.Point(0, 0);
            this.lblSupportsBrightness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupportsBrightness.Name = "lblSupportsBrightness";
            this.lblSupportsBrightness.Size = new System.Drawing.Size(59, 13);
            this.lblSupportsBrightness.TabIndex = 22;
            this.lblSupportsBrightness.Text = "Brightness:";
            // 
            // pnlSupportDdc
            // 
            this.pnlSupportDdc.Controls.Add(this.lblSupportsDdcValue);
            this.pnlSupportDdc.Controls.Add(this.lblSupportsDdc);
            this.pnlSupportDdc.Location = new System.Drawing.Point(14, 23);
            this.pnlSupportDdc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSupportDdc.Name = "pnlSupportDdc";
            this.pnlSupportDdc.Size = new System.Drawing.Size(189, 17);
            this.pnlSupportDdc.TabIndex = 10;
            // 
            // lblSupportsDdcValue
            // 
            this.lblSupportsDdcValue.AutoSize = true;
            this.lblSupportsDdcValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSupportsDdcValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupportsDdcValue.Location = new System.Drawing.Point(170, 0);
            this.lblSupportsDdcValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupportsDdcValue.Name = "lblSupportsDdcValue";
            this.lblSupportsDdcValue.Size = new System.Drawing.Size(19, 13);
            this.lblSupportsDdcValue.TabIndex = 11;
            this.lblSupportsDdcValue.Text = "---";
            // 
            // lblSupportsDdc
            // 
            this.lblSupportsDdc.AutoSize = true;
            this.lblSupportsDdc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSupportsDdc.Location = new System.Drawing.Point(0, 0);
            this.lblSupportsDdc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupportsDdc.Name = "lblSupportsDdc";
            this.lblSupportsDdc.Size = new System.Drawing.Size(78, 13);
            this.lblSupportsDdc.TabIndex = 10;
            this.lblSupportsDdc.Text = "Supports DDC:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 364);
            this.Controls.Add(this.fraCapatibilities);
            this.Controls.Add(this.frmBrightnessSlider);
            this.Controls.Add(this.LstMonitors);
            this.Controls.Add(this.btnLoadMonitors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Monitor Brightness";
            this.frmBrightnessSlider.ResumeLayout(false);
            this.frmBrightnessSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).EndInit();
            this.fraCapatibilities.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSupportDdc.ResumeLayout(false);
            this.pnlSupportDdc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadMonitors;
        private System.Windows.Forms.ListBox LstMonitors;
        private System.Windows.Forms.GroupBox frmBrightnessSlider;
        private System.Windows.Forms.TrackBar tbrBrightness;
        private System.Windows.Forms.GroupBox fraCapatibilities;
        private System.Windows.Forms.Panel pnlSupportDdc;
        private System.Windows.Forms.Label lblSupportsDdcValue;
        private System.Windows.Forms.Label lblSupportsDdc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCurrentBrightnessValue;
        private System.Windows.Forms.Label lblCurrentBrightness;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBrightnessMaximumValue;
        private System.Windows.Forms.Label lblBrightnessMaximum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBrightnessMinimumValue;
        private System.Windows.Forms.Label lblBrightnessMinimum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSupportsBrightnessValue;
        private System.Windows.Forms.Label lblSupportsBrightness;
    }
}

