namespace SELECT_REPORT_FORMAT
{
    partial class frmSelectReportFormat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectReportFormat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ImageResizing = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoOfLines = new System.Windows.Forms.TextBox();
            this.lblPrintReport = new System.Windows.Forms.Label();
            this.rdbPrint = new System.Windows.Forms.RadioButton();
            this.rdpPrePrint = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDefault = new System.Windows.Forms.RadioButton();
            this.rdbtwo = new System.Windows.Forms.RadioButton();
            this.rdbFour = new System.Windows.Forms.RadioButton();
            this.rdbSix = new System.Windows.Forms.RadioButton();
            this.rdbEight = new System.Windows.Forms.RadioButton();
            this.rdbTen = new System.Windows.Forms.RadioButton();
            this.rdbTwelve = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageResizing)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 547);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ImageResizing);
            this.panel2.Location = new System.Drawing.Point(536, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 44);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image Resizing";
            // 
            // ImageResizing
            // 
            this.ImageResizing.Increment = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.ImageResizing.Location = new System.Drawing.Point(122, 10);
            this.ImageResizing.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.ImageResizing.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ImageResizing.Name = "ImageResizing";
            this.ImageResizing.Size = new System.Drawing.Size(79, 20);
            this.ImageResizing.TabIndex = 5;
            this.ImageResizing.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.ImageResizing.ValueChanged += new System.EventHandler(this.ImageResizing_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtNoOfLines);
            this.groupBox1.Controls.Add(this.lblPrintReport);
            this.groupBox1.Controls.Add(this.rdbPrint);
            this.groupBox1.Controls.Add(this.rdpPrePrint);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stationary Options";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNoOfLines
            // 
            this.txtNoOfLines.Location = new System.Drawing.Point(380, 88);
            this.txtNoOfLines.Name = "txtNoOfLines";
            this.txtNoOfLines.Size = new System.Drawing.Size(49, 22);
            this.txtNoOfLines.TabIndex = 3;
            this.txtNoOfLines.Text = "0";
            this.txtNoOfLines.Visible = false;
            // 
            // lblPrintReport
            // 
            this.lblPrintReport.AutoSize = true;
            this.lblPrintReport.Location = new System.Drawing.Point(15, 88);
            this.lblPrintReport.Name = "lblPrintReport";
            this.lblPrintReport.Size = new System.Drawing.Size(349, 16);
            this.lblPrintReport.TabIndex = 2;
            this.lblPrintReport.Text = "Print Report and Images Leaving No.Of Lines(1-5)";
            this.lblPrintReport.Visible = false;
            // 
            // rdbPrint
            // 
            this.rdbPrint.AutoSize = true;
            this.rdbPrint.BackColor = System.Drawing.SystemColors.Control;
            this.rdbPrint.Checked = true;
            this.rdbPrint.Location = new System.Drawing.Point(18, 47);
            this.rdbPrint.Name = "rdbPrint";
            this.rdbPrint.Size = new System.Drawing.Size(176, 20);
            this.rdbPrint.TabIndex = 0;
            this.rdbPrint.TabStop = true;
            this.rdbPrint.Text = "Logo and Letter Head";
            this.rdbPrint.UseVisualStyleBackColor = false;
            this.rdbPrint.CheckedChanged += new System.EventHandler(this.rdbPrint_CheckedChanged);
            // 
            // rdpPrePrint
            // 
            this.rdpPrePrint.AutoSize = true;
            this.rdpPrePrint.Location = new System.Drawing.Point(216, 45);
            this.rdpPrePrint.Name = "rdpPrePrint";
            this.rdpPrePrint.Size = new System.Drawing.Size(178, 20);
            this.rdpPrePrint.TabIndex = 1;
            this.rdpPrePrint.Text = "Pre-Printed Stationary";
            this.rdpPrePrint.UseVisualStyleBackColor = true;
            this.rdpPrePrint.CheckedChanged += new System.EventHandler(this.rdpPrePrint_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(595, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(595, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 39);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 205);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.rdbDefault);
            this.groupBox2.Controls.Add(this.rdbtwo);
            this.groupBox2.Controls.Add(this.rdbFour);
            this.groupBox2.Controls.Add(this.rdbSix);
            this.groupBox2.Controls.Add(this.rdbEight);
            this.groupBox2.Controls.Add(this.rdbTen);
            this.groupBox2.Controls.Add(this.rdbTwelve);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 366);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Report Format";
            // 
            // rdbDefault
            // 
            this.rdbDefault.AutoSize = true;
            this.rdbDefault.Checked = true;
            this.rdbDefault.Location = new System.Drawing.Point(18, 45);
            this.rdbDefault.Name = "rdbDefault";
            this.rdbDefault.Size = new System.Drawing.Size(348, 20);
            this.rdbDefault.TabIndex = 1;
            this.rdbDefault.TabStop = true;
            this.rdbDefault.Text = "By Default 4 Images Report On the Same Page";
            this.rdbDefault.UseVisualStyleBackColor = true;
            this.rdbDefault.CheckedChanged += new System.EventHandler(this.rdbDefault_CheckedChanged);
            // 
            // rdbtwo
            // 
            this.rdbtwo.AutoSize = true;
            this.rdbtwo.Location = new System.Drawing.Point(18, 85);
            this.rdbtwo.Name = "rdbtwo";
            this.rdbtwo.Size = new System.Drawing.Size(308, 20);
            this.rdbtwo.TabIndex = 2;
            this.rdbtwo.Text = "Report and 2 images on Seperate Pages";
            this.rdbtwo.UseVisualStyleBackColor = true;
            this.rdbtwo.CheckedChanged += new System.EventHandler(this.rdbtwo_CheckedChanged);
            // 
            // rdbFour
            // 
            this.rdbFour.AutoSize = true;
            this.rdbFour.Location = new System.Drawing.Point(18, 124);
            this.rdbFour.Name = "rdbFour";
            this.rdbFour.Size = new System.Drawing.Size(309, 20);
            this.rdbFour.TabIndex = 3;
            this.rdbFour.Text = "Repory and 4 images on seperate pages";
            this.rdbFour.UseVisualStyleBackColor = true;
            this.rdbFour.CheckedChanged += new System.EventHandler(this.rdbFour_CheckedChanged);
            // 
            // rdbSix
            // 
            this.rdbSix.AutoSize = true;
            this.rdbSix.Location = new System.Drawing.Point(18, 164);
            this.rdbSix.Name = "rdbSix";
            this.rdbSix.Size = new System.Drawing.Size(305, 20);
            this.rdbSix.TabIndex = 4;
            this.rdbSix.Text = "Report and 6 images on seperate pages";
            this.rdbSix.UseVisualStyleBackColor = true;
            this.rdbSix.CheckedChanged += new System.EventHandler(this.rdbSix_CheckedChanged);
            // 
            // rdbEight
            // 
            this.rdbEight.AutoSize = true;
            this.rdbEight.Location = new System.Drawing.Point(18, 207);
            this.rdbEight.Name = "rdbEight";
            this.rdbEight.Size = new System.Drawing.Size(305, 20);
            this.rdbEight.TabIndex = 5;
            this.rdbEight.Text = "Report and 8 images on seperate pages";
            this.rdbEight.UseVisualStyleBackColor = true;
            this.rdbEight.CheckedChanged += new System.EventHandler(this.rdbEight_CheckedChanged);
            // 
            // rdbTen
            // 
            this.rdbTen.AutoSize = true;
            this.rdbTen.Location = new System.Drawing.Point(18, 248);
            this.rdbTen.Name = "rdbTen";
            this.rdbTen.Size = new System.Drawing.Size(313, 20);
            this.rdbTen.TabIndex = 6;
            this.rdbTen.Text = "Report and 10 images on seperate pages";
            this.rdbTen.UseVisualStyleBackColor = true;
            this.rdbTen.CheckedChanged += new System.EventHandler(this.rdbTen_CheckedChanged);
            // 
            // rdbTwelve
            // 
            this.rdbTwelve.AutoSize = true;
            this.rdbTwelve.Location = new System.Drawing.Point(18, 288);
            this.rdbTwelve.Name = "rdbTwelve";
            this.rdbTwelve.Size = new System.Drawing.Size(313, 20);
            this.rdbTwelve.TabIndex = 7;
            this.rdbTwelve.Text = "Report and 12 images on seperate pages";
            this.rdbTwelve.UseVisualStyleBackColor = true;
            this.rdbTwelve.CheckedChanged += new System.EventHandler(this.rdbTwelve_CheckedChanged);
            // 
            // frmSelectReportFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 571);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSelectReportFormat";
            this.Text = "SELECT REPORT FORMAT";
            this.Load += new System.EventHandler(this.frmSelectReportFormat_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageResizing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrintReport;
        private System.Windows.Forms.RadioButton rdbPrint;
        private System.Windows.Forms.RadioButton rdpPrePrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbDefault;
        private System.Windows.Forms.RadioButton rdbtwo;
        private System.Windows.Forms.RadioButton rdbFour;
        private System.Windows.Forms.RadioButton rdbSix;
        private System.Windows.Forms.RadioButton rdbEight;
        private System.Windows.Forms.RadioButton rdbTen;
        private System.Windows.Forms.RadioButton rdbTwelve;
        private System.Windows.Forms.TextBox txtNoOfLines;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ImageResizing;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

