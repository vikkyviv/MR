using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using FrmCaptureImage;

namespace ProjMedical
{
    public partial class frmReportSelection : Form
    {
        public frmReportSelection()
        {
            InitializeComponent();
        }

        string reportsPath = Path.GetFullPath(@"..\\..\\Reports");
        string reportsResultPath = Path.GetFullPath(@"..\\..\\ReportResult");
        string imagesPath = Path.GetFullPath(@"..\\..\\Images");
        string tempImagesPath = Path.GetFullPath(@"..\\..\\TempImages");
        int No = 0;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            string sFinalPath = "";
            if (GlobalVariables.bImageCheck == false)
            {
                if (cmbReportName.Text.Length == 0)
                {
                    MessageBox.Show("You have to select report to show report");
                    return;
                }

                rtfReportDetails.SaveFile(reportsPath + "\\ActReport\\" + cmbReportName.Text + ".rtf");

                if (!File.Exists(reportsPath + "\\ActReport\\" + cmbReportName.Text + ".rtf"))
                {
                    MessageBox.Show("Check your file name");
                    return;
                }
            }
            else
            {
                if (GlobalVariables.bReported == true)
                {
                    if (File.Exists(reportsResultPath + "\\P" + GlobalVariables.PIDD + "\\P" + GlobalVariables.PIDD + ".Doc"))
                    {
                        sFinalPath = reportsResultPath + "\\P" + GlobalVariables.PIDD + "\\P" + GlobalVariables.PIDD + ".Doc";
                    }
                    else
                    {
                        MessageBox.Show("You have not saved Report for this patient");
                        return;
                    }
                }
                else
                {
                    sFinalPath = reportsPath + "\\" + cmbReportName.Text + ".rtf";

                }
            }

            MedicalMDIParent p = new MedicalMDIParent();
            p.displayWordsListToolStripMenuItem.Enabled = true;

            frmShowReport showreport = new frmShowReport(sFinalPath, false);
            showreport.Dock = DockStyle.Fill;
            showreport.MdiParent = this.MdiParent;
            showreport.ClientSize = new System.Drawing.Size(2000, 800);
            showreport.WindowState = FormWindowState.Maximized;
            showreport.FormBorderStyle = FormBorderStyle.None;
            showreport.ControlBox = false;
            showreport.MaximizeBox = false;
            showreport.MinimizeBox = false;
            showreport.ShowIcon = false;
            showreport.Show();
        }

        private void btnShowImages_Click(object sender, EventArgs e)
        {
            if (No == 1)
            {

                if (cmbReportName.Text.ToString().Length == 0)
                {
                    MessageBox.Show("For This ReportFormat ReportName Cannot be Empty");
                    return;
                }
                else
                {
                    MessageBox.Show("To view Images select a different Report Format in Setup Menu");
                }
            }
            else
            {
                frmShowImages showImages = new frmShowImages();
                showImages.Show();
            }
        }

        frmCaptureImage cap;
        private void btnStartAgain_Click(object sender, EventArgs e)
        {
            GlobalVariables.PatientName = "";
            GlobalVariables.RefByDoc = "";
            GlobalVariables.Age = 0;
            GlobalVariables.InvReq = "";
            GlobalVariables.InvDone = "";
            GlobalVariables.VisitNo = 0;

            DeleteImages();

            this.Hide();

            cap = new frmCaptureImage();
            //cap.Activate();
         
            cap.MdiParent = this.MdiParent;
            cap.ClientSize = new System.Drawing.Size(2000, 800);
            cap.WindowState = FormWindowState.Maximized;
            cap.FormBorderStyle = FormBorderStyle.None;
            cap.ControlBox = false;
            cap.MaximizeBox = false;
            cap.MinimizeBox = false;
            cap.ShowIcon = false;
            cap.FormClosed += Frmcaptureimage_FormClosed;
            cap.Dock = DockStyle.Fill;
            cap.Show();
            cap.ControlCap();
            cap.axVideoCap1.Start();
        }

        private void Frmcaptureimage_FormClosed(object sender, FormClosedEventArgs e)
        {
            cap = null;
        }

        private void DeleteImages()
        {
            try
            {
                if (Directory.Exists(imagesPath))
                {
                    foreach (string file in Directory.GetFiles(imagesPath))
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

        private void btnImageProcessing_Click(object sender, EventArgs e)
        {

        }

        private void frmReportSelection_Load(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;

            LoadReportFileNames();

            string sFinalPath = "";
            if (GlobalVariables.bImageCheck == false)
            {
                sFinalPath = imagesPath + "\\";
            }
            else
            {
                sFinalPath = tempImagesPath + "\\P" + GlobalVariables.PIDD + "\\imgsel";
                string sPath = tempImagesPath + "\\" + GlobalVariables.PIDD + "\\P" + GlobalVariables.PIDD + ".Doc";
                cmbReportName.Enabled = false;
                if (File.Exists(sPath))
                {
                    rtfReportDetails.LoadFile(sPath);
                }
            }
            lblPatientID.Text = GlobalVariables.PIDD;
            lblPatientName.Text = GlobalVariables.PatientName;
            lblRefByDoctor.Text = GlobalVariables.RefByDoc;

            cmbReportName.Text = GlobalVariables.InvDone;
        }

        public void LoadReportFileNames()
        {
            try
            {
                string displayPath = Path.GetFullPath(@"..\\..\\Reports");
                cmbReportName.Items.Clear();

                string[] arrFileNames = Directory.GetFiles(displayPath);

                for (int i = 0; i < arrFileNames.Length; i++)
                {
                    arrFileNames[i] = Path.GetFileNameWithoutExtension(arrFileNames[i]);
                }

                cmbReportName.DataSource = arrFileNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbReportName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbReportName.Text.Length == 0)
            {
                return;
            }

            string displayPath = Path.GetFullPath(@"..\\..\\Reports");
            rtfReportDetails.LoadFile(reportsPath + "\\" + cmbReportName.Text.Trim() + ".rtf");
            GlobalVariables.InvDone = cmbReportName.Text;
        }
    }
}
