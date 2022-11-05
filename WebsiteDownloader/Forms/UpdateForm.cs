using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSrcDL_CBH.Forms
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void Downloadbtn_Click(object sender, EventArgs e)
        {
            // Launch browser to GitHub...
            System.Diagnostics.Process.Start("https://github.com/EternalModz");
        }

        private void CheckForUpdatesbtn_Click(object sender, EventArgs e)
        {
            WebSrcDL_CBH.Classes.Network.CheckUpdate();
        }
    }
}
