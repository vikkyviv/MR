namespace ProjMedical
{
    partial class frmShowReport
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
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.panelWordList = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lstWords = new System.Windows.Forms.ListView();
            this.panelWordList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReport.Location = new System.Drawing.Point(716, 116);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(118, 28);
            this.btnSaveReport.TabIndex = 12;
            this.btnSaveReport.Text = "Save Report";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(716, 82);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 28);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(457, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(153, 43);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(0, 16);
            this.lblPID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "P ID";
            // 
            // rtbReport
            // 
            this.rtbReport.Location = new System.Drawing.Point(4, 77);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.Size = new System.Drawing.Size(452, 542);
            this.rtbReport.TabIndex = 13;
            this.rtbReport.Text = "";
            // 
            // panelWordList
            // 
            this.panelWordList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWordList.Controls.Add(this.lstWords);
            this.panelWordList.Controls.Add(this.label3);
            this.panelWordList.Location = new System.Drawing.Point(468, 78);
            this.panelWordList.Name = "panelWordList";
            this.panelWordList.Size = new System.Drawing.Size(236, 542);
            this.panelWordList.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(54, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "List of Words";
            // 
            // lstWords
            // 
            this.lstWords.Location = new System.Drawing.Point(4, 25);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(227, 512);
            this.lstWords.TabIndex = 1;
            this.lstWords.UseCompatibleStateImageBehavior = false;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // frmShowReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 631);
            this.Controls.Add(this.panelWordList);
            this.Controls.Add(this.rtbReport);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.label1);
            this.Name = "frmShowReport";
            this.Text = "View Report";
            this.Load += new System.EventHandler(this.frmShowReport_Load);
            this.panelWordList.ResumeLayout(false);
            this.panelWordList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbReport;
        private System.Windows.Forms.Panel panelWordList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstWords;
    }
}