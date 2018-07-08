namespace ProjMedical
{
    partial class frmCaptureDevice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbConnectors = new System.Windows.Forms.ComboBox();
            this.lblcmbConnectors = new System.Windows.Forms.Label();
            this.cmbStandards = new System.Windows.Forms.ComboBox();
            this.lblcmbStandards = new System.Windows.Forms.Label();
            this.cmbFormats = new System.Windows.Forms.ComboBox();
            this.lblcmbFormats = new System.Windows.Forms.Label();
            this.cmbCompression = new System.Windows.Forms.ComboBox();
            this.lblcmbCompression = new System.Windows.Forms.Label();
            this.cmbVideoDevice = new System.Windows.Forms.ComboBox();
            this.lblcmbVideoDevice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.cmbConnectors);
            this.panel1.Controls.Add(this.lblcmbConnectors);
            this.panel1.Controls.Add(this.cmbStandards);
            this.panel1.Controls.Add(this.lblcmbStandards);
            this.panel1.Controls.Add(this.cmbFormats);
            this.panel1.Controls.Add(this.lblcmbFormats);
            this.panel1.Controls.Add(this.cmbCompression);
            this.panel1.Controls.Add(this.lblcmbCompression);
            this.panel1.Controls.Add(this.cmbVideoDevice);
            this.panel1.Controls.Add(this.lblcmbVideoDevice);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 314);
            this.panel1.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(222, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 36);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(129, 255);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 36);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbConnectors
            // 
            this.cmbConnectors.FormattingEnabled = true;
            this.cmbConnectors.Location = new System.Drawing.Point(187, 62);
            this.cmbConnectors.Name = "cmbConnectors";
            this.cmbConnectors.Size = new System.Drawing.Size(245, 24);
            this.cmbConnectors.TabIndex = 21;
            // 
            // lblcmbConnectors
            // 
            this.lblcmbConnectors.AutoSize = true;
            this.lblcmbConnectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbConnectors.Location = new System.Drawing.Point(31, 66);
            this.lblcmbConnectors.Name = "lblcmbConnectors";
            this.lblcmbConnectors.Size = new System.Drawing.Size(123, 16);
            this.lblcmbConnectors.TabIndex = 20;
            this.lblcmbConnectors.Text = "Video Connector";
            // 
            // cmbStandards
            // 
            this.cmbStandards.FormattingEnabled = true;
            this.cmbStandards.Location = new System.Drawing.Point(187, 113);
            this.cmbStandards.Name = "cmbStandards";
            this.cmbStandards.Size = new System.Drawing.Size(245, 24);
            this.cmbStandards.TabIndex = 19;
            // 
            // lblcmbStandards
            // 
            this.lblcmbStandards.AutoSize = true;
            this.lblcmbStandards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbStandards.Location = new System.Drawing.Point(31, 116);
            this.lblcmbStandards.Name = "lblcmbStandards";
            this.lblcmbStandards.Size = new System.Drawing.Size(124, 16);
            this.lblcmbStandards.TabIndex = 18;
            this.lblcmbStandards.Text = "Video Standards";
            // 
            // cmbFormats
            // 
            this.cmbFormats.FormattingEnabled = true;
            this.cmbFormats.Location = new System.Drawing.Point(187, 156);
            this.cmbFormats.Name = "cmbFormats";
            this.cmbFormats.Size = new System.Drawing.Size(245, 24);
            this.cmbFormats.TabIndex = 17;
            // 
            // lblcmbFormats
            // 
            this.lblcmbFormats.AutoSize = true;
            this.lblcmbFormats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbFormats.Location = new System.Drawing.Point(31, 160);
            this.lblcmbFormats.Name = "lblcmbFormats";
            this.lblcmbFormats.Size = new System.Drawing.Size(101, 16);
            this.lblcmbFormats.TabIndex = 16;
            this.lblcmbFormats.Text = "Video Format";
            // 
            // cmbCompression
            // 
            this.cmbCompression.FormattingEnabled = true;
            this.cmbCompression.Location = new System.Drawing.Point(187, 198);
            this.cmbCompression.Name = "cmbCompression";
            this.cmbCompression.Size = new System.Drawing.Size(245, 24);
            this.cmbCompression.TabIndex = 15;
            // 
            // lblcmbCompression
            // 
            this.lblcmbCompression.AutoSize = true;
            this.lblcmbCompression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbCompression.Location = new System.Drawing.Point(31, 202);
            this.lblcmbCompression.Name = "lblcmbCompression";
            this.lblcmbCompression.Size = new System.Drawing.Size(144, 16);
            this.lblcmbCompression.TabIndex = 14;
            this.lblcmbCompression.Text = "Video Compression";
            // 
            // cmbVideoDevice
            // 
            this.cmbVideoDevice.FormattingEnabled = true;
            this.cmbVideoDevice.Location = new System.Drawing.Point(187, 19);
            this.cmbVideoDevice.Name = "cmbVideoDevice";
            this.cmbVideoDevice.Size = new System.Drawing.Size(245, 24);
            this.cmbVideoDevice.TabIndex = 13;
            // 
            // lblcmbVideoDevice
            // 
            this.lblcmbVideoDevice.AutoSize = true;
            this.lblcmbVideoDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbVideoDevice.Location = new System.Drawing.Point(31, 20);
            this.lblcmbVideoDevice.Name = "lblcmbVideoDevice";
            this.lblcmbVideoDevice.Size = new System.Drawing.Size(102, 16);
            this.lblcmbVideoDevice.TabIndex = 12;
            this.lblcmbVideoDevice.Text = "Video Device";
            // 
            // frmCaptureDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 319);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaptureDevice";
            this.Text = "Capture Device Properties";
            this.Load += new System.EventHandler(this.frmCaptureDevice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbConnectors;
        private System.Windows.Forms.Label lblcmbConnectors;
        private System.Windows.Forms.ComboBox cmbStandards;
        private System.Windows.Forms.Label lblcmbStandards;
        private System.Windows.Forms.ComboBox cmbFormats;
        private System.Windows.Forms.Label lblcmbFormats;
        private System.Windows.Forms.ComboBox cmbCompression;
        private System.Windows.Forms.Label lblcmbCompression;
        private System.Windows.Forms.ComboBox cmbVideoDevice;
        private System.Windows.Forms.Label lblcmbVideoDevice;
    }
}