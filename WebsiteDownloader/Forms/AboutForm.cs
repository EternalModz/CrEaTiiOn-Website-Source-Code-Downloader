﻿using CBH_WebDLTool;
using System;
using System.Windows.Forms;

namespace WebsiteDownloader
{
    public partial class AboutForm : ThemeForm
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
            // Launch browser to Discord...
            System.Diagnostics.Process.Start("https://discord.gg/kxUQFEUMUa");
        }
    }
}
