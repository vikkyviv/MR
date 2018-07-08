using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Data.OleDb;
using ProjMedical;
using System.Windows.Forms;

namespace FrmCaptureImage
{
    public partial class frmCaptureImage : Form
    {
        public frmCaptureImage()
        {
            InitializeComponent();
            GlobalVariables.CreateIfMissing(sPath);
            GlobalVariables.CreateIfMissing(imgPath);
            GlobalVariables.CreateIfMissing(tempImgagePath);
            GlobalVariables.CreateIfMissing(vPath);

        }



        bool bPlayAVI;
        string sPath = Path.GetFullPath(@"..\\..\\Reports");
        string imgPath = Path.GetFullPath(@"..\\..\\Images\\");
        string tempImgagePath = Path.GetFullPath(@"..\\..\\TempImages\\");
        string vPath = Path.GetFullPath(@"..\\..\\Videos\\");
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
        string sQuery = "";
        string PatientID = "";
        int c;
        int d;
        int iRecordCount;
        int ImgWidth = 0;

        public void ControlCap()
        {
            this.axVideoCap1.Device = 0;
            this.axVideoCap1.VideoInput = -1;
            this.axVideoCap1.VideoFormat = 0;
            this.axVideoCap1.AudioDevice = 0;
            this.axVideoCap1.AudioInputPin = 0;
            this.axVideoCap1.VideoCompressor = 9;
            this.axVideoCap1.AudioCompressor = 3;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            ControlCap();
            string videoPath = Path.GetFullPath(@"..\\..\\Videos\\1.avi");
            //this.axVideoCap1.VideoStandard = 0;
            //this.axVideoCap1.AudioInputPin = 0;
            //this.axVideoCap1.CaptureVideo = true;
            //this.axVideoCap1.CaptureAudio = true;
            //this.axVideoCap1.ShowPreview = true;
            //this.axVideoCap1.UseVideoCompressor = true;
            //this.axVideoCap1.UseAudioCompressor = true;
            //this.axVideoCap1.CaptureMode = true;
            //this.axVideoCap1.CaptureFileName = videoPath;
            //this.axVideoCap1.SyncMode = 1;
            //this.axVideoCap1.SyncStreamOffset = 1;
            //this.axVideoCap1.VideoInput = -1;
            //this.axVideoCap1.VideoFormat = 0;

            this.axVideoCap1.CaptureVideo = true;
            this.axVideoCap1.CaptureAudio = true;

            this.axVideoCap1.ShowPreview = true;
            this.axVideoCap1.UseVideoCompressor = true;
            this.axVideoCap1.UseAudioCompressor = true;

            this.axVideoCap1.CaptureMode = true;
            this.axVideoCap1.CaptureFileName = videoPath;

            this.axVideoCap1.SyncMode = 1;

            //short result = this.axVideoCap1.Start();


            this.axVideoCap1.VideoInput = -1;
            this.axVideoCap1.VideoFormat = 0;
            this.axVideoCap1.Start();

            /*
            if (result == -1)
            {
                MessageBox.Show("Capture Failure,Video, Audio Compressor not correct or capture file opening");
                return;
            }

            if (result == -2)
            {
                MessageBox.Show("Capture file not found");
            }
            */
        }

        private void btnStillImage_Click(object sender, EventArgs e)
        {
            bPlayAVI = false;
            pictureList1.Visible = true;
            SaveImage();
            // string strFileName = Application.StartupPath + "\\test.bmp";
            // this.axVideoCap1.SnapShot(strFileName);   // to save 
            // this.picImages.Load(strFileName);         // to load
        }

