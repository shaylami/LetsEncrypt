using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsEncrypt
{
    class LogWriter
    {
        /// <summary>
        /// grep errors from the code and input in c:\\ as NBUConLog.txt file
        /// </summary>
        /// <param name="msg"></param>
        public void LogMessage(string msg)
        {
            try
            {
                string sFilePath = @"C:\LetsEncryptLog.txt"; //log will saved on local computer
                StreamWriter sw1 = File.AppendText(sFilePath);
                try
                {
                    string logLine = System.String.Format("{0:G}: {1}.", System.DateTime.Now, msg);
                    sw1.WriteLine(logLine);


                }
                finally
                {
                    sw1.Close();
                }
            }
            catch { }
        }
    }
}


