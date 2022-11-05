using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteDownloader
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void Downloadbtn_Click(object sender, EventArgs e)
        {
            // Launch browser to GitHub...
            System.Diagnostics.Process.Start("https://github.com/EternalModz");
        }

        private void crEaTiiOn_Ultimate_GradientButton1_Click(object sender, EventArgs e)
        {
            // Launch browser to YouTube...
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UConMxIxpuhxtk6s2oGeulLw");
        }

        private void crEaTiiOn_Ultimate_GradientButton2_Click(object sender, EventArgs e)
        {
            string message = "Hey! The Discord server is not ready yet. Check for updates to see if this program has a newer version.";
            string title = "Looks like the server has not been made yet!";
            MessageBox.Show(message, title);
        }
    }
}
