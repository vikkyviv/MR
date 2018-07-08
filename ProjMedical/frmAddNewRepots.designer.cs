namespace Add_New_Reports
{
    partial class frmAddNewRepots
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
            this.listdetailsofthereport = new System.Windows.Forms.RichTextBox();
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndeletereport = new System.Windows.Forms.Button();
            this.btneditreport = new System.Windows.Forms.Button();
            this.btnsavereports = new System.Windows.Forms.Button();
            this.btnspellcheck = new System.Windows.Forms.Button();
            this.btnaddreports = new System.Windows.Forms.Button();
            this.Comboreportname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listdetailsofthereport);
            this.panel1.Controls.Add(this.txtReportName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Comboreportname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 608);
            this.panel1.TabIndex = 0;
            // 
            // listdetailsofthereport
            // 
            this.listdetailsofthereport.Location = new System.Drawing.Point(147, 65);
            this.listdetailsofthereport.Name = "listdetailsofthereport";
            this.listdetailsofthereport.Size = new System.Drawing.Size(367, 492);
            this.listdetailsofthereport.TabIndex = 7;
            this.listdetailsofthereport.Text = "";
            // 
            // txtReportName
            // 
            this.txtReportName.Location = new System.Drawing.Point(148, 21);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(367, 20);
            this.txtReportName.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.btndeletereport);
            this.panel2.Controls.Add(this.btneditreport);
            this.panel2.Controls.Add(this.btnsavereports);
            this.panel2.Controls.Add(this.btnspellcheck);
            this.panel2.Controls.Add(this.btnaddreports);
            this.panel2.Location = new System.Drawing.Point(535, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 410);
            this.panel2.TabIndex = 5;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(43, 359);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(109, 30);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(44, 303);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(109, 36);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndeletereport
            // 
            this.btndeletereport.Location = new System.Drawing.Point(42, 254);
            this.btndeletereport.Name = "btndeletereport";
            this.btndeletereport.Size = new System.Drawing.Size(111, 34);
            this.btndeletereport.TabIndex = 4;
            this.btndeletereport.Text = "Delete Reports";
            this.btndeletereport.UseVisualStyleBackColor = true;
            this.btndeletereport.Click += new System.EventHandler(this.btndeletereport_Click);
            // 
            // btneditreport
            // 
            this.btneditreport.Location = new System.Drawing.Point(36, 202);
            this.btneditreport.Name = "btneditreport";
            this.btneditreport.Size = new System.Drawing.Size(118, 30);
            this.btneditreport.TabIndex = 3;
            this.btneditreport.Text = "Edit Reports";
            this.btneditreport.UseVisualStyleBackColor = true;
            this.btneditreport.Click += new System.EventHandler(this.btneditreport_Click);
            // 
            // btnsavereports
            // 
            this.btnsavereports.Location = new System.Drawing.Point(30, 142);
            this.btnsavereports.Name = "btnsavereports";
            this.btnsavereports.Size = new System.Drawing.Size(124, 34);
            this.btnsavereports.TabIndex = 2;
            this.btnsavereports.Text = "Save Reports";
            this.btnsavereports.UseVisualStyleBackColor = true;
            this.btnsavereports.Click += new System.EventHandler(this.btnsavereports_Click);
            // 
            // btnspellcheck
            // 
            this.btnspellcheck.Location = new System.Drawing.Point(29, 85);
            this.btnspellcheck.Name = "btnspellcheck";
            this.btnspellcheck.Size = new System.Drawing.Size(125, 32);
            this.btnspellcheck.TabIndex = 1;
            this.btnspellcheck.Text = "Spell Check";
            this.btnspellcheck.UseVisualStyleBackColor = true;
            this.btnspellcheck.Click += new System.EventHandler(this.btnspellcheck_Click);
            // 
            // btnaddreports
            // 
            this.btnaddreports.Location = new System.Drawing.Point(31, 29);
            this.btnaddreports.Name = "btnaddreports";
            this.btnaddreports.Size = new System.Drawing.Size(124, 32);
            this.btnaddreports.TabIndex = 0;
            this.btnaddreports.Text = "Add  Reports";
            this.btnaddreports.UseVisualStyleBackColor = true;
            this.btnaddreports.Click += new System.EventHandler(this.btnaddreports_Click);
            // 
            // Comboreportname
            // 
            this.Comboreportname.FormattingEnabled = true;
            this.Comboreportname.Location = new System.Drawing.Point(147, 18);
            this.Comboreportname.Name = "Comboreportname";
            this.Comboreportname.Size = new System.Drawing.Size(367, 21);
            this.Comboreportname.TabIndex = 4;
            this.Comboreportname.SelectedIndexChanged += new System.EventHandler(this.Comboreportname_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Details of\r\nthe Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Name";
            // 
            // frmAddNewRepots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 701);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddNewRepots";
            this.Text = "Add New Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Comboreportname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeletereport;
        private System.Windows.Forms.Button btneditreport;
        private System.Windows.Forms.Button btnsavereports;
        private System.Windows.Forms.Button btnspellcheck;
        private System.Windows.Forms.Button btnaddreports;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.RichTextBox listdetailsofthereport;
    }
}

