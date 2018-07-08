using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using ProjMedical;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PATIENT_LIST
{
    public partial class frmPatientList : Form
    {
        public frmPatientList()
        {
            InitializeComponent();
        }

        CultureInfo cultureInfo = new CultureInfo("en-IN");

        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
        string sPath = Path.GetFullPath(@"..\\..\\Reports");
        string deletePath = Path.GetFullPath(@"..\\..\\TempImages\\");
        string sQuery = "SELECT PatientID as [Patient ID], PatientName as [Patient Name], PDate as [Date], Age, Sex, RefDoc as [RefDoctor], InvDone as [ScanDone], InvName as [Investigation], Amount, Address FROM PatientDetails";
        string sWhereCondition = "";
        string stQuery = "";
        int totalRecords = 0;
        double totalAmount = 0;
        string deleteConfirmation = "";

        private void LoadPatientsList(string sQuery)
        {
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                PatientsdataGridView.DataSource = null;
                OleDbCommand cmd = new OleDbCommand(sQuery, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable datatable = new DataTable();
                da.Fill(datatable);

                PatientsdataGridView.RowHeadersVisible = false;
                PatientsdataGridView.DataSource = datatable;
                PatientsdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                PatientsdataGridView.MultiSelect = false;
                PatientsdataGridView.Columns[8].DefaultCellStyle.Format = "c2";
                PatientsdataGridView.Columns[8].DefaultCellStyle.FormatProvider = cultureInfo;
            }
            totalRecords = PatientsdataGridView.Rows.Count - 1;
            lblTotalRecords.Text = totalRecords.ToString();

            for (int row = 0; row < PatientsdataGridView.Rows.Count; row++)
            {
                totalAmount += Convert.ToDouble(PatientsdataGridView.Rows[row].Cells[8].Value);
            }
           
            string tAmt = string.Format(cultureInfo, "{0:C}", totalAmount);

            txtAmount.Text = tAmt.ToString();
            totalAmount = 0;
            totalRecords = 0;
        }

        private void frmPatientList_Load(object sender, EventArgs e)
        {
            LoadPatientsList(sQuery);

            cmbReportMode.Items.Clear();
            cmbReportMode.Items.Add("Daily");
            cmbReportMode.Items.Add("Monthly");
            cmbReportMode.Items.Add("Yearly");

            cmbSearchBy.Items.Clear();
            cmbSearchBy.Items.Add("Date Wise");
            cmbSearchBy.Items.Add("Done By");
            cmbSearchBy.Items.Add("Investigation");
            cmbSearchBy.Items.Add("Patient Name");
            cmbSearchBy.Items.Add("Ref Doc");

            cmbDelete.Items.Clear();
            cmbDelete.Items.Add("Single");
            cmbDelete.Items.Add("Daily");
            cmbDelete.Items.Add("Monthly");
            cmbDelete.Items.Add("Yearly");
            cmbDelete.Items.Add("All Records");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int selectedRowIndex = PatientsdataGridView.CurrentCell.RowIndex;

            string PatientID = PatientsdataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString();
            DeleteFromDb(PatientID);
            */

            deleteConfirmation = "No";
            string sDate = "";

            if (chkDeleteRecords.Checked == true)
            {
                if (cmbDelete.Text.ToString() == "Single")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete the selected Reord from the Database", "Delete Record", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        //GlobalVariables.PIDD = PatientsdataGridView.CurrentCell.RowIndex.ToString();
                        //GlobalVariables.PIDD = PatientsdataGridView.sel

                        if (GlobalVariables.PIDD == null)
                        {
                            return;
                        }

                        if (Directory.Exists(deletePath + GlobalVariables.PIDD))
                        {
                            Directory.Delete(deletePath + GlobalVariables.PIDD);
                        } 
                   }

                    deleteConfirmation = "Yes";
                }

                if (cmbDelete.Text.ToString() == "Daily")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete the selected Reord from the Database", "Delete Record", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        sDate = dateTimeDeleteRecords.Value.ToString("MM/dd/yyyy");
                        string stQuery = "Select * From PatientDetails Where PDate = #" + sDate + "#";
                        DeleteDirectory(stQuery);
                        deleteConfirmation = "Yes";
                    }
                }

                if (cmbDelete.Text.ToString() == "Monthly")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete the selected Reord from the Database", "Delete Record", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string stQuery = "Select * From PatientDetails Where Month(PDate) = " + dateTimeDeleteRecords.Value.Month + " And Year(PDate) = " + dateTimeDeleteRecords.Value.Year + ""; 
                        DeleteDirectory(stQuery);
                        deleteConfirmation = "Yes";
                    }
                }

                if (cmbDelete.Text.ToString() == "Yearly")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete the selected Reord from the Database", "Delete Record", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string stQuery = "Select * From PatientDetails Where Year(PDate) = " + dateTimeDeleteRecords.Value.Year + "";
                        DeleteDirectory(stQuery);
                        deleteConfirmation = "Yes";
                    }
                }

                if (cmbDelete.Text.ToString() == "All Records")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete the selected Reord from the Database", "Delete Record", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string stQuery = "Select * From PatientDetails";
                        DeleteDirectory(stQuery);
                        deleteConfirmation = "Yes";
                    }
                }
            }
            else
            {
                return;
            }

            if (deleteConfirmation == "Yes")
            {
                string sDQuery = "";
                if (cmbDelete.Text.ToString() == "Single")
                {
                    sDQuery = "Delete from PatientDetails Where PatientID = '" + GlobalVariables.PIDD + "'";
                    DeleteRecord(sDQuery);
                }
                if (cmbDelete.Text.ToString() == "Daily")
                {
                    sDate = dateTimeDeleteRecords.Value.ToString("MM/dd/yyyy");
                    sDQuery  = "Delete From PatientDetails Where PDate = #" + sDate + "#";
                    DeleteRecord(sDQuery);
                }
                if (cmbDelete.Text.ToString() == "Monthly")
                {
                    sDQuery = "Delete from PatientDetails Where Month(PDate) = " + dateTimeDeleteRecords.Value.Month + " And Year(PDate) = " + dateTimeDeleteRecords.Value.Year + "";
                    DeleteRecord(sDQuery);
                }
                if (cmbDelete.Text.ToString() == "Yearly")
                {
                    sDQuery = "Delete from PatientDetails Where YEAR(PDate)=  " + dateTimeDeleteRecords.Value.Year + "";
                    DeleteRecord(sDQuery);
                }
                if (cmbDelete.Text.ToString() == "All Records")
                {
                    sDQuery = "Delete from PatientDetails";
                    DeleteRecord(sDQuery);
                }
                LoadPatientsList(sQuery);
            }
        }

        private void DeleteRecord(string delQuery)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(delQuery, con);
                    int updated_records_count = cmd.ExecuteNonQuery();
                    if (updated_records_count > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully");
                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteDirectory(string sQry)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    OleDbCommand cmd = new OleDbCommand(sQry, con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var PID = reader["PatientID"].ToString();
                        if (Directory.Exists(deletePath + PID))
                        {
                            Directory.Delete(deletePath + PID);
                        }
                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteFromDb(string PatientID)
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Delete From PatientDetails where PatientID=@PatientID", con);
                cmd.Parameters.AddWithValue("@PatientID", PatientID);
                int updated_records_count = cmd.ExecuteNonQuery();
                if (updated_records_count > 0)
                {
                    MessageBox.Show("Record Deleted Successfully");
                    LoadPatientsList(sQuery);
                }
                con.Close();
            }
        }

        private void dateTimePickerMonthWise_ValueChanged(object sender, EventArgs e)
        {

            if (cmbSearchBy.Text.ToString()== "Ref Doc")
            {
                sWhereCondition = "  Where RefDoc = '" + cmbSearch.Text.ToString() + "' AND Year(PDate) = '" + dateTimePickerMonthWise.Value.Year + "' And Month(PDate) = '" + dateTimePickerMonthWise.Value.Month + "'";
                LoadPatientsList(sQuery + sWhereCondition);
            }

            if (cmbReportMode.Text.ToString() != "")
            {
                if (cmbReportMode.Text.ToString() == "Daily")
                {
                    sWhereCondition = " Where PDate = #" + dateTimePickerMonthWise.Value.ToString("MM/dd/yyyy") + "#";
                    LoadPatientsList(sQuery + sWhereCondition);
                }
                else if (cmbReportMode.Text.ToString() == "Monthly")
                {
                    sWhereCondition = "  Where Year(PDate) = '" + dateTimePickerMonthWise.Value.Year + "' And Month(PDate) = '" + dateTimePickerMonthWise.Value.Month + "'";
                    LoadPatientsList(sQuery + sWhereCondition);
                }
                else if (cmbReportMode.Text.ToString() == "Yearly")
                {
                    sWhereCondition = "  Where Year(PDate) = '" + dateTimePickerMonthWise.Value.Year + "'";
                    LoadPatientsList(sQuery + sWhereCondition);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            pd.Print();
        }

       
        private void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void checkAllRecords_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            lblreportmode.Visible = false;
            lblmonthwise.Visible = false;
            cmbSearch.Visible = false;
            cmbReportMode.Visible = false;
            dateTimePickerMonthWise.Visible = false;
            cmbSearchBy.Text = "";
           
            if (checkAllRecords.Checked)
            {
                LoadPatientsList(sQuery);
            }
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            try
            {
                lblmonthwise.Visible = false;
                txtSearch.Text = "";
                if (cmbSearchBy.Text.ToString() != "Date Wise")
                {
                    lblreportmode.Visible = false;
                    cmbReportMode.Visible = false;
                    dateTimePickerMonthWise.Visible = false;
                    txtSearch.Visible = false;
                    cmbSearch.Visible = true;
                }
                else
                {
                    cmbSearch.Visible = false;
                    lblreportmode.Visible = true;
                    cmbReportMode.Visible = true;
                    dateTimePickerMonthWise.Visible = true;
                }

                if (cmbSearchBy.Text.ToString() == "Date Wise")
                {
                    cmbSearch.Visible = false;
                    txtSearch.Visible = false;
                }
                else if (cmbSearchBy.Text.ToString() == "Ref Doc")
                {
                    cmbSearch.DataSource = null;
                    cmbSearch.DataBindings.Clear();
                    cmbSearch.Items.Clear();

                    using (OleDbConnection con = new OleDbConnection(connection))
                    {
                        con.Open();
                        string query = "Select Distinct DocName From ReferalDoc Where DocType = 'Referal Doctor'";
                        OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "ReferalDoc");
                        cmbSearch.DisplayMember = "DocName";
                        cmbSearch.ValueMember = "DocName";
                        cmbSearch.DataSource = ds.Tables["ReferalDoc"];
                        con.Close();
                    }

                    lblmonthwise.Visible = true;
                    dateTimePickerMonthWise.Visible = true;
                }
                else if (cmbSearchBy.Text.ToString() == "Done By")
                {
                    txtSearch.Visible = false;
                    cmbSearch.Visible = true;
                    cmbSearch.DataSource = null;
                    cmbSearch.DataBindings.Clear();
                    cmbSearch.Items.Clear();
                    using (OleDbConnection con = new OleDbConnection(connection))
                    {
                        con.Open();
                        string query = "Select Distinct DocName From ReferalDoc Where DocType = 'Consultant Doctor'";
                        OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "ConsultDoc");
                        cmbSearch.DisplayMember = "DocName";
                        cmbSearch.ValueMember = "DocName";
                        cmbSearch.DataSource = ds.Tables["ConsultDoc"];
                        con.Close();
                    }
                }
                else if (cmbSearchBy.Text.ToString() == "Investigation")
                {
                    txtSearch.Visible = false;
                    cmbSearch.Visible = true;
                    cmbSearch.DataSource = null;
                    cmbSearch.DataBindings.Clear();
                    cmbSearch.Items.Clear();

                    string[] arrFileNames = Directory.GetFiles(sPath);

                    for (int i = 0; i < arrFileNames.Length; i++)
                    {
                        arrFileNames[i] = Path.GetFileNameWithoutExtension(arrFileNames[i]);
                    }

                    cmbSearch.DataSource = arrFileNames;
                }
                else if (cmbSearchBy.Text.ToString() == "Patient Name")
                {
                    txtSearch.Visible = true;
                    cmbSearch.Visible = false;
                    dateTimePickerMonthWise.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilterData()
        {
            try
            {
                if (cmbSearchBy.Text.ToString() == "Ref Doc")
                {
                    sWhereCondition = " WHERE RefDoc = '" + cmbSearch.Text.ToString() + "'";
                    LoadPatientsList(sQuery + sWhereCondition);
                }
                else if (cmbSearchBy.Text.ToString() == "Done By")
                {
                    sWhereCondition = " WHERE InvDone  = '" + cmbSearch.Text.ToString() + "'";
                    LoadPatientsList(sQuery + sWhereCondition);
                }
                else if (cmbSearchBy.Text.ToString() == "Investigation")
                {
                    sWhereCondition = " WHERE InvName  = '" + cmbSearch.Text.ToString() + "'";
                    LoadPatientsList(sQuery + sWhereCondition);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cmbReportMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sWhereCondition = " WHERE PatientName like '*" +  txtSearch.Text.ToString()  + "*'";
            LoadPatientsList(sQuery + sWhereCondition);
        }

        private void chkDeleteRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeleteRecords.Checked)
            {
                dateTimeDeleteRecords.Visible = true;
                cmbDelete.Visible = true;
            }
            else
            {
                dateTimeDeleteRecords.Visible = true;
                cmbDelete.Visible = true;
            }
        }

        private void PatientsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GlobalVariables.PIDD = PatientsdataGridView.Rows[PatientsdataGridView.CurrentRow.Index].Cells["Patient ID"].Value.ToString();
        }
    }
}
