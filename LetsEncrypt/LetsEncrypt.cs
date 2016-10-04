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
        public LetsEncrypt()
        {
            InitializeComponent();
        }

        private void btnLoginServer_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
