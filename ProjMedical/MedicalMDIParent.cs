using ChangeUsernameAndPassword;
using DetailsDoctors;
using PATIENT_LIST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Add_New_Reports;
using LetterHeadingForm;
using SELECT_REPORT_FORMAT;
using FrmCaptureImage;
using Dictionary;

namespace ProjMedical
{
    public partial class MedicalMDIParent : Form
    {


        public MedicalMDIParent()
        {
            InitializeComponent();
        }

        frmCaptureImage frmcaptureimage;
        private void ShowNewForm(object sender, EventArgs e)
        {
            if (frmcaptureimage == null)
            {
                frmcaptureimage = new frmCaptureImage();
                frmcaptureimage.MdiParent = this;
                frmcaptureimage.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                frmcaptureimage.FormBorderStyle = FormBorderStyle.None;
                frmcaptureimage.ControlBox = false;
                frmcaptureimage.MaximizeBox = false;
                frmcaptureimage.MinimizeBox = false;
                frmcaptureimage.ShowIcon = false;
                frmcaptureimage.FormClosed += Frmcaptureimage_FormClosed; ;
                frmcaptureimage.Dock = DockStyle.Fill;
                frmcaptureimage.Show();
            }
            else
            {
                frmcaptureimage.Activate();
            }

        }

        public void Frmcaptureimage_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmcaptureimage = null;
        }

