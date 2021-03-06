﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DetailsDoctors
{
    public partial class 
        frmDetailsDoctors : Form
    {

        public frmDetailsDoctors()
        {
            InitializeComponent();
            MaximizeBox = true;
        }
        private void LoadDataGrid()
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;

            OleDbConnection con = new OleDbConnection(connection);
            string oledb = "SELECT * FROM ReferalDoc";
            OleDbCommand cmd = new OleDbCommand(oledb, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            dataGridView2.DataSource = null;

            dataGridView2.DataSource = datatable;
        }
        private void Autogenerated()
        {
            // @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\123\Downloads\db1.mdb");
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select MAX(DocID) From ReferalDoc", con);
            string DId = (string)cmd.ExecuteScalar();
            string DIdstring = DId.Substring(1);
            int i = Convert.ToInt32(DIdstring);
            int j = i + 1;
            string iChar = Convert.ToString(i);
            string jChar = Convert.ToString(j);
            string DIdNew = DId.Replace(iChar, jChar);
            textBox1.Text = DIdNew;
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Autogenerated();
            ClearControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetControlValueToGrid();
            ClearControls();
            //btnEdit.Enabled = true;
            //btnAddNew.Enabled = true;
            Autogenerated();
            //save();
        }
        private void ClearControls()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            comboBox2.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            ClearControls();
        }
        private void SetGridValuesToControls()
        {
            Int32 selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            textBox1.Text = dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString(); //docid --0
            textBox2.Text = dataGridView2.Rows[selectedRowIndex].Cells[1].Value.ToString();    //DocName -- 1
            textBox3.Text = dataGridView2.Rows[selectedRowIndex].Cells[2].Value.ToString();   //Specilist -- 2
            textBox4.Text = dataGridView2.Rows[selectedRowIndex].Cells[3].Value.ToString();  //Address -- 3
            textBox5.Text = dataGridView2.Rows[selectedRowIndex].Cells[4].Value.ToString();     // PhoneNo -- 4
            textBox6.Text = dataGridView2.Rows[selectedRowIndex].Cells[5].Value.ToString();    // CellNo -- 5
            textBox7.Text = dataGridView2.Rows[selectedRowIndex].Cells[6].Value.ToString();   // Percentage  -- 6
            comboBox2.Text = dataGridView2.Rows[selectedRowIndex].Cells[7].Value.ToString();  // DocType -- 7
        }

        private void SetControlValueToGrid()
        {
            string DocId = textBox1.Text;
            string DocName = textBox2.Text;
            string Specilist = textBox3.Text;
            string Address = textBox7.Text;
            double PhoneNo = (textBox5.Text == "") ? 0 : Convert.ToDouble(textBox5.Text);
            double CellNo = (textBox6.Text == "") ? 0 : Convert.ToDouble(textBox6.Text);
            double Percentage = (textBox4.Text == "") ? 0 : Convert.ToDouble(textBox4.Text);
            string DocType = comboBox2.Text;
            string Operation;

            if (SaveDataToDatabase(DocId, DocName, Specilist, Address, PhoneNo, CellNo, Percentage, DocType, out Operation) == 1)
            {
                Int32 selectedRowIndex;
                if (Operation == "Update")
                {
                    selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
                    dataGridView2.Rows[selectedRowIndex].Cells[0].Value = DocId;  //docid --0
                    dataGridView2.Rows[selectedRowIndex].Cells[1].Value = DocName; //DocName -- 1
                    dataGridView2.Rows[selectedRowIndex].Cells[2].Value = Specilist; //Specilist -- 2
                    dataGridView2.Rows[selectedRowIndex].Cells[3].Value = Address;  //Address -- 3
                    dataGridView2.Rows[selectedRowIndex].Cells[4].Value = PhoneNo;// // PhoneNo -- 4
                    dataGridView2.Rows[selectedRowIndex].Cells[5].Value = CellNo; //CellNo-- 5
                    dataGridView2.Rows[selectedRowIndex].Cells[6].Value = Percentage;   // Percentage  -- 6
                    dataGridView2.Rows[selectedRowIndex].Cells[7].Value = DocType;// DocType -- 7
                }
                else
                {

                    LoadDataGrid();
                }


            }
        }


        private void frmDetailsDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet2.ReferalDoc' table. You can move, or remove it, as needed.
            // this.referalDocTableAdapter2.Fill(this.db1DataSet2.ReferalDoc);
            LoadDataGrid();
        }
        //ADD NEW BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Autogenerated();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;


        }
        //EDIT
        private void button3_Click_1(object sender, EventArgs e)
        {
            SetGridValuesToControls();
            button3.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
            //string Selected = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            //int DocId = int.Parse(Selected);
            //update();
        }
        //SAVE BUTTON
        private void button2_Click_1(object sender, EventArgs e)
        {
            SetControlValueToGrid();
            ClearControls();
            button3.Enabled = true;
            button1.Enabled = true;
            ValidateDoctorID();
            ValidateDoctorName();
            //ValidateDocType();


        }

        private int SaveDataToDatabase(string DocId, string DocName, string Specilist, string Address, double PhoneNo, double CellNo, double Percentage, string DocType, out string Operation)
        {
            Operation = "";

            int updated_records_count = 0;

            try
            {
                string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select count(*) from ReferalDoc where DocId= @DocId", con);
                    cmd1.Parameters.AddWithValue("@DocId", DocId);
                    int count = (int)cmd1.ExecuteScalar();
                    OleDbCommand command;
                    if (count > 0)
                    {
                        Operation = "Update";
                        command = new OleDbCommand(@"UPDATE ReferalDoc SET DocName = @DocName,Specilist = @Specilist,Address = @Address,PhoneNo = @PhoneNo,CellNo = @CellNo,Percentage = @Percentage,DocType = @DocType  WHERE DocId = @DocId", con);
                    }
                    else
                    {
                        Operation = "insert";

                        command = new OleDbCommand(@"insert into ReferalDoc (DocId,DocName,Specilist,Address,PhoneNo,CellNo,Percentage,DocType) values(@DocId, @DocName, @Specilist,@Address,@PhoneNo,@CellNo, @Percentage,@DocType)", con);
                    }
                    command.Parameters.AddWithValue("@DocId", DocId);

                    command.Parameters.AddWithValue("@DocName", DocName);
                    command.Parameters.AddWithValue("@Specilist", Specilist);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                    command.Parameters.AddWithValue("@CellNo", CellNo);
                    command.Parameters.AddWithValue("@Percentage", Percentage);
                    command.Parameters.AddWithValue("@DocType", DocType);

                    updated_records_count = command.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return updated_records_count;
        }
        //DELETE BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            string DocId = dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString();
            DeleteFromDb(DocId);
        }

        private void DeleteFromDb(string DocId)
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;

            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete From ReferalDoc where DocId=@DocId", con);
            cmd.Parameters.AddWithValue("@DocId", DocId);
            int updated_records_count = cmd.ExecuteNonQuery();
            if (updated_records_count > 0)
            {
                MessageBox.Show("Record Deleted Successfully");
                LoadDataGrid();
            }
            con.Close();
        }
        //CANCEL BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            ClearControls();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }
        //EXIT BUTTON
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateDoctorID();
        }
        private bool ValidateDoctorID()
        {
            bool bstatus = true;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please Enter DoctorID");
                bstatus = false;
            }
            else
                errorProvider1.SetError(textBox1, "");
            return bstatus;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidateDoctorName();
        }
        private bool ValidateDoctorName()
        {
            bool bstatus = true;
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Please Enter DoctorName");
                bstatus = false;
            }
            else
                errorProvider1.SetError(textBox2, "");
            return bstatus;
        }
        // boolFormValid =true;
        // //
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    ValidateDocType();
        }
        //private void ValidateDocType()
        //{
        //    if(comboBox2.SelectedItem.ToString()=="---selectDocType---")
        //    {
        //        errorProvider1.SetError(comboBox2, "Please Select DocType");
        //       boolFormValid = false;
        //        return;

        //    }
        //    else
        //    {
        //        errorProvider1.SetError(comboBox2, "");
        //    }

        //}




    }


}










