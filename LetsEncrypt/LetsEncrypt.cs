﻿using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Net;
using System.Threading;

namespace LetsEncrypt
{
    public partial class LetsEncrypt : Form
    {
        LogWriter logi = new LogWriter();
        string sname, sport, suser, spwd;
        public LetsEncrypt()
        {
            InitializeComponent();
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
            logfile();
            ReadXML();
        }
        /// <summary>
        /// after adding IP/Host in settings form it restart the application to read the xml files with the ip/host
        /// </summary>
        public void ReloadIP()
        {
            try
            {
                //MessageBox.Show("Please wait Application is loading Information");
                Application.Restart();
            }
            catch (Exception ex)
            {
                logi.LogMessage("Reload IP data error " + ex.Message);
            }
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
        private void ReadXML()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("Server.xml"))
            {
                Login login = new Login();
                login.ServerSet();
            }
            else
            {
                xmlDoc.Load("Server.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Server");
                string ServerId = "", ServerName = "", Port = "", User = "", Password = "";
                foreach (XmlNode node in nodeList)
                {
                    ServerId = node.SelectSingleNode("Server_ID").InnerText;
                    ServerName = node.SelectSingleNode("Server_Name").InnerText;
                    Port = node.SelectSingleNode("Server_port").InnerText;
                    User = node.SelectSingleNode("User_Name").InnerText;
                    Password = node.SelectSingleNode("Password").InnerText;
                }
                string DecryptPWD = Encoding.Unicode.GetString(Convert.FromBase64String(Password));
                sname = ServerName;
                sport = Port;
                suser = User;
                spwd = DecryptPWD;
            }
        }

        private void btnValidateCert_Click(object sender, EventArgs e)
        {
            RunValidation();
        }

        private void btnRenewCert_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => RenewCertDomain());
            thread.Start();
            //RenewCertDomain();
        }
        private void RenewCertDomain()
        {
            try
            {
                string results, results2;
                SshClient ssh = new SshClient(sname, 22, suser, spwd);
                if (sname == string.Empty)
                {
                    return;
                }
                else
                {
                    //rtbResult.AppendText("Please wait....\n");
                    var timeout = TimeSpan.FromSeconds(3);
                    var client = new TcpClient();
                    if (!client.ConnectAsync(sname, 22).Wait(timeout))
                    {
                        rtbResults.AppendText("Unable to Connect please check your IP / Host \n");
                        ssh.Disconnect();
                        ssh.Dispose();
                        return;
                    }
                    else
                    {
                        ssh.Connect();
                    }
                    SshCommand sshcc = ssh.RunCommand("service apache2 stop");
                    results2 = sshcc.Result;
                    rtbResults.AppendText(results2 + "\n");
                    SshCommand sshc = ssh.RunCommand("cd letsencrypt/ && ./letsencrypt-auto renew");// certonly --standalone -d " + CBCertList.Text);
                    results = sshc.Result;
                    rtbResults.AppendText(results);
                    SshCommand sshccc = ssh.RunCommand("service apache2 start");
                    results2 = sshccc.Result;
                    rtbResults.AppendText(results2 + "\n");
                    //rtbResult.AppendText("**********************************************************************************************************\n");
                    logi.LogMessage(sshc.Error);
                    logi.LogMessage(sshcc.Error);
                    logi.LogMessage(sshccc.Error);
                }
            }
            catch(Exception ex)
            {
                logi.LogMessage(ex.Message);
            }
        }
        public void RunValidation()
        {
            Uri u = new Uri("https://"+CBCertList.Text+"/");
            ServicePoint sp = ServicePointManager.FindServicePoint(u);

            string groupName = Guid.NewGuid().ToString();
            HttpWebRequest req = HttpWebRequest.Create(u) as HttpWebRequest;
            req.Accept = "*/*";
            req.ConnectionGroupName = groupName;

            using (WebResponse resp = req.GetResponse())
            {
                // Ignore response, and close the response.
            }
            sp.CloseConnectionGroup(groupName);

            // Implement favourite null check pattern here on sp.Certificate
            string expiryDate = sp.Certificate.GetExpirationDateString();

            string str = expiryDate;
            rtbResults.AppendText("Experation Cert Date for domain : "+CBCertList.Text+" "+str+"\n");
        }
        private void GetCertList()
        {
            try
            {
                string results;
                string[] slines, Cname;
                char[] Linedelim = { ';' };
                char[] delim = { ' ','\t' };
                string NewResult;
                SshClient ssh = new SshClient(sname, 22, suser, spwd);
                if (sname == string.Empty)
                {
                    return;
                }
                else
                {
                    //rtbResult.AppendText("Please wait....\n");
                    var timeout = TimeSpan.FromSeconds(3);
                    var client = new TcpClient();
                    if (!client.ConnectAsync(sname, 22).Wait(timeout))
                    {
                        rtbResults.AppendText("Unable to Connect please check your IP / Host \n");
                        ssh.Disconnect();
                        ssh.Dispose();
                        return;
                    }
                    else
                    {
                        ssh.Connect();
                    }
                    SshCommand sshc = ssh.RunCommand("cd /etc/letsencrypt/live && ls -1");
                    results = sshc.Result;
                    //rtbResult.AppendText(results);
                    //rtbResult.AppendText("**********************************************************************************************************\n");
                    logi.LogMessage(sshc.Error);
                    NewResult = Regex.Replace(results, @"\s+", " ", RegexOptions.Multiline);
                    slines = NewResult.Split(Linedelim);
                    List<string> services = new List<string>();
                    int i = 0;
                    Cname = slines[i].Split(delim);
                    services.Add("Select Cert ");
                    for (i = 0;i < Cname.Length;i++)
                    {
                        services.Add(Cname[i]);
                    }
                    CBCertList.DataSource = services;
                }
            }
            catch (Exception ex)
            {
                logi.LogMessage(ex.Message);
                MessageBox.Show(this, "Sorry!!! only Linux Or Unix machine  \n");
            }
        }
        private void btnGetCertList_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => GetCertList());
            thread.Start();
            //GetCertList();
        }
    }
}
