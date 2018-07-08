namespace ProjMedical
{
    partial class frmReportSelection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImageProcessing = new System.Windows.Forms.Button();
            this.btnStartAgain = new System.Windows.Forms.Button();
            this.btnShowImages = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.lblRefByDoctor = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtfReportDetails = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReportName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnImageProcessing);
            this.groupBox1.Controls.Add(this.btnStartAgain);
            this.groupBox1.Controls.Add(this.btnShowImages);
            this.groupBox1.Controls.Add(this.btnShowReport);
            this.groupBox1.Controls.Add(this.lblRefByDoctor);
            this.groupBox1.Controls.Add(this.lblPatientName);
            this.groupBox1.Controls.Add(this.lblPatientID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rtfReportDetails);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbReportName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(497, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 328);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnImageProcessing
            // 
            this.btnImageProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageProcessing.Location = new System.Drawing.Point(640, 466);
            this.btnImageProcessing.Name = "btnImageProcessing";
            this.btnImageProcessing.Size = new System.Drawing.Size(160, 36);
            this.btnImageProcessing.TabIndex = 13;
            this.btnImageProcessing.Text = "Image Processing";
            this.btnImageProcessing.UseVisualStyleBackColor = true;
            this.btnImageProcessing.Visible = false;
            this.btnImageProcessing.Click += new System.EventHandler(this.btnImageProcessing_Click);
            // 
            // btnStartAgain
            // 
            this.btnStartAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAgain.Location = new System.Drawing.Point(785, 425);
            this.btnStartAgain.Name = "btnStartAgain";
            this.btnStartAgain.Size = new System.Drawing.Size(121, 36);
            this.btnStartAgain.TabIndex = 12;
            this.btnStartAgain.Text = "Start Again";
            this.btnStartAgain.UseVisualStyleBackColor = true;
            this.btnStartAgain.Click += new System.EventHandler(this.btnStartAgain_Click);
            // 
            // btnShowImages
            // 
            this.btnShowImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowImages.Location = new System.Drawing.Point(658, 425);
            this.btnShowImages.Name = "btnShowImages";
            this.btnShowImages.Size = new System.Drawing.Size(121, 36);
            this.btnShowImages.TabIndex = 11;
            this.btnShowImages.Text = "Show Imges";
            this.btnShowImages.UseVisualStyleBackColor = true;
            this.btnShowImages.Click += new System.EventHandler(this.btnShowImages_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Location = new System.Drawing.Point(531, 425);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(121, 36);
            this.btnShowReport.TabIndex = 10;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // lblRefByDoctor
            // 
            this.lblRefByDoctor.AutoSize = true;
            this.lblRefByDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefByDoctor.Location = new System.Drawing.Point(623, 65);
            this.lblRefByDoctor.Name = "lblRefByDoctor";
            this.lblRefByDoctor.Size = new System.Drawing.Size(16, 16);
            this.lblRefByDoctor.TabIndex = 9;
            this.lblRefByDoctor.Text = "d";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(623, 41);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(16, 16);
            this.lblPatientName.TabIndex = 8;
            this.lblPatientName.Text = "d";
            this.lblPatientName.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(623, 17);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(16, 16);
            this.lblPatientID.TabIndex = 7;
            this.lblPatientID.Text = "d";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Refered By Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient ID";
            // 
            // rtfReportDetails
            // 
            this.rtfReportDetails.Location = new System.Drawing.Point(12, 88);
            this.rtfReportDetails.Name = "rtfReportDetails";
            this.rtfReportDetails.Size = new System.Drawing.Size(458, 442);
            this.rtfReportDetails.TabIndex = 3;
            this.rtfReportDetails.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Report Details";
            // 
            // cmbReportName
            // 
            this.cmbReportName.FormattingEnabled = true;
            this.cmbReportName.Location = new System.Drawing.Point(11, 32);
            this.cmbReportName.Name = "cmbReportName";
            this.cmbReportName.Size = new System.Drawing.Size(459, 21);
            this.cmbReportName.TabIndex = 1;
            this.cmbReportName.SelectedIndexChanged += new System.EventHandler(this.cmbReportName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Report Name";
            // 
            // frmReportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 568);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportSelection";
            this.Text = "Report Selection";
            this.Load += new System.EventHandler(this.frmReportSelection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRefByDoctor;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtfReportDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbReportName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImageProcessing;
        private System.Windows.Forms.Button btnStartAgain;
        private System.Windows.Forms.Button btnShowImages;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}