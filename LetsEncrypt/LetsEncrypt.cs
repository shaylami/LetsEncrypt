using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsEncrypt
{
    public partial class LetsEncrypt : Form
    {
        LogWriter logi = new LogWriter();
        public LetsEncrypt()
        {
            InitializeComponent();
            logfile();
        }
        private void logfile()
        {
            try
            {
                if (!System.IO.Directory.Exists("C://LetsEncryptLogfolder"))
                {
                    System.IO.Directory.CreateDirectory("C:\\LetsEncryptLogfolder//");
                    logi.LogMessage("Dir C:\\LetsEncryptLogfolder was created");
                }
                if (!System.IO.File.Exists("C://LetsEncryptLogfolder//LetsEncryptLog.txt"))
                {
                    System.IO.File.Create("C:\\LetsEncryptLogfolder\\LetsEncryptLog.txt");
                    logi.LogMessage("File C:\\LetsEncryptLogfolder\\LetsEncryptLog.txt was created");
                }
            }
            catch (Exception ex)
            {
                logi.LogMessage("log file opration error " + ex.Message);
                MessageBox.Show("Error: unable to create local logs folder for logs file please check permissions to C: Drive");
            }
        }
        private void btnLoginServer_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
