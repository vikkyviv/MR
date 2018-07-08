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

namespace Add_New_Reports
{
    public partial class frmAddNewRepots : Form
    {
        public frmAddNewRepots()
        {
            InitializeComponent();
        }

        string reportmode = "";
        //string sPath = Directory.GetCurrentDirectory() + "\\Reports\\";
        string sPath = Path.GetFullPath(@"..\\..\\Reports\\");


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Comboreportname.Visible = false;
            this.txtReportName.Visible = true;
            this.btnspellcheck.Enabled = false;
            this.btnsavereports.Enabled = false;
            this.btndeletereport.Enabled = false;

            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
        }

        private void btnaddreports_Click(object sender, EventArgs e)
        {
            this.reportmode = "";
            Comboreportname.Visible = false;
            txtReportName.Visible = true;
            listdetailsofthereport.Text = "";
            btneditreport.Enabled = false;
            btndeletereport.Enabled = false;
            btnaddreports.Enabled = false;
            btnsavereports.Enabled = true;
            btnspellcheck.Enabled = true;
        }

        private void listdetailsofthereport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listdetailsofthereport.Text != "")
            {
                btnspellcheck.Enabled = true;
            }
            else
            {
                btnspellcheck.Enabled = false;
            }
       }

        private void btnsavereports_Click(object sender, EventArgs e)
        {
            string sFileName = "";
            string sFullPath = "";
            if (reportmode == "" && txtReportName.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Report Name Cannot be empty");
                return;
            }

            if (reportmode == "Edit" && Comboreportname.Text == "")
            {
                MessageBox.Show("Report Name Cannot be Empty");
                return;
            }

            if (reportmode == "")
            {
                sFileName = txtReportName.Text;
            }
            else
            {
                sFileName = Comboreportname.Text;
                
            }

            sFullPath = sPath + sFileName + ".rtf";

            if (System.IO.File.Exists(sFullPath))
            {
                DialogResult dr = MessageBox.Show("Report with this name already exists do you want to overwrite", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
               if (dr == DialogResult.Yes)
                {
                    File.Delete(sFullPath);
                }
               else if (dr == DialogResult.No)
                {
                    txtReportName.Focus();
                    return;
                }

            }

            listdetailsofthereport.SaveFile(sFullPath);

            MessageBox.Show("Report has been Saved");
            txtReportName.Text = "";
            listdetailsofthereport.Text = "";
            reportmode = "";
            Comboreportname.Visible = false;

            btnaddreports.Enabled = true;
            btneditreport.Enabled = true;
            btnsavereports.Enabled = false;
            btndeletereport.Enabled = false;
            btnspellcheck.Enabled = false;
        }

        private void GetFiles()
        {
            try
            {
                string[] arrFileNames = Directory.GetFiles(sPath, "*.rtf");

                for (int i=0; i< arrFileNames.Length; i++)
                {
                    arrFileNames[i] = Path.GetFileNameWithoutExtension(arrFileNames[i]);
                }

                Comboreportname.DataSource = arrFileNames;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LoadFileData()
        {
            /*
            using (StreamReader sr = new StreamReader(sPath + Comboreportname.Text + ".rtf", Encoding.Default, true))
            {
                listdetailsofthereport.Text = sr.ReadToEnd();
            }
            */
            try
            { 
                listdetailsofthereport.LoadFile(sPath + Comboreportname.Text + ".rtf", RichTextBoxStreamType.RichText);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btneditreport_Click(object sender, EventArgs e)
         {
            txtReportName.Visible = false;
            Comboreportname.Visible = true;
            GetFiles();
            reportmode = "Edit";
            btneditreport.Enabled = false;
            btnaddreports.Enabled = false;
            btndeletereport.Enabled = true;
            btnsavereports.Enabled = true;
            btnspellcheck.Enabled = true;
         }

        private void Comboreportname_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFileData();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            btnaddreports.Enabled = true;
            btneditreport.Enabled = true;
            btnsavereports.Enabled = false;
            btnspellcheck.Enabled = false;
            btndeletereport.Enabled = false;
            listdetailsofthereport.Text = "";
            Comboreportname.Visible = false;
            txtReportName.Visible = true;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btndeletereport_Click(object sender, EventArgs e)
        {
            try
            {
                if (Comboreportname.Visible == true)
                {
                    if (Comboreportname.Text.Length == 0)
                    {
                        MessageBox.Show("Report Name cannot be Empty");
                        Comboreportname.Focus();
                        return;
                    }

                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete the Report", "Report Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(sPath + Comboreportname.Text + ".rtf");
                        MessageBox.Show("Report has been Deleted");
                        Comboreportname.Visible = false;
                        txtReportName.Visible = true;
                        listdetailsofthereport.Text = "";
                        reportmode = "";
                        //GetFiles();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Press the Edit button and then delete");
                    Comboreportname.Focus();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btneditreport.Enabled = true;
            btnaddreports.Enabled = true;
            btnspellcheck.Enabled = false;
            btndeletereport.Enabled = false;
            btnsavereports.Enabled = false;
        }

        private void btnspellcheck_Click(object sender, EventArgs e)
        {

        }
    }
}
        