        public void SaveImage()
        {
            try
            {
                if (c >= 29)
                {
                    MessageBox.Show("Maximum you can capture 29 Images.");
                    return;
                }

                c = c + 1;

                if (txtPName.Text != "" && cmbInvDone.Text != "")
                {
                    UpdateRecord();
                }

                string sFileExtension = ".jpeg";
                string sFileName = "Image" + c + sFileExtension;
                string sFilePath = imgPath + sFileName;
                string sFP = tempImgagePath + GlobalVariables.PIDD + "\\Image" + c + sFileExtension;

                if (bPlayAVI == true)
                {
                    pictureBox1.Image.Save(sFilePath);
                }
                else
                {
                    this.axVideoCap1.SnapShot(sFP);
                }


                if (c == 1)
                {
                   // foreach (Control ctrl in this.panelPictures.Controls)
                   // {
                        if  (this.panelPictures.Controls.Count == 1)
                        {
                            pictureList1.Visible = true;
                            //pictureList1.Image = Image.FromFile(sFP);
                            FileStream fs = new FileStream(sFP, FileMode.Open, FileAccess.Read);
                            Image img = Image.FromStream(fs);
                            fs.Close();
                            pictureList1.Image = img.Clone() as Image;
                            img.Dispose();

                            pictureList1.SizeMode = PictureBoxSizeMode.StretchImage;

                        }
                        else if (this.panelPictures.Controls.Count == 0)
                        {
                            ImgWidth = 0;

                            FileStream fs = new FileStream(sFP, FileMode.Open, FileAccess.Read);
                            Image img = Image.FromStream(fs);
                            fs.Close();

                            var picture = new PictureBox
                            {
                                Name = "pictureList" + c,
                                Size = new Size(100, 93),
                                Location = new Point(ImgWidth, 4),
                                Image = img.Clone() as Image,
                                SizeMode = PictureBoxSizeMode.StretchImage
                            };
                            img.Dispose();
                            picture.Click += new EventHandler(m_pictureBox_Click);
                            picture.DoubleClick += new EventHandler(m_pictureBox_DoubleClick);
                            picture.MouseLeave += new EventHandler(m_pictureList_MouseLeave);
                            picture.ContextMenuStrip = contextMenuStrip1;
                            this.panelPictures.Controls.Add(picture);
                        }
                    //}
                }
                else
                {
                    ImgWidth = ImgWidth + 101;
                    FileStream fs = new FileStream(sFP, FileMode.Open, FileAccess.Read);
                    Image img = Image.FromStream(fs);
                    fs.Close();

                    var picture = new PictureBox
                    {
                        Name = "pictureList" + c,
                        Size = new Size(100, 93),
                        Location = new Point(ImgWidth, 4),
                        Image = img.Clone() as Image,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    img.Dispose();
                    picture.Click += new EventHandler(m_pictureBox_Click);
                    picture.DoubleClick += new EventHandler(m_pictureBox_DoubleClick);
                    picture.MouseLeave += new EventHandler(m_pictureList_MouseLeave);
                    picture.ContextMenuStrip = contextMenuStrip1;
                    this.panelPictures.Controls.Add(picture);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void m_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pb = (PictureBox)sender;
                string iControlIndex = pb.Name.Substring(11);
                string stePath = Path.GetFullPath(@"..\\..\\Images\\Image" + iControlIndex + ".jpeg");
                if (File.Exists(stePath))
                {
                    if (File.Exists(stePath))
                    {
                        File.Delete(stePath);
                    }
                }
            }
        }


        private void m_pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is PictureBox)
                {
                    PictureBox pb = (PictureBox)sender;
                    pb.Tag = Color.Red;
                    pb.BackColor = Color.Red;
                    pb.Padding = new System.Windows.Forms.Padding(3);
                    pb.Refresh();
                    string iControlIndex = pb.Name.Substring(11);
                    string stPath = Path.GetFullPath(@"..\\..\\TempImages\\" + GlobalVariables.PIDD + "\\Image" + iControlIndex + ".jpeg");
                    frmDisplay picturePopUp = new frmDisplay(stPath);
                    picturePopUp.Show();

                    string stePath = Path.GetFullPath(@"..\\..\\Images\\Image" + iControlIndex + ".jpeg");
                    if (File.Exists(stePath))
                    {
                        File.Delete(stePath);
                    }

                    File.Copy(@stPath, @stePath,true);
                    //pb.Image.Save(stePath);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateRecord()
        {
            if (txtAmount.Text == "")
            {
                txtAmount.Text = "0";
            }

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select count(*) from PatientDetails Where PatientID = '" + txtPID.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                iRecordCount = (int)cmd.ExecuteScalar();

                if (iRecordCount > 0)
                {
                    sQuery = "Update PatientDetails SET PatientName=@PatientName, Address=@Address,  Sex=@Sex, RefDoc=@RefDoc, InvName=@InvName, InvDone=@InvDone, Amount=@Amount, PDate = @PDate, Age = @Age, VisitNo = @VisitNo WHERE PatientID=@PatientID";
                }
                else if (iRecordCount == 0)
                {
                    sQuery = "INSERT INTO PatientDetails (PatientID, PatientName, Address,  Sex, RefDoc, InvName, InvDone, Amount, PDate, Age, VisitNo) VALUES (@PatientID, @PatientName, @Address,  @Sex, @RefDoc, @InvName, @InvDone, @Amount, @PDate, @Age, @VisitNo)";
                }

                DateTime thisDay = DateTime.Today;
                var formattedDate = $"{thisDay:dd-MM-yyyy}";
                string Gender = "";
                if (cmbGender.Text == "Male")
                {
                    Gender = "M";
                }
                else if (cmbGender.Text == "Female")
                {
                    Gender = "F";
                }
                OleDbCommand command = new OleDbCommand(sQuery, con);

                command.Parameters.AddWithValue("@PatientID", txtPID.Text.ToString());
                command.Parameters.AddWithValue("@PatientName", txtPName.Text.ToString());
                command.Parameters.AddWithValue("@Address", rtfAddress.Text);
                command.Parameters.AddWithValue("@Sex", Gender.ToString());
                command.Parameters.AddWithValue("@RefDoc", cmbRefDoc.Text);
                command.Parameters.AddWithValue("@InvName", cmbInvDone.Text);
                command.Parameters.AddWithValue("@InvDone", cmbScanDone.Text);
                command.Parameters.AddWithValue("@Amount", txtAmount.Text);
                command.Parameters.AddWithValue("@PDate", formattedDate);
                command.Parameters.AddWithValue("@Age", txtAge.Text);
                command.Parameters.AddWithValue("@VisitNo", 0);

                command.ExecuteNonQuery();
            }


        }
        private void frmCaptureImage_Load(object sender, EventArgs e)
        {
            gPatient.Visible = true;
            gPatient.BringToFront();
            pictureBox1.Visible = true;
            axVideoCap1.Visible = true;
            pictureList1.Visible = false;
            btnNew.Enabled = true;
            btnStillImage.Enabled = false;
            btnProceed.Enabled = false;
            btnReport.Enabled = false;
            c = 0;
            d = 0;

            // axVideoCap1.CaptureMode = true;
            //axVideoCap1.UseMp4EncoderPlugin = true;
            //axVideoCap1.Mp4Videobitrate = Convert.ToInt32(txtmp4videobitrate.Text);
            //axVideoCap1.Mp4Audiobitrate = Convert.ToInt32(txtmp4audiobitrate.Text);
            //axVideoCap1.Mp4AudioSamplerate = Convert.ToInt32(cboaudiosamplerate.Text);
            //axVideoCap1.Mp4Audiochannel = (short)Convert.ToInt32(txtaudiochannels.Text);
            //axVideoCap1.Mp4Width = (short)Convert.ToInt32(txtmp4width.Text);
            //axVideoCap1.Mp4Height = (short)Convert.ToInt32(txtmp4height.Text);
            //axVideoCap1.CaptureMode = true;
            //axVideoCap1.CaptureFileName = 
            this.axVideoCap1.VideoInput = -1;
            this.axVideoCap1.VideoFormat = 0;
            this.axVideoCap1.Start();

            HSBrightness.Minimum = axVideoCap1.Brightness.Min;
            HSBrightness.Maximum = axVideoCap1.Brightness.Max;
            HSBrightness.LargeChange = 10;
            HSBrightness.SmallChange = 5;
            HSBrightness.Value = axVideoCap1.Brightness.Value;
            lblBri.Text = HSBrightness.Value.ToString();

            HSContrast.Minimum = axVideoCap1.Contrast.Min;
            HSContrast.Maximum = axVideoCap1.Contrast.Max;
            HSContrast.LargeChange = 10;
            HSContrast.SmallChange = 5;
            HSContrast.Value = axVideoCap1.Contrast.Value;
            lblCon.Text = HSContrast.Value.ToString();

            HSSaturation.Minimum = axVideoCap1.Saturation.Min;
            HSSaturation.Maximum = axVideoCap1.Saturation.Max;
            HSSaturation.LargeChange = 10;
            HSSaturation.SmallChange = 5;
            HSSaturation.Value = axVideoCap1.Saturation.Value;
            lblSat.Text = HSSaturation.Value.ToString();

            HSHue.Minimum = axVideoCap1.Hue.Min;
            HSHue.Maximum = axVideoCap1.Hue.Max;
            HSHue.LargeChange = 10;
            HSHue.SmallChange = 5;
            HSHue.Value = axVideoCap1.Hue.Value;
            lblHue.Text = HSHue.Value.ToString();

            axVideoCap1.LicenseKey = "6102 single developer license";

            /*
            HScroll.Value = 0;
            HScroll.Minimum = 0;
            HScroll.Maximum = 11895 + 10000;
            HScroll.SmallChange = Screen.PrimaryScreen.BitsPerPixel * 300;
            HScroll.LargeChange = 1000;
            */
        }

        private void btnSetValues_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select count(*) From VideoProperties";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                iRecordCount = (int)cmd.ExecuteScalar();

                if (iRecordCount > 0)
                {
                    sQuery = "delete * from VideoProperties";
                    OleDbCommand cmd1 = new OleDbCommand(sQuery, con);
                    cmd1.ExecuteNonQuery();
                }
                else if (iRecordCount == 1)
                {
                    sQuery = "INSERT INTO VideoProperties (Brightness, Contrast, Saturation, HueBrightness) VALUES (" + HSBrightness.Value + "," + HSContrast.Value + "," + HSSaturation.Value + "," + HSHue.Value + ")";
                    OleDbCommand cmd1 = new OleDbCommand(sQuery, con);
                    cmd1.ExecuteNonQuery();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //gPatient.Visible = false;
            GlobalVariables.bReported = false;
            cmbInvDone.Items.Clear();
            cmbRefDoc.Items.Clear();
            cmbScanDone.Items.Clear();
            string[] arrFileNames = Directory.GetFiles(sPath);

            for (int i = 0; i < arrFileNames.Length; i++)
            {
                arrFileNames[i] = Path.GetFileNameWithoutExtension(arrFileNames[i]);
            }

            cmbInvDone.DataSource = arrFileNames;

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select DocType From ReferalDoc";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == "Referal Doctor")
                    {
                        cmbRefDoc.Items.Add(reader[0].ToString());
                    }

                    if (reader[0].ToString() == "Consultant Doctor")
                    {
                        cmbScanDone.Items.Add(reader[0].ToString());
                    }
                }

            }

