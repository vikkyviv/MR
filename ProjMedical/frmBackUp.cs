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
    public partial class frmBackUp : Form
    {
        public frmBackUp()
        {
            InitializeComponent();
        }

        string sDefaultPath = Path.GetFullPath(@"..\\..\\");

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName.Text != "")
                {
                    File.Copy(sDefaultPath + "\\db1.mdb", txtFileName.Text.ToString());
                    MessageBox.Show("Database Backup Completed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = sDefaultPath;
                saveFileDialog1.Title = "Save text Files";
                //saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "mdb";
                saveFileDialog1.Filter = "Mdb files (*.mdb)|*.mdb";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = saveFileDialog1.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
