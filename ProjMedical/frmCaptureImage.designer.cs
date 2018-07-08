namespace FrmCaptureImage
{
    partial class frmCaptureImage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaptureImage));
            this.gAVIRecording = new System.Windows.Forms.GroupBox();
            this.lblDeleteVideo = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStillImages = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lablPatientName = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lablPatientID = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.checkCaptureAvi = new System.Windows.Forms.CheckBox();
            this.checkPlayCapturedAVI = new System.Windows.Forms.CheckBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.cmbAvis = new System.Windows.Forms.ComboBox();
            this.gPatient = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.rtfAddress = new System.Windows.Forms.RichTextBox();
            this.lblHue = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblBri = new System.Windows.Forms.Label();
            this.btnSetValues = new System.Windows.Forms.Button();
            this.HSHue = new System.Windows.Forms.HScrollBar();
            this.HSSaturation = new System.Windows.Forms.HScrollBar();
            this.HSContrast = new System.Windows.Forms.HScrollBar();
            this.HSBrightness = new System.Windows.Forms.HScrollBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAVIRecording = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnStillImage = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbInvDone = new System.Windows.Forms.ComboBox();
            this.cmbScanDone = new System.Windows.Forms.ComboBox();
            this.cmbRefDoc = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gFind = new System.Windows.Forms.GroupBox();
            this.lstPatient = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAVI = new System.Windows.Forms.PictureBox();
            this.panelPictures = new System.Windows.Forms.Panel();
            this.pictureList1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDeleteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            this.gAVIRecording.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gPatient.SuspendLayout();
            this.gFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAVI)).BeginInit();
            this.panelPictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureList1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // gAVIRecording
            // 
            this.gAVIRecording.Controls.Add(this.lblDeleteVideo);
            this.gAVIRecording.Controls.Add(this.lblPatientName);
            this.gAVIRecording.Controls.Add(this.panel1);
            this.gAVIRecording.Controls.Add(this.lablPatientName);
            this.gAVIRecording.Controls.Add(this.btnOpen);
            this.gAVIRecording.Controls.Add(this.btnDelete);
            this.gAVIRecording.Controls.Add(this.lablPatientID);
            this.gAVIRecording.Controls.Add(this.lblPatientID);
            this.gAVIRecording.Controls.Add(this.checkCaptureAvi);
            this.gAVIRecording.Controls.Add(this.checkPlayCapturedAVI);
            this.gAVIRecording.Controls.Add(this.btnDel);
            this.gAVIRecording.Controls.Add(this.cmbAvis);
            this.gAVIRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gAVIRecording.Location = new System.Drawing.Point(803, -3);
            this.gAVIRecording.Name = "gAVIRecording";
            this.gAVIRecording.Size = new System.Drawing.Size(408, 540);
            this.gAVIRecording.TabIndex = 0;
            this.gAVIRecording.TabStop = false;
            this.gAVIRecording.Text = "A V I Recording";
            // 
            // lblDeleteVideo
            // 
            this.lblDeleteVideo.AutoSize = true;
            this.lblDeleteVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteVideo.Location = new System.Drawing.Point(3, 200);
            this.lblDeleteVideo.Name = "lblDeleteVideo";
            this.lblDeleteVideo.Size = new System.Drawing.Size(134, 20);
            this.lblDeleteVideo.TabIndex = 16;
            this.lblDeleteVideo.Text = "Video to Delete";
            this.lblDeleteVideo.Visible = false;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(146, 240);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 20);
            this.lblPatientName.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnResume);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStillImages);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(10, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 181);
            this.panel1.TabIndex = 11;
            // 
            // btnStart
            // 
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(53, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 31);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Recording";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(201, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 31);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh Device";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(53, 70);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(127, 31);
            this.btnResume.TabIndex = 7;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(201, 70);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(126, 31);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop Recording";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStillImages
            // 
            this.btnStillImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStillImages.Location = new System.Drawing.Point(53, 129);
            this.btnStillImages.Name = "btnStillImages";
            this.btnStillImages.Size = new System.Drawing.Size(127, 31);
            this.btnStillImages.TabIndex = 8;
            this.btnStillImages.Text = "Still Images";
            this.btnStillImages.UseVisualStyleBackColor = true;
            this.btnStillImages.Click += new System.EventHandler(this.btnStillImages_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(201, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(126, 31);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lablPatientName
            // 
            this.lablPatientName.AutoSize = true;
            this.lablPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablPatientName.Location = new System.Drawing.Point(6, 241);
            this.lablPatientName.Name = "lablPatientName";
            this.lablPatientName.Size = new System.Drawing.Size(117, 20);
            this.lablPatientName.TabIndex = 9;
            this.lablPatientName.Text = "Patient Name";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(98, 157);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(127, 34);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(261, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lablPatientID
            // 
            this.lablPatientID.AutoSize = true;
            this.lablPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablPatientID.Location = new System.Drawing.Point(6, 130);
            this.lablPatientID.Name = "lablPatientID";
            this.lablPatientID.Size = new System.Drawing.Size(81, 18);
            this.lablPatientID.TabIndex = 5;
            this.lablPatientID.Text = "Patient ID";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.Crimson;
            this.lblPatientID.Location = new System.Drawing.Point(97, 130);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(81, 18);
            this.lblPatientID.TabIndex = 6;
            this.lblPatientID.Text = "Patient ID";
            // 
            // checkCaptureAvi
            // 
            this.checkCaptureAvi.AutoSize = true;
            this.checkCaptureAvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCaptureAvi.Location = new System.Drawing.Point(83, 54);
            this.checkCaptureAvi.Name = "checkCaptureAvi";
            this.checkCaptureAvi.Size = new System.Drawing.Size(127, 24);
            this.checkCaptureAvi.TabIndex = 3;
            this.checkCaptureAvi.Text = "Capture AVI";
            this.checkCaptureAvi.UseVisualStyleBackColor = true;
            this.checkCaptureAvi.CheckedChanged += new System.EventHandler(this.checkCaptureAvi_CheckedChanged);
            // 
            // checkPlayCapturedAVI
            // 
            this.checkPlayCapturedAVI.AutoSize = true;
            this.checkPlayCapturedAVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPlayCapturedAVI.Location = new System.Drawing.Point(83, 88);
            this.checkPlayCapturedAVI.Name = "checkPlayCapturedAVI";
            this.checkPlayCapturedAVI.Size = new System.Drawing.Size(175, 24);
            this.checkPlayCapturedAVI.TabIndex = 4;
            this.checkPlayCapturedAVI.Text = "Play Captured AVI";
            this.checkPlayCapturedAVI.UseVisualStyleBackColor = true;
            this.checkPlayCapturedAVI.CheckedChanged += new System.EventHandler(this.checkPlayCapturedAVI_CheckedChanged);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(340, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(51, 38);
            this.btnDel.TabIndex = 14;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbAvis
            // 
            this.cmbAvis.FormattingEnabled = true;
            this.cmbAvis.Items.AddRange(new object[] {
            "SelectPatientNmes",
            "Srilatha",
            "ggggg",
            "jjjjjj",
            "kkkkk",
            "llll",
            "pppp",
            ""});
            this.cmbAvis.Location = new System.Drawing.Point(142, 197);
            this.cmbAvis.Name = "cmbAvis";
            this.cmbAvis.Size = new System.Drawing.Size(248, 28);
            this.cmbAvis.TabIndex = 10;
            this.cmbAvis.Visible = false;
            // 
            // gPatient
            // 
            this.gPatient.Controls.Add(this.cmbGender);
            this.gPatient.Controls.Add(this.rtfAddress);
            this.gPatient.Controls.Add(this.lblHue);
            this.gPatient.Controls.Add(this.lblSat);
            this.gPatient.Controls.Add(this.lblCon);
            this.gPatient.Controls.Add(this.lblBri);
            this.gPatient.Controls.Add(this.btnSetValues);
            this.gPatient.Controls.Add(this.HSHue);
            this.gPatient.Controls.Add(this.HSSaturation);
            this.gPatient.Controls.Add(this.HSContrast);
            this.gPatient.Controls.Add(this.HSBrightness);
            this.gPatient.Controls.Add(this.label14);
            this.gPatient.Controls.Add(this.label13);
            this.gPatient.Controls.Add(this.label12);
            this.gPatient.Controls.Add(this.label11);
            this.gPatient.Controls.Add(this.btnClose);
            this.gPatient.Controls.Add(this.btnAVIRecording);
            this.gPatient.Controls.Add(this.btnProceed);
            this.gPatient.Controls.Add(this.btnReport);
            this.gPatient.Controls.Add(this.btnEdit);
            this.gPatient.Controls.Add(this.btnStillImage);
            this.gPatient.Controls.Add(this.btnPreview);
            this.gPatient.Controls.Add(this.btnNew);
            this.gPatient.Controls.Add(this.cmbInvDone);
            this.gPatient.Controls.Add(this.cmbScanDone);
            this.gPatient.Controls.Add(this.cmbRefDoc);
            this.gPatient.Controls.Add(this.txtAmount);
            this.gPatient.Controls.Add(this.label10);
            this.gPatient.Controls.Add(this.label9);
            this.gPatient.Controls.Add(this.label8);
            this.gPatient.Controls.Add(this.label7);
            this.gPatient.Controls.Add(this.label6);
            this.gPatient.Controls.Add(this.label5);
            this.gPatient.Controls.Add(this.txtAge);
            this.gPatient.Controls.Add(this.txtPName);
            this.gPatient.Controls.Add(this.txtPID);
            this.gPatient.Controls.Add(this.label4);
            this.gPatient.Controls.Add(this.label3);
            this.gPatient.Controls.Add(this.label1);
            this.gPatient.Location = new System.Drawing.Point(803, -2);
            this.gPatient.Name = "gPatient";
            this.gPatient.Size = new System.Drawing.Size(408, 540);
            this.gPatient.TabIndex = 13;
            this.gPatient.TabStop = false;
            this.gPatient.Enter += new System.EventHandler(this.gPatient_Enter);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGender.Location = new System.Drawing.Point(142, 96);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 7;
            // 
            // rtfAddress
            // 
            this.rtfAddress.Location = new System.Drawing.Point(142, 127);
            this.rtfAddress.Name = "rtfAddress";
            this.rtfAddress.Size = new System.Drawing.Size(235, 62);
            this.rtfAddress.TabIndex = 14;
            this.rtfAddress.Text = "";
            // 
            // lblHue
            // 
            this.lblHue.AutoSize = true;
            this.lblHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHue.Location = new System.Drawing.Point(385, 513);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(11, 16);
            this.lblHue.TabIndex = 38;
            this.lblHue.Text = " ";
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.Location = new System.Drawing.Point(386, 490);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(11, 16);
            this.lblSat.TabIndex = 37;
            this.lblSat.Text = " ";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(385, 466);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(11, 16);
            this.lblCon.TabIndex = 36;
            this.lblCon.Text = " ";
            // 
            // lblBri
            // 
            this.lblBri.AutoSize = true;
            this.lblBri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBri.Location = new System.Drawing.Point(385, 442);
            this.lblBri.Name = "lblBri";
            this.lblBri.Size = new System.Drawing.Size(11, 16);
            this.lblBri.TabIndex = 35;
            this.lblBri.Text = " ";
            // 
            // btnSetValues
            // 
            this.btnSetValues.Location = new System.Drawing.Point(266, 623);
            this.btnSetValues.Name = "btnSetValues";
            this.btnSetValues.Size = new System.Drawing.Size(106, 36);
            this.btnSetValues.TabIndex = 34;
            this.btnSetValues.Text = "Set Values";
            this.btnSetValues.UseVisualStyleBackColor = true;
            this.btnSetValues.Click += new System.EventHandler(this.btnSetValues_Click);
            // 
            // HSHue
            // 
            this.HSHue.Location = new System.Drawing.Point(120, 513);
            this.HSHue.Name = "HSHue";
            this.HSHue.Size = new System.Drawing.Size(257, 17);
            this.HSHue.TabIndex = 33;
            this.HSHue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSHue_Scroll);
            // 
            // HSSaturation
            // 
            this.HSSaturation.Location = new System.Drawing.Point(120, 488);
            this.HSSaturation.Name = "HSSaturation";
            this.HSSaturation.Size = new System.Drawing.Size(257, 17);
            this.HSSaturation.TabIndex = 32;
            this.HSSaturation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSSaturation_Scroll);
            // 
            // HSContrast
            // 
            this.HSContrast.Location = new System.Drawing.Point(120, 464);
            this.HSContrast.Name = "HSContrast";
            this.HSContrast.Size = new System.Drawing.Size(257, 17);
            this.HSContrast.TabIndex = 31;
            this.HSContrast.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSContrast_Scroll);
            // 
            // HSBrightness
            // 
            this.HSBrightness.Location = new System.Drawing.Point(120, 440);
            this.HSBrightness.Name = "HSBrightness";
            this.HSBrightness.Size = new System.Drawing.Size(257, 17);
            this.HSBrightness.TabIndex = 30;
            this.HSBrightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSBrightness_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 514);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Hue";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 488);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Saturation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Contrast";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Brightness";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(240, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 36);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAVIRecording
            // 
            this.btnAVIRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAVIRecording.Location = new System.Drawing.Point(39, 397);
            this.btnAVIRecording.Name = "btnAVIRecording";
            this.btnAVIRecording.Size = new System.Drawing.Size(193, 36);
            this.btnAVIRecording.TabIndex = 24;
            this.btnAVIRecording.Text = "A V I Recording";
            this.btnAVIRecording.UseVisualStyleBackColor = true;
            this.btnAVIRecording.Click += new System.EventHandler(this.btnAVIRecording_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.Location = new System.Drawing.Point(240, 359);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(137, 36);
            this.btnProceed.TabIndex = 23;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(120, 358);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(108, 36);
            this.btnReport.TabIndex = 22;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(39, 359);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 36);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStillImage
            // 
            this.btnStillImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStillImage.Location = new System.Drawing.Point(240, 319);
            this.btnStillImage.Name = "btnStillImage";
            this.btnStillImage.Size = new System.Drawing.Size(137, 36);
            this.btnStillImage.TabIndex = 20;
            this.btnStillImage.Text = "Still Image";
            this.btnStillImage.UseVisualStyleBackColor = true;
            this.btnStillImage.Click += new System.EventHandler(this.btnStillImage_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(122, 319);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(108, 36);
            this.btnPreview.TabIndex = 19;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(38, 319);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 36);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cmbInvDone
            // 
            this.cmbInvDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvDone.FormattingEnabled = true;
            this.cmbInvDone.Location = new System.Drawing.Point(144, 228);
            this.cmbInvDone.Name = "cmbInvDone";
            this.cmbInvDone.Size = new System.Drawing.Size(201, 24);
            this.cmbInvDone.TabIndex = 17;
            // 
            // cmbScanDone
            // 
            this.cmbScanDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbScanDone.FormattingEnabled = true;
            this.cmbScanDone.Location = new System.Drawing.Point(145, 259);
            this.cmbScanDone.Name = "cmbScanDone";
            this.cmbScanDone.Size = new System.Drawing.Size(203, 24);
            this.cmbScanDone.TabIndex = 16;
            // 
            // cmbRefDoc
            // 
            this.cmbRefDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRefDoc.FormattingEnabled = true;
            this.cmbRefDoc.Location = new System.Drawing.Point(144, 197);
            this.cmbRefDoc.Name = "cmbRefDoc";
            this.cmbRefDoc.Size = new System.Drawing.Size(201, 24);
            this.cmbRefDoc.TabIndex = 15;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(145, 290);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(203, 22);
            this.txtAmount.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Amount (Rs)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Done By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Investigation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ref By";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(142, 67);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 5;
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(142, 40);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(248, 22);
            this.txtPName.TabIndex = 4;
            // 
            // txtPID
            // 
            this.txtPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.Location = new System.Drawing.Point(142, 13);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(161, 22);
            this.txtPID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // gFind
            // 
            this.gFind.Controls.Add(this.lstPatient);
            this.gFind.Controls.Add(this.btnExit);
            this.gFind.Controls.Add(this.btnFind);
            this.gFind.Controls.Add(this.dateTimePicker1);
            this.gFind.Location = new System.Drawing.Point(802, -3);
            this.gFind.Name = "gFind";
            this.gFind.Size = new System.Drawing.Size(408, 540);
            this.gFind.TabIndex = 4;
            this.gFind.TabStop = false;
            // 
            // lstPatient
            // 
            this.lstPatient.Location = new System.Drawing.Point(19, 50);
            this.lstPatient.MultiSelect = false;
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(376, 463);
            this.lstPatient.TabIndex = 3;
            this.lstPatient.UseCompatibleStateImageBehavior = false;
            this.lstPatient.SelectedIndexChanged += new System.EventHandler(this.lstPatient_SelectedIndexChanged);
            this.lstPatient.DoubleClick += new System.EventHandler(this.lstPatient_DoubleClick_1);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(300, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(237, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(55, 33);
            this.btnFind.TabIndex = 1;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 508);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // picAVI
            // 
            this.picAVI.Location = new System.Drawing.Point(13, 12);
            this.picAVI.Name = "picAVI";
            this.picAVI.Size = new System.Drawing.Size(770, 509);
            this.picAVI.TabIndex = 6;
            this.picAVI.TabStop = false;
            // 
            // panelPictures
            // 
            this.panelPictures.AutoScroll = true;
            this.panelPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPictures.Controls.Add(this.pictureList1);
            this.panelPictures.Location = new System.Drawing.Point(15, 542);
            this.panelPictures.Name = "panelPictures";
            this.panelPictures.Size = new System.Drawing.Size(1195, 100);
            this.panelPictures.TabIndex = 15;
            // 
            // pictureList1
            // 
            this.pictureList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureList1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureList1.Location = new System.Drawing.Point(0, 4);
            this.pictureList1.Name = "pictureList1";
            this.pictureList1.Size = new System.Drawing.Size(100, 93);
            this.pictureList1.TabIndex = 0;
            this.pictureList1.TabStop = false;
            this.pictureList1.Visible = false;
            this.pictureList1.Click += new System.EventHandler(this.pictureList1_Click);
            this.pictureList1.DoubleClick += new System.EventHandler(this.pictureList1_DoubleClick);
            this.pictureList1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureList1_MouseClick);
            this.pictureList1.MouseLeave += new System.EventHandler(this.pictureList1_MouseLeave);
            this.pictureList1.MouseHover += new System.EventHandler(this.pictureList1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteImageToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripDeleteImage,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 120);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteImageToolStripMenuItem
            // 
            this.deleteImageToolStripMenuItem.Name = "deleteImageToolStripMenuItem";
            this.deleteImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.deleteImageToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteImageToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem1.Text = "Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // toolStripDeleteImage
            // 
            this.toolStripDeleteImage.Name = "toolStripDeleteImage";
            this.toolStripDeleteImage.Size = new System.Drawing.Size(157, 22);
            this.toolStripDeleteImage.Text = "Delete Image";
            this.toolStripDeleteImage.Click += new System.EventHandler(this.toolStripDeleteImage_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem3.Text = "Images Send To";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(15, 12);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(768, 508);
            this.axVideoCap1.TabIndex = 7;
            // 
            // frmCaptureImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 645);
            this.Controls.Add(this.gAVIRecording);
            this.Controls.Add(this.panelPictures);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.picAVI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gFind);
            this.Controls.Add(this.gPatient);
            this.Name = "frmCaptureImage";
            this.Text = "CAPTURE IMAGE";
            this.Load += new System.EventHandler(this.frmCaptureImage_Load);
            this.gAVIRecording.ResumeLayout(false);
            this.gAVIRecording.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gPatient.ResumeLayout(false);
            this.gPatient.PerformLayout();
            this.gFind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAVI)).EndInit();
            this.panelPictures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureList1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gAVIRecording;
        private System.Windows.Forms.ComboBox cmbAvis;
        private System.Windows.Forms.Label lablPatientName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lablPatientID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.CheckBox checkCaptureAvi;
        private System.Windows.Forms.CheckBox checkPlayCapturedAVI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStillImages;
        private System.Windows.Forms.Button btnPause;

        private System.Windows.Forms.GroupBox gPatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSetValues;
        private System.Windows.Forms.HScrollBar HSHue;
        private System.Windows.Forms.HScrollBar HSSaturation;
        private System.Windows.Forms.HScrollBar HSContrast;
        private System.Windows.Forms.HScrollBar HSBrightness;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAVIRecording;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnStillImage;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbInvDone;
        private System.Windows.Forms.ComboBox cmbScanDone;
        private System.Windows.Forms.ComboBox cmbRefDoc;
        private System.Windows.Forms.RichTextBox rtfAddress;
        private System.Windows.Forms.Label lblHue;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblBri;
        private System.Windows.Forms.Button btnDel;

        private System.Windows.Forms.Label lblPatientName;

        private System.Windows.Forms.GroupBox gFind;
        private System.Windows.Forms.ListView lstPatient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picAVI;
        public AxVIDEOCAPLib.AxVideoCap axVideoCap1;
        private System.Windows.Forms.Panel panelPictures;
        private System.Windows.Forms.PictureBox pictureList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteImage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label lblDeleteVideo;
        private System.Windows.Forms.Timer timer1;
    }
}

