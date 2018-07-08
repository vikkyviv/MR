using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LetterHeadingForm
{
    public partial class frmLetterHeadingForm : Form
    {
        public frmLetterHeadingForm()
        {
            InitializeComponent();
        }

        string LogoPath = "";
        string FileExtension = "";
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
        string sQuery = "";
        //string sPath = Directory.GetCurrentDirectory() + "\\Icons\\";
        string sPath = Path.GetFullPath(@"..\\..\\Icons\\");
        int iOption = 0;
        int iRecordCount = 0;
        

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files (*.*)|*.*";
                openFileDialog.Title = "Select a Logo";
                openFileDialog.ShowDialog();
                if (openFileDialog.FileName != "")
                {
                    pictureBxImage.Load(openFileDialog.FileName);
                    LogoPath = openFileDialog.FileName;
                    FileExtension = Path.GetExtension(openFileDialog.FileName);
                }
            }

        }

        private void frmLetterHeadingForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    sQuery = "Select * From LetterHead";
                    OleDbCommand cmd = new OleDbCommand(sQuery, con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    if (reader.Read())
                    {

                        if (reader[2].ToString() != "")
                        {
                            if (reader[2].ToString() == "1")
                            {
                                rdbtnPrintLetterHeadrandleft.Checked = true;
                            }
                            else if (reader[2].ToString() == "2")
                            {
                                rdbtnprintletterheadlandr.Checked = true;
                            }
                            else if (reader[2].ToString() == "3")
                            {
                                rdbtnprintwithoutlogo.Checked = true;
                            }
                        }

                        if (reader[0].ToString() != "")
                        {
                            //txtLetterHead.Text = reader[0].ToString();
                            txtLetterHead.Rtf = reader[0].ToString();
                        }

                        if (reader[1].ToString() != "")
                        {
                            LogoPath = Path.GetFullPath(@"..\\..\\" + reader[1].ToString());
                            pictureBxImage.Load(LogoPath);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void btnFontStyle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLetterHead.Text))
            {
                MessageBox.Show("Please Letter Head Text");
                return;
            }

            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.ShowColor = true;
                fontDialog.Font = txtLetterHead.Font;
                fontDialog.Color = txtLetterHead.ForeColor;

                //fontDialog.ShowDialog();
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    txtLetterHead.Font = fontDialog.Font;
                    txtLetterHead.ForeColor = fontDialog.Color;
                }
            }

        }

        private void rdbtnPrintLetterHeadrandleft_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPrintLetterHeadrandleft.Checked)
            {
                iOption = 1;
                btnAddLogo.Visible = true;
                pictureBxImage.Visible = true;
                pictureBxImage.Location = new Point(16, 18);
                pictureBxImage.Size = new Size(113, 96);
                btnAddLogo.Location = new Point(34, 120);
                btnAddLogo.Size = new Size(75, 23);
                txtLetterHead.Location = new Point(137, 18);
                txtLetterHead.Size = new Size(664, 125);
            }
        }

        private void rdbtnprintletterheadlandr_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnprintletterheadlandr.Checked)
            {
                iOption = 2;
                btnAddLogo.Visible = true;
                pictureBxImage.Visible = true;
                pictureBxImage.Location = new Point(688, 18);
                pictureBxImage.Size = new Size(113, 96);
                btnAddLogo.Location = new Point(707, 120);
                btnAddLogo.Size = new Size(75, 23);
                txtLetterHead.Location = new Point(16, 18);
                txtLetterHead.Size = new Size(664, 125);
            }
        }

        private void rdbtnprintwithoutlogo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnprintwithoutlogo.Checked)
            {
                iOption = 3;
                btnAddLogo.Visible = false;
                pictureBxImage.Visible = false;
                txtLetterHead.Location = new Point(16, 18);
                txtLetterHead.Size = new Size(785, 125);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLetterHead.Text))
            {
                MessageBox.Show("Letter Head can't be blank", "Letter Head Options");
                return;
            }

            try
            {
                if ((pictureBxImage.ImageLocation != "") && (Path.GetExtension(LogoPath) != ""))
                {
                    FileExtension = Path.GetExtension(LogoPath);
                    string tmpPath = sPath + "OLogo" + FileExtension;

                    if (!Directory.Exists(sPath))
                    {
                        Directory.CreateDirectory(sPath);
                    }

                    if (LogoPath != tmpPath)
                    {
                        File.Copy(LogoPath, tmpPath, true);
                        LogoPath = tmpPath;
                        LogoPath = "Icons\\OLogo" + FileExtension;
                    }

                    using (OleDbConnection con = new OleDbConnection(connection))
                    {
                        sQuery = "Select count(*) From LetterHead";
                        OleDbCommand cmd = new OleDbCommand(sQuery, con);
                        con.Open();
                        iRecordCount = (int)cmd.ExecuteScalar();

                        if (iRecordCount == 0)
                        {
                            sQuery = "INSERT INTO LetterHead (LetterHead, LogoPath, LogoOption) VALUES ('" + txtLetterHead.Rtf + "','" + LogoPath + "'," + iOption + ")";
                            OleDbCommand cmd1 = new OleDbCommand(sQuery, con);
                            cmd1.ExecuteNonQuery();
                        }
                        else if (iRecordCount == 1)
                        {
                            sQuery = "UPDATE LetterHead SET LetterHead = '" + txtLetterHead.Rtf + "', LogoPath = '" + LogoPath + "', LogoOption = " + iOption;
                            OleDbCommand cmd1 = new OleDbCommand(sQuery, con);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        
    }
}
