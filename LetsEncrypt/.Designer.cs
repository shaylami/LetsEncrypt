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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetsEncrypt));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnLoginServer = new System.Windows.Forms.Button();
            this.btnGetCertList = new System.Windows.Forms.Button();
            this.btnValidateCert = new System.Windows.Forms.Button();
            this.btnRenewCert = new System.Windows.Forms.Button();
            this.CBCertList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.rtbResults.BackColor = System.Drawing.Color.White;
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
            this.btnLoginServer.Location = new System.Drawing.Point(76, 105);
            this.btnLoginServer.Name = "btnLoginServer";
            this.btnLoginServer.Size = new System.Drawing.Size(75, 23);
            this.btnLoginServer.TabIndex = 1;
            this.btnLoginServer.Text = "Login Server";
            this.btnLoginServer.UseVisualStyleBackColor = true;
            this.btnLoginServer.Click += new System.EventHandler(this.btnLoginServer_Click);
            // 
            // btnGetCertList
            // 
            this.btnGetCertList.Location = new System.Drawing.Point(19, 149);
            this.btnGetCertList.Name = "btnGetCertList";
            this.btnGetCertList.Size = new System.Drawing.Size(75, 23);
            this.btnGetCertList.TabIndex = 2;
            this.btnGetCertList.Text = "Get Cert List";
            this.btnGetCertList.UseVisualStyleBackColor = true;
            this.btnGetCertList.Click += new System.EventHandler(this.btnGetCertList_Click);
            // 
            // btnValidateCert
            // 
            this.btnValidateCert.Location = new System.Drawing.Point(19, 188);
            this.btnValidateCert.Name = "btnValidateCert";
            this.btnValidateCert.Size = new System.Drawing.Size(75, 23);
            this.btnValidateCert.TabIndex = 3;
            this.btnValidateCert.Text = "Validate Cert";
            this.btnValidateCert.UseVisualStyleBackColor = true;
            this.btnValidateCert.Click += new System.EventHandler(this.btnValidateCert_Click);
            // 
            // btnRenewCert
            // 
            this.btnRenewCert.Location = new System.Drawing.Point(119, 149);
            this.btnRenewCert.Name = "btnRenewCert";
            this.btnRenewCert.Size = new System.Drawing.Size(98, 23);
            this.btnRenewCert.TabIndex = 4;
            this.btnRenewCert.Text = "Renew All Cert";
            this.btnRenewCert.UseVisualStyleBackColor = true;
            this.btnRenewCert.Click += new System.EventHandler(this.btnRenewCert_Click);
            // 
            // CBCertList
            // 
            this.CBCertList.FormattingEnabled = true;
            this.CBCertList.Location = new System.Drawing.Point(119, 190);
            this.CBCertList.Name = "CBCertList";
            this.CBCertList.Size = new System.Drawing.Size(192, 21);
            this.CBCertList.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 86);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Build by shay lami";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tested on ubuntu 14.04";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "shay@lami.co.il";
            // 
            // LetsEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CBCertList);
            this.Controls.Add(this.btnRenewCert);
            this.Controls.Add(this.btnValidateCert);
            this.Controls.Add(this.btnGetCertList);
            this.Controls.Add(this.btnLoginServer);
            this.Controls.Add(this.groupBox1);
            this.Name = "LetsEncrypt";
            this.Text = "Lets Encrypt";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnLoginServer;
        private System.Windows.Forms.Button btnGetCertList;
        private System.Windows.Forms.Button btnValidateCert;
        private System.Windows.Forms.Button btnRenewCert;
        private System.Windows.Forms.ComboBox CBCertList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

