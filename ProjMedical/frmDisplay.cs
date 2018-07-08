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
    public partial class frmDisplay : Form
    {
        public frmDisplay(string sFileName)
        {
            InitializeComponent();
            //picDisplay.Image = Image.FromFile(sFileName);
            FileStream fs = new FileStream(sFileName, FileMode.Open, FileAccess.Read);
            Image img = Image.FromStream(fs);
            fs.Close();

            picDisplay.Image = img.Clone() as Image;
            img.Dispose();

            picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
