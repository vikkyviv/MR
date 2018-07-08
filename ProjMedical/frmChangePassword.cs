using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ChangeUsernameAndPassword
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtoldpwd.Text = "";
            txtnewpwd.Text = "";
            this.Close();
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connection);
            string oledb = "select count(*) from UserProfile where USERNAME='" + txtusername.Text + "', con";
            OleDbCommand cmd = new OleDbCommand(oledb, con);
            OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtnewpwd.Text == txtoldpwd.Text)
                {
                    OleDbDataAdapter ss = new OleDbDataAdapter("update UserProfile set PASSWORD='" + txtnewpwd.Text + "' where USERNAME='" + txtusername.Text + "' And PASSWORD='" + txtoldpwd.Text + "'", con);
                    DataTable df = new DataTable();
                    ss.Fill(df);
                    MessageBox.Show("password changes..!!", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {

                MessageBox.Show("Password Can't be more than 8 Characters");
            }
        }

        private void txtoldpwd_TextChanged(object sender, EventArgs e)
        {
            Validateoldpassword();
        }
        private bool Validateoldpassword()
        {
            bool bStatus = true;
            if (txtoldpwd.Text == "")
            {
                errorProvider1.SetError(txtoldpwd, "UnMatch Password");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtoldpwd, "");
            return bStatus;
        }

        private void txtnewpwd_TextChanged(object sender, EventArgs e)
        {
            validateNewPassword();
        }
        private bool validateNewPassword()
        {
            bool bStatus = true;
            if (txtoldpwd.Text == "")
            {
                errorProvider1.SetError(txtnewpwd, "UnMatch Password");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtnewpwd, "");
            return bStatus;

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            validateUserName();
        }
        private bool validateUserName()
        {
            bool bStatus = true;
            if (txtusername.Text == "")
            {
                errorProvider1.SetError(txtusername, "Enter your username");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtusername, "");
            return bStatus;
        }
    }
}