        private void OpenFile(object sender, EventArgs e)
        {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit application?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        frmCaptureDevice FrmCaptureDevice;
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmSelectReportFormat == null)
            {
                FrmCaptureDevice = new frmCaptureDevice();
                FrmCaptureDevice.MdiParent = this;
                FrmCaptureDevice.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmCaptureDevice.FormBorderStyle = FormBorderStyle.None;
                FrmCaptureDevice.ControlBox = false;
                FrmCaptureDevice.MaximizeBox = false;
                FrmCaptureDevice.MinimizeBox = false;
                FrmCaptureDevice.ShowIcon = false;
                FrmCaptureDevice.FormClosed += FrmCaptureDevice_FormClosed; ; ;
                FrmCaptureDevice.Dock = DockStyle.Fill;
                FrmCaptureDevice.Show();
            }
            else
            {
                FrmCaptureDevice.Activate();

            }
        }

        private void FrmCaptureDevice_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmCaptureDevice = null;
        }

        frmSelectReportFormat FrmSelectReportFormat;
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmSelectReportFormat == null)
            {
                FrmSelectReportFormat = new frmSelectReportFormat();
                FrmSelectReportFormat.MdiParent = this;
                FrmSelectReportFormat.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmSelectReportFormat.FormBorderStyle = FormBorderStyle.None;
                FrmSelectReportFormat.ControlBox = false;
                FrmSelectReportFormat.MaximizeBox = false;
                FrmSelectReportFormat.MinimizeBox = false;
                FrmSelectReportFormat.ShowIcon = false;
                FrmSelectReportFormat.FormClosed += FrmSelectReportFormat_FormClosed; 
                FrmSelectReportFormat.Dock = DockStyle.Fill;
                FrmSelectReportFormat.Show();
            }
            else
            {
                FrmSelectReportFormat.Activate();

            }
        }

        private void FrmSelectReportFormat_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmSelectReportFormat = null;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        frmDetailsDoctors frmdetailsdoctors;
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmdetailsdoctors == null)
            {
                frmdetailsdoctors = new frmDetailsDoctors();
                frmdetailsdoctors.MdiParent = this;
                frmdetailsdoctors.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                frmdetailsdoctors.FormBorderStyle = FormBorderStyle.None;
                frmdetailsdoctors.ControlBox = false;
                frmdetailsdoctors.MaximizeBox = false;
                frmdetailsdoctors.MinimizeBox = false;
                frmdetailsdoctors.ShowIcon = false;
                frmdetailsdoctors.FormClosed += Frmdetailsdoctors_FormClosed;
                frmdetailsdoctors.Dock = DockStyle.Fill;
                frmdetailsdoctors.Show();
            }
            else
            {
                frmdetailsdoctors.Activate();

            }
        }

        private void Frmdetailsdoctors_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmdetailsdoctors = null;
        }





        private void MedicalMDIParent_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


        }

        frmChangePassword frmchangepassword;
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmchangepassword == null)
            {
                frmchangepassword = new frmChangePassword();
                frmchangepassword.MdiParent = this;
                frmchangepassword.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                frmchangepassword.FormBorderStyle = FormBorderStyle.None;
                frmchangepassword.ControlBox = false;
                frmchangepassword.MaximizeBox = false;
                frmchangepassword.MinimizeBox = false;
                frmchangepassword.ShowIcon = false;
                frmchangepassword.FormClosed += Frmchangepassword_FormClosed; ;
                frmchangepassword.Dock = DockStyle.Fill;
                frmchangepassword.Show();
            }
            else
            {
                frmchangepassword.Activate();

            }
        }

        private void Frmchangepassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmchangepassword = null;
        }

        private void runUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This method will run the database changes/modifications automatically when user click on Run update menu item
            UpdateDatabase();
        }


        public void UpdateDatabase()
        {
            try
            {
                string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                string[] restrictionValues = new string[4] { null, null, null, "TABLE" };
                List<string> tableNames = new List<string>();
                DataTable dt = con.GetSchema("tables");
                //this will allow to run create command if table not exists
                bool IsUserProfileNotExists = true;
                foreach (DataRow row in dt.Rows)
                {
                    if (row.ItemArray[2].ToString() == "UserProfile")
                    {
                        //it will stops to run create command if table exists
                        IsUserProfileNotExists = false;
                    }
                }
                if (IsUserProfileNotExists)
                {
                    OleDbCommand myCommand = new OleDbCommand();
                    myCommand.Connection = con;
                    myCommand.CommandText = "CREATE TABLE UserProfile([Id] COUNTER,[USERNAME] Text(25),[PASSWORD] Text(8))";
                    myCommand.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
        frmPatientList frmpatientlist;
        private void ViewPatientList(object sender, EventArgs e)
        {
            if (frmpatientlist == null)
            {
                frmpatientlist = new frmPatientList();
                frmpatientlist.MdiParent = this;
                frmpatientlist.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                frmpatientlist.FormBorderStyle = FormBorderStyle.None;
                frmpatientlist.ControlBox = false;
                frmpatientlist.MaximizeBox = false;
                frmpatientlist.MinimizeBox = false;
                frmpatientlist.ShowIcon = false;
                frmpatientlist.FormClosed += Frmpatientlist_FormClosed;
                frmpatientlist.Dock = DockStyle.Fill;
                frmpatientlist.Show();
            }
            else
            {
                frmpatientlist.Activate();

            }
        }

        private void Frmpatientlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmpatientlist = null;
        }

        frmAddNewRepots frmaddnewrepots;
        private void addNewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmaddnewrepots == null)
            {
                frmaddnewrepots = new frmAddNewRepots();
                frmaddnewrepots.MdiParent = this;
                frmaddnewrepots.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                frmaddnewrepots.FormBorderStyle = FormBorderStyle.None;
                frmaddnewrepots.ControlBox = false;
                frmaddnewrepots.MaximizeBox = false;
                frmaddnewrepots.MinimizeBox = false;
                frmaddnewrepots.ShowIcon = false;
                frmaddnewrepots.FormClosed += Frmchangepassword_FormClosed;
                frmaddnewrepots.Dock = DockStyle.Fill;
                frmaddnewrepots.Show();
            }
            else
            {
                frmaddnewrepots.Activate();

            }
        }

        frmLetterHeadingForm FrmLetterHeadingForm;
        private void letterHeadOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmLetterHeadingForm == null)
            {
                FrmLetterHeadingForm = new frmLetterHeadingForm();
                FrmLetterHeadingForm.MdiParent = this;
                FrmLetterHeadingForm.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmLetterHeadingForm.FormBorderStyle = FormBorderStyle.None;
                FrmLetterHeadingForm.ControlBox = false;
                FrmLetterHeadingForm.MaximizeBox = false;
                FrmLetterHeadingForm.MinimizeBox = false;
                FrmLetterHeadingForm.ShowIcon = false;
                FrmLetterHeadingForm.FormClosed += FrmLetterHeadingForm_FormClosed; ;
                FrmLetterHeadingForm.Dock = DockStyle.Fill;
                FrmLetterHeadingForm.Show();
            }
            else
            {
                FrmLetterHeadingForm.Activate();
            }
        }

        private void FrmLetterHeadingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLetterHeadingForm = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void FrmCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
        frmAbout FrmAbout;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (FrmAbout == null)
            {
                FrmAbout = new frmAbout();
                FrmAbout.MdiParent = this;
                FrmAbout.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmAbout.FormBorderStyle = FormBorderStyle.None;
                FrmAbout.ControlBox = false;
                FrmAbout.MaximizeBox = false;
                FrmAbout.MinimizeBox = false;
                FrmAbout.ShowIcon = false;
                FrmAbout.FormClosed += FrmAbout_FormClosed;
                FrmAbout.Dock = DockStyle.Fill;
                FrmAbout.Show();
            }
            else
            {
                FrmAbout.Activate();
            }
        }

        private void FrmAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmAbout = null;
        }

        frmImageEdgeCut FrmImageEdgeCut;
        private void imageEdgeCuttingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmImageEdgeCut == null)
            {
                FrmImageEdgeCut = new frmImageEdgeCut();
                FrmImageEdgeCut.MdiParent = this;
                FrmImageEdgeCut.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmImageEdgeCut.FormBorderStyle = FormBorderStyle.None;
                FrmImageEdgeCut.ControlBox = false;
                FrmImageEdgeCut.MaximizeBox = false;
                FrmImageEdgeCut.MinimizeBox = false;
                FrmImageEdgeCut.ShowIcon = false;
                FrmImageEdgeCut.FormClosed += FrmImageEdgeCut_FormClosed;     
                FrmImageEdgeCut.Dock = DockStyle.Fill;
                FrmImageEdgeCut.Show();
            }
            else
            {
                FrmImageEdgeCut.Activate();
            }
        }

        private void FrmImageEdgeCut_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmImageEdgeCut = null;
        }

        frmDictionary FrmDictionary;
        private void addWordsToDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (FrmDictionary == null)
            {
                FrmDictionary = new frmDictionary();
                FrmDictionary.MdiParent = this;
                FrmDictionary.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmDictionary.FormBorderStyle = FormBorderStyle.None;
                FrmDictionary.ControlBox = false;
                FrmDictionary.MaximizeBox = false;
                FrmDictionary.MinimizeBox = false;
                FrmDictionary.ShowIcon = false;
                FrmDictionary.FormClosed += FrmDictionary_FormClosed; ;
                FrmDictionary.Dock = DockStyle.Fill;
                FrmDictionary.Show();
            }
            else
            {
                FrmDictionary.Activate();
            }
        }

        private void FrmDictionary_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDictionary = null;
        }
        frmBackUp FrmBackUp;
        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmBackUp == null)
            {
                FrmBackUp = new frmBackUp();
                FrmBackUp.MdiParent = this;
                FrmBackUp.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmBackUp.FormBorderStyle = FormBorderStyle.None;
                FrmBackUp.ControlBox = false;
                FrmBackUp.MaximizeBox = false;
                FrmBackUp.MinimizeBox = false;
                FrmBackUp.ShowIcon = false;
                FrmBackUp.FormClosed += FrmBackUp_FormClosed; ; ;
                FrmBackUp.Dock = DockStyle.Fill;
                FrmBackUp.Show();
            }
            else
            {
                FrmBackUp.Activate();
            }
        }

        private void FrmBackUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmBackUp = null;
        }
        frmReadFromBackUp FrmReadFromBackUp;
        private void readFromBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmReadFromBackUp == null)
            {
                FrmReadFromBackUp = new frmReadFromBackUp();
                FrmReadFromBackUp.MdiParent = this;
                FrmReadFromBackUp.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmReadFromBackUp.FormBorderStyle = FormBorderStyle.None;
                FrmReadFromBackUp.ControlBox = false;
                FrmReadFromBackUp.MaximizeBox = false;
                FrmReadFromBackUp.MinimizeBox = false;
                FrmReadFromBackUp.ShowIcon = false;
                FrmReadFromBackUp.FormClosed += FrmReadFromBackUp_FormClosed;     
                FrmReadFromBackUp.Dock = DockStyle.Fill;
                FrmReadFromBackUp.Show();
            }
            else
            {
                FrmReadFromBackUp.Activate();
            }
        }

        private void FrmReadFromBackUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmReadFromBackUp = null;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void displayWordsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowReport showreport = new frmShowReport(GlobalVariables.sFinalPath, true);
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

        frmOptions frmoptions = new frmOptions();
        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (FrmReadFromBackUp == null)
            {
                FrmReadFromBackUp = new frmReadFromBackUp();
                FrmReadFromBackUp.MdiParent = this;
                FrmReadFromBackUp.ClientSize = new System.Drawing.Size(2000, 800);
                this.WindowState = FormWindowState.Maximized;
                FrmReadFromBackUp.FormBorderStyle = FormBorderStyle.None;
                FrmReadFromBackUp.ControlBox = false;
                FrmReadFromBackUp.MaximizeBox = false;
                FrmReadFromBackUp.MinimizeBox = false;
                FrmReadFromBackUp.ShowIcon = false;
                FrmReadFromBackUp.FormClosed += FrmReadFromBackUp_FormClosed;
                FrmReadFromBackUp.Dock = DockStyle.Fill;
                FrmReadFromBackUp.Show();
            }
            else
            {
                FrmReadFromBackUp.Activate();
            }
        }
    }
}
