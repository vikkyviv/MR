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

namespace Dictionary
{


    public partial class frmDictionary : Form
    {
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;


        public frmDictionary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fill_listview1();

        }
        //ADD TO LV
        private void fill_listview1()
        {
            listBox1.Items.Clear();
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand("select Words From Dictionary", con);
            con.Open();

            cmd.CommandType = CommandType.Text;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["Words"].ToString());
            }
            con.Close();
        }

        private void Insert_Update()
        {
            int index = listBox1.FindString(txtAddWord.Text);
            if (index == -1)
            {
                OleDbConnection con = new OleDbConnection(connection);
                OleDbCommand cmd = new OleDbCommand("insert into Dictionary values('" + txtAddWord.Text + "')", con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                txtAddWord.Text = "";
                fill_listview1();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_Update();
            MessageBox.Show("Record inserted successfully");

        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            Delete(curItem);
            Insert_Update();
            MessageBox.Show("Record updated successfully");


        }

        private void Delete(string deletetxt)
        {
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand("delete from Dictionary where Words='" + deletetxt + "'", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            fill_listview1();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            Delete(txtAddWord.Text);
            txtAddWord.Text = "";
            MessageBox.Show("Record deleted successfully");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtAddWord.Text = "";


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Are you sure you want to exit application?", "Exit", MessageBoxButtons.YesNo);
            //if (dr == DialogResult.Yes)

            //{

            //    Application.Exit();

            //}
            this.Close();
            this.Dispose();

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //xtAddWord.Text= listview1.SelectedItems[0].SubItems[0].Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string curItem = listBox1.SelectedItem.ToString();
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand("select * from Dictionary where Words='" + curItem + "'", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtAddWord.Text = dr["Words"].ToString();
            }
            con.Close();

        }
    }
}
