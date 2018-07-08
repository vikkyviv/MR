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
using VIDEOCAPLib;
using System.Windows.Forms;

namespace ProjMedical
{
    public partial class frmCaptureDevice : Form
    {
        public frmCaptureDevice()
        {
            InitializeComponent();
        }

        Device myDevice;
        VideoFormat myVideoFormat;
        AudioCompressor myAudioCompressor;
        AudioDevice myAudioDevice;
        VideoCompressor myVideoCompressor;
        VideoInput myVideoInput;

        string sVideoSettingsFile = Path.GetFullPath(@"..\\..\\VideoProperty.txt");
        //string connection = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;
        string connection = GlobalVariables.connection;

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    int iRecordCount = 0;
                    string sQuery = "Select Count(*) From VideoDeviceSettings";
                    OleDbCommand cmd = new OleDbCommand(sQuery, con);
                    con.Open();
                    iRecordCount = (int)cmd.ExecuteScalar();

                    if (iRecordCount > 0)
                    {
                        sQuery = "Update VideoDeviceSettings SET VideoDevice=@VideoDevice, VideoConnector=@VideoConnector,  VideoStandard=@VideoStandard, VideoFormat=@VideoFormat, VideoCompression=@VideoCompression";
                    }
                    else if (iRecordCount == 0)
                    {
                        sQuery = "INSERT INTO VideoDeviceSettings (VideoDevice, VideoConnector, VideoStandard,  VideoFormat, VideoCompression) VALUES (@VideoDevice, @VideoConnector, @VideoStandard,  @VideoFormat, @VideoCompression)";
                    }

                    OleDbCommand command = new OleDbCommand(sQuery, con);

