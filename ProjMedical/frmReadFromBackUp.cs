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
using ProjMedical;
using System.Windows.Forms;

namespace ProjMedical
{
    public partial class frmReadFromBackUp : Form
    {
        public frmReadFromBackUp()
        {
            InitializeComponent();
        }

        string sDefaultPath = Path.GetFullPath(@"..\\..\\");

        private void btnOK_Click(object sender, EventArgs e)
        {
            GlobalVariables.bReadFromBackup = true;
           // GlobalVariables.connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
            GlobalVariables.backupConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +  txtFileName.Text.ToString() + ";Persist Security Info=True;Jet OLEDB:Database Password=ven20081976";
            GlobalVariables.connection = GlobalVariables.backupConnection;
            MessageBox.Show("Backup Database Restored Successfully");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = "Browse DB Files";

                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;

                openFileDialog1.DefaultExt = "mdb";
                openFileDialog1.Filter = "db files (*.mdb)|*.mdb";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
