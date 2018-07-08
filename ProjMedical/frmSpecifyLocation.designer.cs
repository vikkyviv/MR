namespace SPECIFY_LOCATION
{
    partial class frmSpecifyLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecifyLocation));
            this.lblSelectDrive = new System.Windows.Forms.Label();
            this.comboSelectDrive = new System.Windows.Forms.ComboBox();
            this.lblSelectthePath = new System.Windows.Forms.Label();
            this.lblLocationToSave = new System.Windows.Forms.Label();
            this.txtLocationToSave = new System.Windows.Forms.TextBox();
            this.listBxSelectthePath = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectDrive
            // 
            this.lblSelectDrive.AutoSize = true;
            this.lblSelectDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDrive.Location = new System.Drawing.Point(62, 41);
            this.lblSelectDrive.Name = "lblSelectDrive";
            this.lblSelectDrive.Size = new System.Drawing.Size(93, 16);
            this.lblSelectDrive.TabIndex = 0;
            this.lblSelectDrive.Text = "Select Drive";
            // 
            // comboSelectDrive
            // 
            this.comboSelectDrive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSelectDrive.FormattingEnabled = true;
            this.comboSelectDrive.Items.AddRange(new object[] {
            "C:",
            "D:",
            "E:",
            "F:"});
            this.comboSelectDrive.Location = new System.Drawing.Point(216, 40);
            this.comboSelectDrive.Name = "comboSelectDrive";
            this.comboSelectDrive.Size = new System.Drawing.Size(242, 21);
            this.comboSelectDrive.TabIndex = 1;
            // 
            // lblSelectthePath
            // 
            this.lblSelectthePath.AutoSize = true;
            this.lblSelectthePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectthePath.Location = new System.Drawing.Point(62, 154);
            this.lblSelectthePath.Name = "lblSelectthePath";
            this.lblSelectthePath.Size = new System.Drawing.Size(112, 16);
            this.lblSelectthePath.TabIndex = 2;
            this.lblSelectthePath.Text = "Select the Path";
            // 
            // lblLocationToSave
            // 
            this.lblLocationToSave.AutoSize = true;
            this.lblLocationToSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationToSave.Location = new System.Drawing.Point(62, 308);
            this.lblLocationToSave.Name = "lblLocationToSave";
            this.lblLocationToSave.Size = new System.Drawing.Size(128, 16);
            this.lblLocationToSave.TabIndex = 4;
            this.lblLocationToSave.Text = " Location to Save";
            // 
            // txtLocationToSave
            // 
            this.txtLocationToSave.Location = new System.Drawing.Point(216, 308);
            this.txtLocationToSave.Name = "txtLocationToSave";
            this.txtLocationToSave.Size = new System.Drawing.Size(242, 20);
            this.txtLocationToSave.TabIndex = 5;
            // 
            // listBxSelectthePath
            // 
            this.listBxSelectthePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBxSelectthePath.FormattingEnabled = true;
            this.listBxSelectthePath.Items.AddRange(new object[] {
            "C:\\",
            "Program files[x86]",
            "MicroSoft Visual Studio",
            "VB98",
            "SetUP",
            "Template",
            "Tsql",
            "Wizards"});
            this.listBxSelectthePath.Location = new System.Drawing.Point(216, 95);
            this.listBxSelectthePath.Name = "listBxSelectthePath";
            this.listBxSelectthePath.Size = new System.Drawing.Size(242, 160);
            this.listBxSelectthePath.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(226, 376);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(358, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSpecifyLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(574, 444);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.listBxSelectthePath);
            this.Controls.Add(this.txtLocationToSave);
            this.Controls.Add(this.lblLocationToSave);
            this.Controls.Add(this.lblSelectthePath);
            this.Controls.Add(this.comboSelectDrive);
            this.Controls.Add(this.lblSelectDrive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSpecifyLocation";
            this.Text = "SPECIFY LOCATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDrive;
        private System.Windows.Forms.ComboBox comboSelectDrive;
        private System.Windows.Forms.Label lblSelectthePath;
        private System.Windows.Forms.Label lblLocationToSave;
        private System.Windows.Forms.TextBox txtLocationToSave;
        private System.Windows.Forms.ListBox listBxSelectthePath;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}