                    command.Parameters.AddWithValue("@VideoDevice", cmbVideoDevice.SelectedIndex);
                    command.Parameters.AddWithValue("@VideoConnector", cmbConnectors.SelectedIndex);
                    command.Parameters.AddWithValue("@VideoStandard", cmbStandards.SelectedIndex);
                    command.Parameters.AddWithValue("@VideoFormat", cmbFormats.SelectedIndex);
                    command.Parameters.AddWithValue("@VideoCompression", cmbCompression.SelectedIndex);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCaptureDevice_Load(object sender, EventArgs e)
        {
            cmbVideoDevice.Items.Clear();
            cmbCompression.Items.Clear();
            cmbConnectors.Items.Clear();
            cmbStandards.Items.Clear();
            cmbFormats.Items.Clear();

            FrmCaptureImage.frmCaptureImage fCapture = new FrmCaptureImage.frmCaptureImage();

            try
            {
                if (CheckOpened("CAPTURE IMAGE"))
                {
                    if (fCapture.axVideoCap1.Devices.Count <= 0)
                    {
                        MessageBox.Show("No Video device is connected to PCI slot, if connected please check the hardware drivers installed or not. \n Still if you get problem please contact software vendor.");
                        btnOK.Enabled = false;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please open New Patient Screen to set Video settings");
                    btnOK.Enabled = false;
                    return;
                }

                if (File.Exists(sVideoSettingsFile))
                {
                    FileInfo file = new FileInfo(sVideoSettingsFile);

                    if (file.Length == 0)
                    {
                        MessageBox.Show("Please remove " + sVideoSettingsFile + " file and re run the application");
                        btnOK.Enabled = false;
                        return;
                    }

                    string line = "";
                    using (StreamReader sr = new StreamReader(sVideoSettingsFile))
                    {
                        if ((line = sr.ReadLine()) != "VideoDeviceName:")
                        {
                            MessageBox.Show("Please remove " + sVideoSettingsFile + " file and re run the application");
                            btnOK.Enabled = false;
                            sr.Close();
                        }

                    }
                }
                else
                {
                    // Create a new file 
                    using (StreamWriter sw = File.CreateText(sVideoSettingsFile))
                    {
                        sw.WriteLine("VideoDeviceName:");
                        foreach (Device myDevice in fCapture.axVideoCap1.Devices)
                        {
                            sw.WriteLine(myDevice.Name);
                        }

                        sw.WriteLine("VideoFormat:");
                        foreach (VideoFormat myVideoFormat in fCapture.axVideoCap1.VideoFormats)
                        {
                            sw.WriteLine(myVideoFormat.Name);
                        }


                        sw.WriteLine("VideoInputs:");
                        foreach (VideoInput myVideoInput in fCapture.axVideoCap1.VideoInputs)
                        {
                            sw.WriteLine(myVideoInput.Name);
                        }


                        sw.WriteLine("VideoCompressors:");
                        foreach (VideoCompressors myVideoCompressor in fCapture.axVideoCap1.VideoCompressors)
                        {
                            sw.WriteLine(myVideoCompressor.ToString());
                        }

                        sw.Close();
                    }
                }

                string sText = "";
                string[] lines = File.ReadAllLines(sVideoSettingsFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];

                    if (line == "VideoDeviceName:")
                    {
                        sText = "VideoDeviceName:";
                        i = i + 1;
                    }
                    else if (line == "VideoFormat:")
                    {
                        sText = "VideoFormat:";
                        i = i + 1;
                    }
                    else if (line == "VideoInputs:")
                    {
                        sText = "VideoInputs:";
                        i = i + 1;
                    }
                    else if (line == "VideoCompressors:")
                    {
                        sText = "VideoCompressors:";
                        i = i + 1;
                    }

                    switch (sText)
                    {
                        case "VideoDeviceName:":
                            cmbVideoDevice.Items.Add(lines[i]);
                            break;
                        case "VideoFormat:":
                            cmbFormats.Items.Add(lines[i]);
                            break;
                        case "VideoInputs:":
                            cmbConnectors.Items.Add(lines[i]);
                            break;
                        case "VideoCompressors:":
                            cmbCompression.Items.Add(lines[i]);
                            break;

                    }

                }

                /*
             
                using (StreamReader sr = new StreamReader(sVideoSettingsFile))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "VideoDeviceName:")
                        {
                            sText = "VideoDeviceName:";
                        }
                        else if (line == "VideoFormat:")
                        {
                            sText = "VideoFormat:";
                        }
                        else if (line == "VideoInputs:")
                        {
                            sText = "VideoInputs:";
                        }
                        else if (line == "VideoCompressors:")
                        {
                            sText = "VideoCompressors:";
                        }

                        switch (sText)
                        {
                            case "VideoDeviceName:":
                                cmbVideoDevice.Items.Add(sr.ReadLine());
                                break;
                            case "VideoFormat:":
                                cmbFormats.Items.Add(sr.ReadLine());
                                break;
                            case "VideoInputs:":
                                cmbConnectors.Items.Add(sr.ReadLine());
                                break;
                            case "VideoCompressors:":
                                cmbCompression.Items.Add(sr.ReadLine());
                                break;

                        }

                    }
                }
                */

                cmbStandards.Items.Add("Digital sensor");
                cmbStandards.Items.Add("NTSC (M) standard, 7.5 IRE black");
                cmbStandards.Items.Add("NTSC (M) standard, 0 IRE black (Japan)");
                cmbStandards.Items.Add("NTSC-433");
                cmbStandards.Items.Add("PAL -B standard");
                cmbStandards.Items.Add("PAL (D) standard");
                cmbStandards.Items.Add("PAL (H) standard");
                cmbStandards.Items.Add("PAL (I) standard");
                cmbStandards.Items.Add("PAL (M) standard");
                cmbStandards.Items.Add("PAL (N) standard");
                cmbStandards.Items.Add("PAL-60 standard");
                cmbStandards.Items.Add("SECAM (B) standard");
                cmbStandards.Items.Add("SECAM (D) standard");
                cmbStandards.Items.Add("SECAM (G) standard");
                cmbStandards.Items.Add("SECAM (H) standard");
                cmbStandards.Items.Add("SECAM (K) standard");
                cmbStandards.Items.Add("SECAM (K1) standard");
                cmbStandards.Items.Add("SECAM (L) standard");
                cmbStandards.Items.Add("SECAM (L1) standard");
                cmbStandards.Items.Add("Combination (N) PAL standard (Argentina)");
                cmbStandards.SelectedText = "Digital sensor";
              
                using (OleDbConnection con = new OleDbConnection(connection))
                {
                    string sQuery = "Select * From VideoDeviceSettings";
                    OleDbCommand cmd = new OleDbCommand(sQuery, con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cmbVideoDevice.SelectedIndex = Convert.ToInt32(reader["VideoDevice"].ToString());
                        cmbConnectors.SelectedIndex = Convert.ToInt32(reader["VideoConnector"].ToString());
                        cmbStandards.SelectedIndex = Convert.ToInt32(reader["VideoStandard"].ToString());
                        cmbFormats.SelectedIndex = Convert.ToInt32(reader["VideoFormat"].ToString());
                        cmbCompression.SelectedIndex = Convert.ToInt32(reader["VideoCompression"].ToString());
                    }
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
