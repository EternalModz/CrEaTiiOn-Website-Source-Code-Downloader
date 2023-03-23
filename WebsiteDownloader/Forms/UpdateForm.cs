using CBH_WebDLTool;
using System;
using System.Windows.Forms;

namespace WebSrcDL_CBH.Forms
{
    public partial class UpdateForm : ThemeForm
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
