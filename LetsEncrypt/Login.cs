using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LetsEncrypt
{
    public partial class Login : Form
    {
        LogWriter logi = new LogWriter();
        string machine = "1232";
        string userName="test";
        string password = "123";
        public Login()
        {
            InitializeComponent();
            tbServer.Text = machine;
            ReadXML();
            CheckUser();
            
        }
        private void CheckUser()
        {
            if(machine == string.Empty)
            {
                tbServer.Text = "Machine IP Or Host name is not defined";
            }
            if (userName == string.Empty)
            {
                tbMuser.Text = "User is not defined";
            }
            if (password == string.Empty)
            {
                tbMPwd.Text = "Password is not defined";
            }
        }
        private void checkIPResponse()
        {
            try
            {
                Ping ping = new Ping();
                PingReply pingReply;
                //PingReply pingReply = ping.Send(tbIPHost.Text);
                if (tbServer.Text == string.Empty)
                {
                    MessageBox.Show("Please enter IP / Host Name for server name\n");
                    tbServer.BackColor = Color.CadetBlue;
                    return;
                }
                else
                {
                    tbServer.BackColor = Color.White;
                    pingReply = ping.Send(tbServer.Text);
                    if (pingReply.Status == IPStatus.TimedOut)
                    {
                        MessageBox.Show("No Ping to " + tbServer.Text + "\n");
                    }
                    else if (pingReply.Status == IPStatus.Success)
                    {
                        SshClient ssh = new SshClient(tbServer.Text, 22, userName, password);
                        ssh.Connect();
                        SshCommand sshcmd = ssh.RunCommand("uname");
                        string res = sshcmd.Result;
                        string osTypeHost1 = res;
                        string osType = res;
                        MessageBox.Show("Server : " + tbServer.Text + "  Ping OK" + " | " + "OS Type : " + res + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                logi.LogMessage("ping server " + ex.Message);
            }
        }
        private void ReadXML()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("Server.xml"))
            {
                ServerSet();
            }
            else
            {
                xmlDoc.Load("Server.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Server");
                string ServerId = "", ServerName = "",User="" ,Password = "";
                foreach (XmlNode node in nodeList)
                {
                    ServerId = node.SelectSingleNode("Server_ID").InnerText;
                    ServerName = node.SelectSingleNode("Server_Name").InnerText;
                    User = node.SelectSingleNode("User_Name").InnerText;
                    Password = node.SelectSingleNode("Password").InnerText;
                }
                tbServer.Text = ServerName;
                tbMuser.Text = User;
                tbMPwd.Text = Password;

            }
        }
        public void ServerSet()
        {
            string EncryptPWD;
            machine = tbServer.Text;
            userName = tbMuser.Text;
            password = tbMPwd.Text;
            EncryptPWD = Convert.ToBase64String(Encoding.Unicode.GetBytes(password));
            XmlTextWriter writer = new XmlTextWriter("Server.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            //createNode("1",machine ,userName, EncryptPWD, writer);
            createNode("1", tbServer.Text, userName, EncryptPWD, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        private void createNode(string pID, string pSName,string Usr ,string pwd,XmlTextWriter writer)
        {
            writer.WriteStartElement("Server");
            writer.WriteStartElement("Server_ID");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Server_Name");
            writer.WriteString(pSName);
            writer.WriteEndElement();
            writer.WriteStartElement("User_Name");
            writer.WriteString(Usr);
            writer.WriteEndElement();
            writer.WriteStartElement("Password");
            writer.WriteString(pwd);
            writer.WriteEndElement();
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please be noted that empty row will delete the current data", "Are you sure ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tbServer.Clear();
                tbMuser.Clear();
                tbMPwd.Clear();
                ServerSet();
                ReadXML();
                checkIPResponse();
                MessageBox.Show("Machine IP/Hostname & User Password was set successfully \n");
                logi.LogMessage("Machine IP/Hostname & User Password was set successfully \n");
                
            }
            else if (dialogResult == DialogResult.No)
            {
                tbServer.Clear();
                tbMuser.Clear();
                tbMPwd.Clear();
                MessageBox.Show("Machine IP/Host & User Password was Unset \n");
            }
        }
    }
}