            Clear();
            AutoGeneratePID();

            string tempImagePath = Path.GetFullPath(@"..\\..\\TempImages");
            DeleteFiles(tempImagePath);

            string imagePath = Path.GetFullPath(@"..\\..\\Images");
            DeleteFiles(imagePath);

            string dumpPath = Path.GetFullPath(@"..\\..\\Reports\\Dump");
            DeleteFiles(dumpPath);

            GlobalVariables.PIDD = txtPID.Text;

            if (!Directory.Exists(Path.GetFullPath(@"..\\..\\TempImages\\" + GlobalVariables.PIDD)))
            {
                Directory.CreateDirectory(Path.GetFullPath(@"..\\..\\TempImages\\" + GlobalVariables.PIDD));
            }

            btnNew.Enabled = false;
            btnStillImage.Enabled = true;
            btnProceed.Enabled = true;
            btnAVIRecording.Enabled = true;
            btnReport.Enabled = true;
        }

        public void AutoGeneratePID()
        {
            int iPatientID = 0;
            string sPatientID = "";
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select PatientID From PatientDetails Order by PDate DESC";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    iPatientID = Convert.ToInt32(reader[0].ToString().Substring(11));
                    iPatientID = iPatientID + 1;
                }
                else
                {
                    iPatientID = 1;
                }

