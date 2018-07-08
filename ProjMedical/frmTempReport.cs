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

namespace ProjMedical
{
    public partial class frmTempReport : Form
    {
        public frmTempReport()
        {
            InitializeComponent();
        }

        string sPath = Path.GetFullPath(@"..\\..\\Reports\\Dump\\" + GlobalVariables.sInvestigationReport + ".doc");
        string lPath = "";

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtfResultReport.SaveFile(sPath);
            this.Dispose();
            this.Close();
        }

        private void frmTempReport_Load(object sender, EventArgs e)
        {
            rtfResultReport.Refresh();

            if (GlobalVariables.bReported == true)
            {
                lPath = Path.GetFullPath(@"..\\..\\TempImages\\" + GlobalVariables.PIDD.Trim() + "\\P" + GlobalVariables.PIDD.Trim() + ".doc");
            }
            else
            {
                if (GlobalVariables.bSimReport == true)
                {
                    lPath = Path.GetFullPath(@"..\\..\\Reports\\Dump\\" + GlobalVariables.sInvestigationReport +  ".doc");
                }
                else
                {
                    lPath = Path.GetFullPath(@"..\\..\\Reports\\" + GlobalVariables.sInvestigationReport + ".rtf");
                }
            }

            if (rtfResultReport.Text == "")
            {
                lPath = Path.GetFullPath(@"..\\..\\Reports\\" + GlobalVariables.sInvestigationReport + ".rtf");
                rtfResultReport.LoadFile(lPath);
            }
        }

        private void frmTempReport_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                rtfResultReport.SaveFile(sPath);
            }
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.ShowColor = true;
                fontDialog.Font = rtfResultReport.Font;
                fontDialog.Color = rtfResultReport.ForeColor;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    rtfResultReport.Font = fontDialog.Font;
                    rtfResultReport.ForeColor = fontDialog.Color;
                }
            }
        }
    }
}
