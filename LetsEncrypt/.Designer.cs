namespace LetsEncrypt
{
    partial class LetsEncrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnLoginServer = new System.Windows.Forms.Button();
            this.btnGetCertList = new System.Windows.Forms.Button();
            this.btnValidateCert = new System.Windows.Forms.Button();
            this.btnRenewCert = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CBCertList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbResults);
            this.groupBox1.Location = new System.Drawing.Point(12, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // rtbResults
            // 
            this.rtbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtbResults.Location = new System.Drawing.Point(7, 20);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(817, 228);
            this.rtbResults.TabIndex = 0;
            this.rtbResults.Text = "";
            // 
            // btnLoginServer
            // 
            this.btnLoginServer.Location = new System.Drawing.Point(12, 62);
            this.btnLoginServer.Name = "btnLoginServer";
            this.btnLoginServer.Size = new System.Drawing.Size(75, 23);
            this.btnLoginServer.TabIndex = 1;
            this.btnLoginServer.Text = "Login Server";
            this.btnLoginServer.UseVisualStyleBackColor = true;
            this.btnLoginServer.Click += new System.EventHandler(this.btnLoginServer_Click);
            // 
            // btnGetCertList
            // 
            this.btnGetCertList.Location = new System.Drawing.Point(12, 91);
            this.btnGetCertList.Name = "btnGetCertList";
            this.btnGetCertList.Size = new System.Drawing.Size(75, 23);
            this.btnGetCertList.TabIndex = 2;
            this.btnGetCertList.Text = "Get List";
            this.btnGetCertList.UseVisualStyleBackColor = true;
            this.btnGetCertList.Click += new System.EventHandler(this.btnGetCertList_Click);
            // 
            // btnValidateCert
            // 
            this.btnValidateCert.Location = new System.Drawing.Point(93, 91);
            this.btnValidateCert.Name = "btnValidateCert";
            this.btnValidateCert.Size = new System.Drawing.Size(75, 23);
            this.btnValidateCert.TabIndex = 3;
            this.btnValidateCert.Text = "Validate Cert";
            this.btnValidateCert.UseVisualStyleBackColor = true;
            this.btnValidateCert.Click += new System.EventHandler(this.btnValidateCert_Click);
            // 
            // btnRenewCert
            // 
            this.btnRenewCert.Location = new System.Drawing.Point(174, 91);
            this.btnRenewCert.Name = "btnRenewCert";
            this.btnRenewCert.Size = new System.Drawing.Size(75, 23);
            this.btnRenewCert.TabIndex = 4;
            this.btnRenewCert.Text = "Renew Cert";
            this.btnRenewCert.UseVisualStyleBackColor = true;
            this.btnRenewCert.Click += new System.EventHandler(this.btnRenewCert_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // CBCertList
            // 
            this.CBCertList.FormattingEnabled = true;
            this.CBCertList.Location = new System.Drawing.Point(19, 154);
            this.CBCertList.Name = "CBCertList";
            this.CBCertList.Size = new System.Drawing.Size(192, 21);
            this.CBCertList.TabIndex = 6;
            // 
            // LetsEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 501);
            this.Controls.Add(this.CBCertList);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnRenewCert);
            this.Controls.Add(this.btnValidateCert);
            this.Controls.Add(this.btnGetCertList);
            this.Controls.Add(this.btnLoginServer);
            this.Controls.Add(this.groupBox1);
            this.Name = "LetsEncrypt";
            this.Text = "Lets Encrypt";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnLoginServer;
        private System.Windows.Forms.Button btnGetCertList;
        private System.Windows.Forms.Button btnValidateCert;
        private System.Windows.Forms.Button btnRenewCert;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox CBCertList;
    }
}