                DateTime thisDay = DateTime.Today;
                var formattedDate = $"{thisDay:dd-MM-yyyy}";
                sPatientID = formattedDate + "-" + iPatientID;
                GlobalVariables.PIDD = sPatientID;
            }

            txtPID.Text = sPatientID;
            txtPID.ReadOnly = true;
            txtPName.Focus();
        }

        public void DeleteFiles(string dPath)
        {
            try
            {
                if (Directory.Exists(dPath))
                {

                    //Delete all files from the Directory
                    foreach (string file in Directory.GetFiles(dPath))
                    {
                        File.Delete(file);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = string.Empty;
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.VideoStandard = 0;
            this.axVideoCap1.AudioInputPin = 0;
            this.axVideoCap1.SyncMode = 1;
            this.axVideoCap1.SyncStreamOffset = 1;
            this.axVideoCap1.VideoInput = -1;
            this.axVideoCap1.VideoFormat = 0;
            this.axVideoCap1.Start();

        }

        private void HSBrightness_Scroll(object sender, ScrollEventArgs e)
        {
            axVideoCap1.Brightness.Value = HSBrightness.Value;
            lblBri.Text = axVideoCap1.Brightness.Value.ToString();
        }

        private void HSContrast_Scroll(object sender, ScrollEventArgs e)
        {
            axVideoCap1.Contrast.Value = HSContrast.Value;
            lblCon.Text = axVideoCap1.Contrast.Value.ToString();
        }

        private void HSSaturation_Scroll(object sender, ScrollEventArgs e)
        {
            axVideoCap1.Saturation.Value = HSSaturation.Value;
            lblSat.Text = axVideoCap1.Saturation.Value.ToString();
        }

        private void HSHue_Scroll(object sender, ScrollEventArgs e)
        {
            axVideoCap1.Hue.Value = HSHue.Value;
            lblHue.Text = axVideoCap1.Hue.Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            gPatient.Visible = true;
            gPatient.BringToFront();
            pictureBox1.Visible = true;
            axVideoCap1.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAVIRecording_Click(object sender, EventArgs e)
        {
            if (txtPID.Text == "")
            {
                MessageBox.Show("Click On New command button");
                btnNew.Focus();
                return;
            }

            if (txtPName.Text == "")
            {
                MessageBox.Show("Patient Name can't be empty ");
                txtPName.Focus();
                return;
            }

            //axVideoCap1.Stop();
            gPatient.Visible = false;
            //gPatient.SendToBack();
            gAVIRecording.Visible = true;
            gAVIRecording.BringToFront();

            lblPatientID.Text = txtPID.Text;
            lblPatientName.Text = txtPName.Text;

            checkCaptureAvi.Checked = true;
            // btnDeleteAvi.Enabled = false;
            bPlayAVI = false;


        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axVideoCap1.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axVideoCap1.Stop();
            axVideoCap1.CaptureMode = false;
            axVideoCap1.ShowPreview = true;
            axVideoCap1.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select * From VideoDeviceSettings";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    axVideoCap1.Refresh();
                    // axVideoCap1.Device = Convert.ToInt32(reader[0]));
                    // axVideoCap1.VideoInput = Convert.ToInt32(reader[0]);
                    //axVideoCap1.VideoStandard = reader[0].ToString();
                    //axVideoCap1.VideoFormat = reader[0].ToString();
                    //axVideoCap1.VideoCompressor = reader[0].ToString();


                }

            }
        }

        private void btnStillImages_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            axVideoCap1.Resume();
        }

        private void checkCaptureAvi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCaptureAvi.Checked == true)
            {
                btnStart.Enabled = true;
                //CapAVI = true;
                checkPlayCapturedAVI.Checked = false;
                btnStop.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                btnStart.Enabled = false;
                //CapAVI = false;
                btnStop.Enabled = false;
                btnDelete.Enabled = true;
            }
        }

        private void checkPlayCapturedAVI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPlayCapturedAVI.Checked == true)
            {
                axVideoCap1.Visible = false;
                cmbAvis.Visible = true;
                lblDeleteVideo.Visible = true;
                LoadAvis();
                pictureBox1.Visible = true;
                //PlayAVI = true;
                checkCaptureAvi.Checked = false;
                cmbAvis.Focus();
                picAVI.Visible = true;

            }
            else
            {
                axVideoCap1.Visible = true;
                pictureBox1.Visible = false;
                cmbAvis.Visible = false;
                lblDeleteVideo.Visible = false;
                //PlayAVI = falsek;
                btnDelete.Enabled = false;
                picAVI.Visible = false;


            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtPName.Text.Length == 0)
            {
                MessageBox.Show("Patient Name cannot be Empty");
                txtPName.Focus();
                return;
            }

            if (cmbInvDone.Text.Length == 0)
            {
                MessageBox.Show("Investigation Done  cannot be Empty");
                cmbInvDone.Focus();
                return;
            }

            btnProceed.Enabled = false;
            UpdateRecord();

            GlobalVariables.PIDD = txtPID.Text;
            GlobalVariables.PatientName = txtPName.Text;
            int x = 0;

            Int32.TryParse(txtAge.Text, out x);

            GlobalVariables.Age = x;
            GlobalVariables.InvDone = cmbInvDone.Text;
            GlobalVariables.RefByDoc = cmbRefDoc.Text;
            GlobalVariables.bImageCheck = false;
            GlobalVariables.VisitNo = 0;

            //frmCaptureImage frmCapture = new frmCaptureImage();
            //frmCapture.Hide();

            btnNew.Enabled = true;
            this.Hide();

            frmReportSelection reportselection = new frmReportSelection();
            reportselection.Dock = DockStyle.Fill;
            reportselection.MdiParent = this.MdiParent;
            reportselection.ClientSize = new System.Drawing.Size(2000, 800);
            reportselection.WindowState = FormWindowState.Maximized;
            reportselection.FormBorderStyle = FormBorderStyle.None;
            reportselection.ControlBox = false;
            reportselection.MaximizeBox = false;
            reportselection.MinimizeBox = false;
            reportselection.ShowIcon = false;
            reportselection.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbAvis.Text == "")
            {
                MessageBox.Show("Select a file from combo to delete");
                return;
            }
            else
            {

                DialogResult dr = MessageBox.Show("Are you sure to delete the file " + cmbAvis.Text, "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    string deletePath = Path.GetFullPath(@"..\\..\\Videos\\" + cmbAvis.Text + ".avi");
                    if (File.Exists(deletePath))
                    {
                        File.Delete(deletePath);
                    }
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }
            }
            LoadAvis();
        }

        public void LoadAvis()
        {
            string displayPath = Path.GetFullPath(@"..\\..\\Videos");
            cmbAvis.DataSource = null;
            cmbAvis.DataBindings.Clear();
            cmbAvis.Items.Clear();

            string[] arrFileNames = Directory.GetFiles(displayPath, "*.avi");

            for (int i = 0; i < arrFileNames.Length; i++)
            {
                arrFileNames[i] = Path.GetFileNameWithoutExtension(arrFileNames[i]);
            }

            cmbAvis.DataSource = arrFileNames;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gFind.Visible = true;
            gFind.BringToFront();
            // gPatient.Visible = false;
            // gAVIRecording.Visible = false;
            lstPatient.View = View.Details;
            lstPatient.GridLines = true;
            lstPatient.FullRowSelect = true;

            lstPatient.Columns.Add("Patient Name", 150, HorizontalAlignment.Left);
            lstPatient.Columns.Add("Patient ID", 100, HorizontalAlignment.Left);
            lstPatient.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lstPatient.Columns.Add("Age", 75, HorizontalAlignment.Right);
            lstPatient.Columns.Add("Sex", 75, HorizontalAlignment.Left);
            lstPatient.Columns.Add("RefDoctor", 150, HorizontalAlignment.Left);

            lstPatient.Items.Clear();

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select PatientName, PatientId,PDate,Sex,Age,RefDoc From PatientDetails";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem obj = new ListViewItem(Convert.ToString(reader[0]), Convert.ToString(reader[0]));

                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader[0].ToString();
                    lvItem.SubItems.Add(reader[1].ToString());
                    lvItem.SubItems.Add(Convert.ToDateTime(reader[2]).ToString("dd/MM/yyyy"));
                    lvItem.SubItems.Add(reader[3].ToString());
                    lvItem.SubItems.Add(reader[4].ToString());
                    lvItem.SubItems.Add(reader[5].ToString());

                    lstPatient.Items.Add(lvItem);
                }

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cmbInvDone.Text == "")
            {
                MessageBox.Show("You must select Investigation");
                return;
            }
            GlobalVariables.bSimReport = true;
            GlobalVariables.sInvestigationReport = cmbInvDone.Text;
            frmTempReport tempReport = new frmTempReport();
            tempReport.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            gFind.Visible = false;
            gPatient.BringToFront();
            btnStillImage.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                var sPatientName = Microsoft.VisualBasic.Interaction.InputBox("Find in Patient Name");
                var itm = lstPatient.FindItemWithText(sPatientName);
                if (sPatientName != "")
                {
                    foreach (ListViewItem item in lstPatient.Items)
                    {
                        if (item.Text.ToLower().Contains(sPatientName.ToLower()))
                        {
                            item.Selected = true;
                            item.BackColor = Color.CornflowerBlue;
                            item.ForeColor = Color.White;
                        }
                        else
                        {
                            item.Selected = false;
                            //item.BackColor = Color.White;
                            //item.ForeColor = Color.Black;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Patient Name to Find");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lstPatient.Items.Clear();
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select PatientName, PatientId, PDate, Sex, Age, RefDoc From PatientDetails Where CDate(PDate) = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem obj = new ListViewItem(Convert.ToString(reader[0]), Convert.ToString(reader[0]));

                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader[0].ToString();
                    lvItem.SubItems.Add(reader[1].ToString());
                    lvItem.SubItems.Add(Convert.ToDateTime(reader[2]).ToString("dd/MM/yyyy"));
                    lvItem.SubItems.Add(reader[3].ToString());
                    lvItem.SubItems.Add(reader[4].ToString());
                    lvItem.SubItems.Add(reader[5].ToString());

                    lstPatient.Items.Add(lvItem);
                }

            }
        }




        private void lstPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPatient.SelectedItems.Count != 0)
            {
                // DisplayPatientDetails();
                GlobalVariables.bReported = true;
                btnStillImage.Enabled = true;
            }
        }

        public void DisplayPatientDetails()
        {
            try
            {
                if (lstPatient.Items.Count == 0)
                {
                    MessageBox.Show("No Patient Records in List ");
                    return;
                }

                if (lstPatient.Items.Count > 0)
                {
                    using (OleDbConnection con = new OleDbConnection(connection))
                    {
                        sQuery = "Select * From PatientDetails Where PatientID ='" + lstPatient.SelectedItems[0].SubItems[1].Text + "'";
                        OleDbCommand cmd = new OleDbCommand(sQuery, con);
                        con.Open();
                        cmd.CommandType = CommandType.Text;
                        OleDbDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtPID.Text = reader["PatientId"].ToString();
                            PatientID = reader["PatientId"].ToString();
                            GlobalVariables.PIDD = PatientID;
                            txtPName.Text = reader["PatientName"].ToString();
                            txtAge.Text = reader["Age"].ToString();
                            if (reader["Sex"].ToString() == "M")
                            {
                                cmbGender.Text = "Male";
                            }
                            else if (reader["Sex"].ToString() == "F")
                            {
                                cmbGender.Text = "Female";
                            }

                            if (reader["Address"].ToString() != "")
                            {
                                rtfAddress.Text = reader["Address"].ToString();
                            }

                            if (reader["RefDoc"].ToString() != "")
                            {
                                cmbRefDoc.Text = reader["RefDoc"].ToString();
                            }

                            if (reader["InvName"].ToString() != "")
                            {
                                cmbInvDone.Text = reader["InvName"].ToString();
                            }

                            if (reader["Amount"].ToString() != "0")
                            {
                                txtAmount.Text = reader["Amount"].ToString();
                            }

                            if (reader["InvDone"].ToString() != "")
                            {
                                cmbScanDone.Text = reader["InvDone"].ToString();
                            }

                            if (reader["PDate"].ToString() != "")
                            {
                                //ReportDate = reader["PDate"].ToString();
                            }

                            d = 0;
                            c = 0;
                            string stPath = Path.GetFullPath(@"..\\..\\TempImages\\" + lstPatient.SelectedItems[0].SubItems[1].Text);
                            if (!Directory.Exists(stPath))
                            {
                                ClearPictureBox();
                                MessageBox.Show(" No images Saved for this Patient ");
                                //return;
                            }

                            if (Directory.Exists(stPath))
                            {
                                string[] imgFiles = Directory.GetFiles(stPath, "*.jpeg");
                                ClearPictureBox();
                                ImgWidth = 0;
                                for (int i = 0; i < imgFiles.Length; i++)
                                {
                                    if (c > 28)
                                    {
                                        return;
                                    }

                                    if (i == 0)
                                    {
                                        pictureList1.Visible = true;
                                        //pictureList1.Image = Image.FromFile(Path.GetFullPath(imgFiles[i]));
                                        FileStream fs = new FileStream(Path.GetFullPath(imgFiles[i]), FileMode.Open, FileAccess.Read);
                                        Image img = Image.FromStream(fs);
                                        fs.Close();
                                        pictureList1.Image = img.Clone() as Image;
                                        img.Dispose();
                                        pictureList1.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else
                                    {
                                        ImgWidth = ImgWidth + 101;
                                        FileStream fs = new FileStream(Path.GetFullPath(imgFiles[i]), FileMode.Open, FileAccess.Read);
                                        Image img = Image.FromStream(fs);
                                        fs.Close();

                                        var picture = new PictureBox
                                        {
                                            Name = "pictureList" + c,
                                            Size = new Size(100, 93),
                                            Location = new Point(ImgWidth, 4),
                                            Image = img.Clone() as Image,
                                            SizeMode = PictureBoxSizeMode.StretchImage
                                        };
                                        img.Dispose();
                                        picture.Click += new EventHandler(m_pictureBox_Click);
                                        picture.DoubleClick += new EventHandler(m_pictureBox_DoubleClick);
                                        picture.MouseLeave += new EventHandler(m_pictureList_MouseLeave);
                                        picture.ContextMenuStrip = contextMenuStrip1;
                                        this.panelPictures.Controls.Add(picture);
                                    }
                                    c = c + 1;
                                }
                            }
                        }
                    }
                }

                gFind.Visible = false;
                //gAVIRecording.Visible = false;
                //gPatient.Visible = true;

                gPatient.Visible = true;
                gPatient.BringToFront();
                btnStillImage.Enabled = true;
                btnProceed.Enabled = true;
                btnStillImage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstPatient_DoubleClick_1(object sender, EventArgs e)
        {
            // MessageBox.Show(lstPatient.SelectedItems[0].SubItems[0].Text);
            DisplayPatientDetails();
            GlobalVariables.bReported = true;
            btnStillImage.Enabled = true;
        }

        private void gPatient_Enter(object sender, EventArgs e)
        {

        }

        private void pictureList1_Click(object sender, EventArgs e)
        {
            pictureList1.BackColor = Color.Red;
            //pictureList1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pictureList1.Padding = new System.Windows.Forms.Padding(3);
            pictureList1.Refresh();

            string stPath = Path.GetFullPath(@"..\\..\\TempImages\\" + GlobalVariables.PIDD + "\\Image1.jpeg");
            frmDisplay picturePopUp = new frmDisplay(stPath);
            picturePopUp.Show();

            string stePath = Path.GetFullPath(@"..\\..\\Images\\Image1.jpeg");
            //pictureList1.Image.Save(stePath);
            File.Copy(@stPath, @stePath,true);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Text = "Edit Popup Menu";
            this.contextMenuStrip1.Show();
        }

        private void toolStripDeleteImage_Click(object sender, EventArgs e)
        {
            try
            {
                Control sourceControl = contextMenuStrip1.SourceControl;
                string sControlIndex = sourceControl.Name.ToString().Substring(11);

                PictureBox pb = new PictureBox();
                pb.Name = "pictureList" + sControlIndex;
                pb.Image = null;
                pb.InitialImage = null;
                pb.ImageLocation = null;
                pb.Dispose();

                GC.Collect();

                foreach (Control item in this.panelPictures.Controls.OfType<Control>())
                {
                    if (item.Name == sourceControl.Name.ToString())
                    {
                        sourceControl.Dispose();
                        item.Dispose();
                        this.panelPictures.Controls.Remove(item);
                        this.panelPictures.Controls.Remove(pb);
                    }
                }

                //to remove all picture boxes from Panel
                foreach (Control item in this.panelPictures.Controls.OfType<Control>())
                {
                    this.panelPictures.Controls.Remove(item);
                    item.Dispose();
                }

                this.panelPictures.Controls.Clear();
                this.panelPictures.Refresh();

                string tempImagePath = Path.GetFullPath(@"..\\..\\TempImages\\" + GlobalVariables.PIDD + "\\Image" + sControlIndex + ".jpeg");
                if (File.Exists(tempImagePath))
                {

                    GC.Collect();
                    File.Delete(tempImagePath);

                }

                string imagePath = Path.GetFullPath(@"..\\..\\Images\\Image" + sControlIndex + ".jpeg");
                if (File.Exists(imagePath))
                {
                    GC.Collect();
                    File.Delete(imagePath);
                }

                LoadImages(Path.GetFullPath(@"..\\..\\TempImages\\" + GlobalVariables.PIDD));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadImages(string sPath)
        {
            try
            {
                string[] filePaths = Directory.GetFiles(@sPath, "*.jpeg", SearchOption.TopDirectoryOnly);
                int ImgW = 0;
                string iCount = ""; 
                string sfname = "";
                if (filePaths.Length == 0)
                {
                    ImgWidth = 0;
                    c = 0;
                    this.panelPictures.Controls.Clear();
                }

                foreach (string sFileName in filePaths)
                {
                    if (File.Exists(sFileName))
                    {
                        FileStream fs = new FileStream(sFileName, FileMode.Open, FileAccess.Read);
                        Image img = Image.FromStream(fs);
                        fs.Close();

                        sfname = Path.GetFileNameWithoutExtension(sFileName);
                        iCount = sfname.Replace("Image", "");
                      
                        var picture = new PictureBox
                        {
                            Name = "pictureList" + iCount,
                            Size = new Size(100, 93),
                            Location = new Point(ImgW, 4),
                            Image = img.Clone() as Image,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        img.Dispose();
                        picture.Click += new EventHandler(m_pictureBox_Click);
                        picture.DoubleClick += new EventHandler(m_pictureBox_DoubleClick);
                        picture.MouseLeave += new EventHandler(m_pictureList_MouseLeave);
                        picture.ContextMenuStrip = contextMenuStrip1;
                        this.panelPictures.Controls.Add(picture);
                        ImgWidth = ImgW;
                        ImgW = ImgW + 101;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ClearPictureBox()
        {

            foreach (Control item in panelPictures.Controls.OfType<Control>())
            {
                if (item.Name != "pictureList1")
                {
                    panelPictures.Controls.Remove(item);
                }

            }

            panelPictures.Controls.Clear();
            panelPictures.Refresh();

            ImgWidth = 4;
            var picture = new PictureBox
            {
                Name = "pictureList1",
                Size = new Size(100, 93),
                Location = new Point(ImgWidth, 4),
                //Image = Image.FromFile(Path.GetFullPath(imgFiles[i])),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            picture.Click += new EventHandler(m_pictureBox_Click);
            picture.DoubleClick += new EventHandler(m_pictureBox_DoubleClick);
            picture.MouseLeave += new EventHandler(m_pictureList_MouseLeave);
            picture.ContextMenuStrip = contextMenuStrip1;
            this.panelPictures.Controls.Add(picture);

        }
        private void pictureList1_DoubleClick(object sender, EventArgs e)
        {
            string imagePath = Path.GetFullPath(@"..\\..\\Images\\Image1.jpeg");
            if (File.Exists(imagePath))
            {
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // picAVI.Image = Image.FromFile(@vPath + "1.avi");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureList1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureList1_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pb = (PictureBox)sender;
                pb.Padding = new System.Windows.Forms.Padding(0);
                pb.Refresh();
            }
        }

        private void m_pictureList_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pb = (PictureBox)sender;
                pb.Padding = new System.Windows.Forms.Padding(0);
                pb.Refresh();
            }
        }

        private void pictureList1_MouseHover(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Tag = Color.Red;
            pb.BackColor = Color.Red;
            pb.Padding = new System.Windows.Forms.Padding(3);
            pb.Refresh();
        }

        public void m_pictureList_MouseHover(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Tag = Color.Red;
            pb.BackColor = Color.Red;
            pb.Padding = new System.Windows.Forms.Padding(3);
            pb.Refresh();
        }
    }
}
