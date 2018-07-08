using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjMedical;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjMedical
{
    public partial class frmShowReport : Form
    {
        public frmShowReport(string sLoadReportPath, bool bWordLst)
        {
            InitializeComponent();
            if (sLoadReportPath != "" && sLoadReportPath != null)
            {
                rtbReport.LoadFile(sLoadReportPath);
                GlobalVariables.sFinalPath = sLoadReportPath;
                panelWordList.Visible = bWordLst;
            }
        }

        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;

        string sPath = Path.GetFullPath(@"..\\..\\TempImages\\");
        string sReportPath = Path.GetFullPath(@"..\\..\\Reports\\");

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            string sFilePath = sPath + GlobalVariables.PIDD + "\\P" + GlobalVariables.PIDD + ".Doc";
            rtbReport.SaveFile(sFilePath);
            MessageBox.Show("Report has been Saved");
        }

        private void frmShowReport_Load(object sender, EventArgs e)
        {

            lblPID.Text = GlobalVariables.PIDD;
            lblName.Text = GlobalVariables.PatientName;
            string sFinalPath = "";
            if (GlobalVariables.bSimReport == true)
            {
                sFinalPath = sReportPath + "\\Dump\\" + GlobalVariables.InvDone + ".Doc";
                rtbReport.LoadFile(sFinalPath);
            }
            else
            {
                if (GlobalVariables.bReported == true)
                {
                    sFinalPath = sPath + GlobalVariables.PIDD + "\\P" + GlobalVariables.PIDD + ".Doc";
                    rtbReport.LoadFile(sFinalPath);

                    if (rtbReport.Text == "")
                    {
                        sFinalPath = sReportPath + "ActReport\\" + GlobalVariables.InvDone + ".rtf";
                        rtbReport.LoadFile(sFinalPath);
                    }
                }
                else
                {
                    sFinalPath = sReportPath + "ActReport\\" + GlobalVariables.InvDone + ".rtf";
                    rtbReport.LoadFile(sFinalPath);
                }
            }
            GlobalVariables.sFinalPath = sFinalPath;
            GetListofWords();

        }

        private void GetListofWords()
        {
            lstWords.View = View.Details;
            lstWords.GridLines = true;
            lstWords.FullRowSelect = true;

            lstWords.Columns.Add("", 200, HorizontalAlignment.Left);

            lstWords.Items.Clear();
            lstWords.HeaderStyle = ColumnHeaderStyle.None;
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                string sQuery = "Select Words From Dictionary";
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstWords.Items.Add(reader[0].ToString());
                }
            }
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWords.SelectedItems.Count != 0)
            {
                if (lstWords.SelectedItems[0].Text.ToString() != "")
                {
                    Clipboard.SetText(lstWords.SelectedItems[0].Text, TextDataFormat.Rtf);
                    rtbReport.Paste();
                    panelWordList.Visible = false;
                }
            }
        }
    }
}
