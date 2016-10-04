namespace LetsEncrypt
{
    partial class Login
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
            this.tbSave = new System.Windows.Forms.Button();
            this.tbMip = new System.Windows.Forms.TextBox();
            this.tbMuser = new System.Windows.Forms.TextBox();
            this.tbMPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSave
            // 
            this.tbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbSave.Location = new System.Drawing.Point(50, 201);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(144, 48);
            this.tbSave.TabIndex = 0;
            this.tbSave.Text = "Save";
            this.tbSave.UseVisualStyleBackColor = true;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // tbMip
            // 
            this.tbMip.Location = new System.Drawing.Point(12, 60);
            this.tbMip.Name = "tbMip";
            this.tbMip.Size = new System.Drawing.Size(206, 20);
            this.tbMip.TabIndex = 1;
            // 
            // tbMuser
            // 
            this.tbMuser.Location = new System.Drawing.Point(12, 104);
            this.tbMuser.Name = "tbMuser";
            this.tbMuser.Size = new System.Drawing.Size(206, 20);
            this.tbMuser.TabIndex = 2;
            // 
            // tbMPwd
            // 
            this.tbMPwd.Location = new System.Drawing.Point(12, 147);
            this.tbMPwd.Name = "tbMPwd";
            this.tbMPwd.Size = new System.Drawing.Size(206, 20);
            this.tbMPwd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Machine IP/Hostname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Machine User name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Machine Password :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMPwd);
            this.Controls.Add(this.tbMuser);
            this.Controls.Add(this.tbMip);
            this.Controls.Add(this.tbSave);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.TextBox tbMip;
        private System.Windows.Forms.TextBox tbMuser;
        private System.Windows.Forms.TextBox tbMPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}