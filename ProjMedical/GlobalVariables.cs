using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMedical
{
    public class GlobalVariables
    {
        public static bool bReported { get; set; }
        public static bool bSimReport { get; set; }
        public static bool bImageCheck { get; set; }
        public static string sInvestigationReport { get; set; }
        public static string PIDD { get; set; }
        public static string PatientName { get; set; }
        public static string RefByDoc { get; set; }
        public static string InvDone { get; set; }
        public static string InvReq  { get; set;}
        public static int Age { get; set; }
        public static int VisitNo { get; set; }
        public static bool bReadFromBackup { get; set; }
        public static string connection { get; set; }
        public static string backupConnection { get; set; }
        public static string sFinalPath { get; set; }
        public static bool bWordList { get; set; }
        public static void CreateIfMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }
    }
}
