using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ProjMedical
{
    public partial class frmImageEdgeCut : Form
    {
        public frmImageEdgeCut()
        {
            InitializeComponent();
        }

        string sFileExt = ".jpg";
        string imgPath = Path.GetFullPath(@"..\\..\\Icons\\ImageSize.jpg");
        string imgPath1 = Path.GetFullPath(@"..\\..\\Icons\\ImageSize.jpeg");
        string tempImagePath = Path.GetFullPath(@"..\\..\\TempImages\\");
        Image defaultImage, im;


        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg)|*.jpg| All Files (*.*)|*.*";
                open.InitialDirectory = tempImagePath;
                if (open.ShowDialog() == DialogResult.OK)
                {
                   
                    im = GetCopyImage(open.FileName);
                    pictureBox1.Image = im;
                    //pictureBox1.Image = Image.FromFile(open.FileName);

                    //pictureBox2.Image = Image.FromFile(open.FileName);
                    txtHeight_TextChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLeft_TextChanged(object sender, EventArgs e)
        {

            label5.Text = pictureBox1.Image.Width.ToString();
            label6.Text = pictureBox1.Image.Height.ToString();

            if (!String.IsNullOrEmpty(txtHeight.Text))
            {
                pictureBox2.Height = Convert.ToInt32(txtHeight.Text);
            }

            if (!String.IsNullOrEmpty(txtWidth.Text))
            {
                pictureBox2.Width = Convert.ToInt32(txtWidth.Text);
            }

            pictureBox2.Image = pictureBox1.Image;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; 
        }

        private void frmImageEdgeCut_Load(object sender, EventArgs e)
        {

            im = GetCopyImage(@imgPath);
            pictureBox1.Image = im;
            //pictureBox1.Image = Image.FromFile(imgPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap img = new Bitmap(imgPath);
            txtLeft.Text = pictureBox1.Location.X.ToString();
            txtTop.Text = pictureBox1.Location.Y.ToString();
            txtWidth.Text = img.Width.ToString();
            txtHeight.Text = img.Height.ToString();

            if ((string.IsNullOrWhiteSpace(txtLeft.Text)) && (string.IsNullOrWhiteSpace(txtTop.Text)))
            {
                txtLeft.Text = "10";
                txtTop.Text = "10";
                txtWidth.Text = "10";
                txtHeight.Text = "10";
                txtLeft_TextChanged(sender, e);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtWidth.Text) > Convert.ToInt32(label5.Text))
                {
                    MessageBox.Show("Width Value should not corss the range");
                    txtWidth.Focus();
                    return;
                }

                if (Convert.ToInt32(txtHeight.Text) > Convert.ToInt32(label6.Text))
                {
                    MessageBox.Show("Height Value should not corss the range");
                    txtHeight.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtHeight.Text))
                {
                    MessageBox.Show("Height Can't be empty");
                    return;
                }

                if (string.IsNullOrEmpty(txtWidth.Text))
                {
                    MessageBox.Show("Width Can't be empty");
                    return;
                }

                if (string.IsNullOrEmpty(txtTop.Text))
                {
                    MessageBox.Show("Top can't be empty");
                    return;
                }

                if (string.IsNullOrEmpty(txtLeft.Text))
                {
                    MessageBox.Show("Left can't be empty");
                    return;
                }

                //pictureBox1.Image.Dispose();
                //File.SetAttributes(imgPath, FileAttributes.Normal);
                //im.Dispose();
                
                if (File.Exists(imgPath))
                {
                    //File.Delete(imgPath);
                }

                pictureBox1.Image.Save(@imgPath1, ImageFormat.Jpeg);
                
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }

                if ((e.KeyChar < (char)48) || (e.KeyChar > (char)57))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTop_TextChanged(object sender, EventArgs e)
        {
            label6.Text = pictureBox1.Image.Height.ToString();

            if (!String.IsNullOrEmpty(txtHeight.Text))
            {
                pictureBox2.Height = Convert.ToInt32(txtHeight.Text);
            }

            if (!String.IsNullOrEmpty(txtWidth.Text))
            {
                pictureBox2.Width = Convert.ToInt32(txtWidth.Text);
            }

            pictureBox2.Image = pictureBox1.Image;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }

                if ((e.KeyChar < (char)48) || (e.KeyChar > (char)57))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtHeight.Text))
            {
                pictureBox2.Height = Convert.ToInt32(txtHeight.Text);
            }

            if (!String.IsNullOrEmpty(txtWidth.Text))
            {
                pictureBox2.Width = Convert.ToInt32(txtWidth.Text);
            }

            pictureBox2.Image = pictureBox1.Image;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }

                if ((e.KeyChar < (char)48) || (e.KeyChar > (char)57))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHeight.Text))
            {
                pictureBox2.Height = Convert.ToInt32(txtHeight.Text);
            }

            if (!String.IsNullOrEmpty(txtWidth.Text))
            {
                pictureBox2.Width = Convert.ToInt32(txtWidth.Text);
            }

            pictureBox2.Image = pictureBox1.Image;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }

                if ((e.KeyChar < (char)48) || (e.KeyChar > (char)57))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
               
                Bitmap bm = new Bitmap(im);
                im.Dispose();
                return bm;
            }
        }
    }
}
