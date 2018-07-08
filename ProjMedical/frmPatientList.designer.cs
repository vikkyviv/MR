namespace PATIENT_LIST
{
    partial class frmPatientList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbReportMode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerMonthWise = new System.Windows.Forms.DateTimePicker();
            this.lblmonthwise = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblsearchby = new System.Windows.Forms.Label();
            this.checkAllRecords = new System.Windows.Forms.CheckBox();
            this.lblreportmode = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.PatientsdataGridView = new System.Windows.Forms.DataGridView();
            this.chkDeleteRecords = new System.Windows.Forms.CheckBox();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.dateTimeDeleteRecords = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbReportMode);
            this.panel1.Controls.Add(this.dateTimePickerMonthWise);
            this.panel1.Controls.Add(this.lblmonthwise);
            this.panel1.Controls.Add(this.cmbSearchBy);
            this.panel1.Controls.Add(this.lblsearchby);
            this.panel1.Controls.Add(this.checkAllRecords);
            this.panel1.Controls.Add(this.lblreportmode);
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(-3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 55);
            this.panel1.TabIndex = 0;
            // 
            // cmbReportMode
            // 
            this.cmbReportMode.FormattingEnabled = true;
            this.cmbReportMode.Location = new System.Drawing.Point(520, 18);
            this.cmbReportMode.Name = "cmbReportMode";
            this.cmbReportMode.Size = new System.Drawing.Size(130, 21);
            this.cmbReportMode.TabIndex = 5;
            this.cmbReportMode.Visible = false;
            this.cmbReportMode.SelectedIndexChanged += new System.EventHandler(this.cmbReportMode_SelectedIndexChanged);
            // 
            // dateTimePickerMonthWise
            // 
            this.dateTimePickerMonthWise.Location = new System.Drawing.Point(776, 20);
            this.dateTimePickerMonthWise.Name = "dateTimePickerMonthWise";
            this.dateTimePickerMonthWise.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerMonthWise.TabIndex = 4;
            this.dateTimePickerMonthWise.Visible = false;
            this.dateTimePickerMonthWise.ValueChanged += new System.EventHandler(this.dateTimePickerMonthWise_ValueChanged);
            // 
            // lblmonthwise
            // 
            this.lblmonthwise.AutoSize = true;
            this.lblmonthwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthwise.Location = new System.Drawing.Point(682, 22);
            this.lblmonthwise.Name = "lblmonthwise";
            this.lblmonthwise.Size = new System.Drawing.Size(88, 16);
            this.lblmonthwise.TabIndex = 1;
            this.lblmonthwise.Text = "Month Wise";
            this.lblmonthwise.Visible = false;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Date Wise",
            "Done By",
            "Investigation",
            "Patient Name",
            "Ref Doc"});
            this.cmbSearchBy.Location = new System.Drawing.Point(230, 18);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(154, 21);
            this.cmbSearchBy.TabIndex = 3;
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            // 
            // lblsearchby
            // 
            this.lblsearchby.AutoSize = true;
            this.lblsearchby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchby.Location = new System.Drawing.Point(133, 21);
            this.lblsearchby.Name = "lblsearchby";
            this.lblsearchby.Size = new System.Drawing.Size(79, 16);
            this.lblsearchby.TabIndex = 2;
            this.lblsearchby.Text = "Search By";
            // 
            // checkAllRecords
            // 
            this.checkAllRecords.AutoSize = true;
            this.checkAllRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllRecords.Location = new System.Drawing.Point(9, 19);
            this.checkAllRecords.Name = "checkAllRecords";
            this.checkAllRecords.Size = new System.Drawing.Size(108, 20);
            this.checkAllRecords.TabIndex = 1;
            this.checkAllRecords.Text = "All Records";
            this.checkAllRecords.UseVisualStyleBackColor = true;
            this.checkAllRecords.CheckedChanged += new System.EventHandler(this.checkAllRecords_CheckedChanged);
            // 
            // lblreportmode
            // 
            this.lblreportmode.AutoSize = true;
            this.lblreportmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreportmode.Location = new System.Drawing.Point(407, 20);
            this.lblreportmode.Name = "lblreportmode";
            this.lblreportmode.Size = new System.Drawing.Size(98, 16);
            this.lblreportmode.TabIndex = 1;
            this.lblreportmode.Text = "Report Mode";
            this.lblreportmode.Visible = false;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(406, 19);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbSearch.TabIndex = 11;
            this.cmbSearch.Visible = false;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(406, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // PatientsdataGridView
            // 
            this.PatientsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsdataGridView.Location = new System.Drawing.Point(4, 73);
            this.PatientsdataGridView.Name = "PatientsdataGridView";
            this.PatientsdataGridView.Size = new System.Drawing.Size(1003, 398);
            this.PatientsdataGridView.TabIndex = 1;
            this.PatientsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsdataGridView_CellContentClick);
            // 
            // chkDeleteRecords
            // 
            this.chkDeleteRecords.AutoSize = true;
            this.chkDeleteRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteRecords.Location = new System.Drawing.Point(10, 489);
            this.chkDeleteRecords.Name = "chkDeleteRecords";
            this.chkDeleteRecords.Size = new System.Drawing.Size(136, 20);
            this.chkDeleteRecords.TabIndex = 2;
            this.chkDeleteRecords.Text = "Delete Records";
            this.chkDeleteRecords.UseVisualStyleBackColor = true;
            this.chkDeleteRecords.CheckedChanged += new System.EventHandler(this.chkDeleteRecords_CheckedChanged);
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Items.AddRange(new object[] {
            "Single",
            "Daily",
            "Monthly",
            "Yearly",
            "All Records"});
            this.cmbDelete.Location = new System.Drawing.Point(155, 487);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(127, 21);
            this.cmbDelete.TabIndex = 4;
            // 
            // dateTimeDeleteRecords
            // 
            this.dateTimeDeleteRecords.Location = new System.Drawing.Point(293, 488);
            this.dateTimeDeleteRecords.Name = "dateTimeDeleteRecords";
            this.dateTimeDeleteRecords.Size = new System.Drawing.Size(205, 20);
            this.dateTimeDeleteRecords.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(513, 482);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(597, 483);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(682, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(870, 488);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(84, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Amount";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(980, 491);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(0, 16);
            this.lblTotalRecords.TabIndex = 11;
            // 
            // frmPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 521);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dateTimeDeleteRecords);
            this.Controls.Add(this.cmbDelete);
            this.Controls.Add(this.chkDeleteRecords);
            this.Controls.Add(this.PatientsdataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "frmPatientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PATENTS lIST";
            this.Load += new System.EventHandler(this.frmPatientList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblsearchby;
        private System.Windows.Forms.CheckBox checkAllRecords;
        private System.Windows.Forms.DataGridView PatientsdataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonthWise;
        private System.Windows.Forms.Label lblmonthwise;
        private System.Windows.Forms.Label lblreportmode;
        private System.Windows.Forms.CheckBox chkDeleteRecords;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.DateTimePicker dateTimeDeleteRecords;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.ComboBox cmbReportMode;
        private System.Windows.Forms.Label lblTotalRecords;
    }
}

