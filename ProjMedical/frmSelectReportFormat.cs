using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;

namespace SELECT_REPORT_FORMAT
{
    public partial class frmSelectReportFormat : Form
    {
        int ImgWidthMax = 0;
        int tsr = 0;
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
        string sQuery = "";
        //string sPath = Directory.GetCurrentDirectory() + "\\Icons\\imageSize.jpg";
        string sPath = Path.GetFullPath(@"..\\..\\Icons\\imageSize.jpg");
        int iRecordCount = 0;
        int iLines = 0;
        public frmSelectReportFormat()
        {
            InitializeComponent();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnOK_Click(object sender, EventArgs e)
        {

            if (rdbDefault.Checked)
            {
                tsr = 1;
            }
            else if (rdbtwo.Checked)
            {
                tsr = 2;
            }
            else if (rdbFour.Checked)
            {
                tsr = 4;
            }
            else if (rdbSix.Checked)
            {
                tsr = 6;
            }
            else if (rdbEight.Checked)
            {
                tsr = 8;
            }
            else if (rdbTen.Checked)
            {
                tsr = 10;
            }
            else if (rdbTwelve.Checked)
            {
                tsr = 12;
            }

            if (rdbPrint.Checked)
            {
                iLines = 0;
            }
            else if (rdpPrePrint.Checked)
            {
                iLines = int.Parse(txtNoOfLines.Text.ToString());
            }

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select count(*) From LetterHead";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                iRecordCount = (int)cmd.ExecuteScalar();
                if (iRecordCount == 1)
                {
                    sQuery = "UPDATE LetterHead SET NoOfSpces = " + iLines;
                    OleDbCommand cmd1 = new OleDbCommand(sQuery, con);
                    cmd1.ExecuteNonQuery();
                }
            }

            this.Close();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmSelectReportFormat_Load(object sender, EventArgs e)
        {

            //ImageResizing.Value = pictureBox1.Width;
            ImgWidthMax = 4215;
            lblPrintReport.Visible = false;
            txtNoOfLines.Visible = false;

            if (tsr == 1)
            {
                rdbDefault.Checked = true;
            }
            else if (tsr == 2)
            {
                rdbtwo.Checked = true;
            }
            else if (tsr == 4)
            {
                rdbFour.Checked = true;
            }
            else if (tsr == 6)
            {
                rdbSix.Checked = true;
            }
            else if (tsr == 8)
            {
                rdbEight.Checked = true;
            }
            else if (tsr == 10)
            {
                rdbTen.Checked = true;
            }
            else if (tsr == 12)
            {
                rdbTwelve.Checked = true;
            }

            Image image = Image.FromFile(sPath);
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rdbPrint.Checked = true;

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                sQuery = "Select * From LetterHead";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNoOfLines.Text = reader[3].ToString();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdbPrint_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrint.Checked)
            {
                lblPrintReport.Visible = false;
                txtNoOfLines.Visible = false;
            }
        }

        private void rdpPrePrint_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpPrePrint.Checked)
            {
                lblPrintReport.Visible = true;
                txtNoOfLines.Visible = true;
            }
        }

        private void rdbtwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtwo.Checked)
            {
                ImageResizing.Enabled = true;
                tsr = 2;
            }
        }

        private void rdbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDefault.Checked)
            {
                tsr = 1;
                if (pictureBox1.Width > 3541)
                {
                    pictureBox1.Height = 2727;
                    pictureBox1.Width = 3541;
                    ImageResizing.Value = 3541;
                }
            }
        }

        private void rdbFour_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFour.Checked)
            {
                ImageResizing.Enabled = true;
                tsr = 4;
            }
        }

        private void rdbSix_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSix.Checked)
            {
                ImageResizing.Enabled = true;
                tsr = 6;
            }
        }

        private void rdbEight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEight.Checked)
            {
                pictureBox1.Height = 205;
                pictureBox1.Width = 270;
                ImageResizing.Enabled = false;
                tsr = 8;
            }
        }

        private void rdbTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTen.Checked)
            {
                pictureBox1.Height = 205;
                pictureBox1.Width = 270;
                ImageResizing.Value = 270;
                ImageResizing.Enabled = false;
                tsr = 10;
            }
        }

        private void rdbTwelve_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTwelve.Checked)
            {
                pictureBox1.Height = 205;
                pictureBox1.Width = 270;
                ImageResizing.Value = 270;
                ImageResizing.Enabled = false;
                tsr = 12;
            }
        }

        private void ImageResizing_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            //Image image = Image.FromFile(sPath);
            using (var image = Image.FromFile(sPath))
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;




                if (Convert.ToInt32(num.Text) > num.Value)
                {
                    //pictureBox1.Width = (int)num.Value;
                    //pictureBox1.Height = pictureBox1.Height - 30;
                    //pictureBox1.Image = image;
                    //pictureBox1.Size = pictureBox1.Image.Size;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    //image = new Bitmap((int)num.Value, image.Height - 30);
                    //image.
                    //pictureBox1.Image = image;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    // Bitmap new_image = new Bitmap((int)num.Value, pictureBox1.Image.Height - 30);
                    //pictureBox1.Image = Image.FromFile(sPath);
                    //pictureBox1.Height = (int)num.Value;
                    //pictureBox1.Width = pictureBox1.Width - 30;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    //PictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName)

                    // pictureBox1.Show();

                    pictureBox1.ImageLocation = sPath;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Height = pictureBox1.Height - 40;
                    pictureBox1.Width = pictureBox1.Width - 30;

                }
                else
                {
                    //pictureBox1.Width = (int)num.Value;
                    //pictureBox1.Height = pictureBox1.Height + 30;
                    //pictureBox1.Image = image;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    //image = new Bitmap((int)num.Value, image.Height + 30);
                    //pictureBox1.Image = image;
                    //   Bitmap new_image = new Bitmap((int)num.Value, pictureBox1.Image.Height + 30);
                    // pictureBox1.Image = Image.FromFile(sPath);
                    // pictureBox1.Height = (int)num.Value;
                    //pictureBox1.Width = pictureBox1.Width + 30;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBox1.ImageLocation = sPath;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Height = pictureBox1.Height + 40;
                    pictureBox1.Width = pictureBox1.Width + 30;


                }
        }






    }
}
