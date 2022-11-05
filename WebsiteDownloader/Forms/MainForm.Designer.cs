
using System.Drawing;

namespace WebsiteDownloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.URLtextbox = new System.Windows.Forms.TextBox();
            this.URLlabel = new System.Windows.Forms.Label();
            this.outputFolder = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPrograpmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.ChoseOutputbtn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.Downloadbtn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.menuStrip1.SuspendLayout();
            this.Mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLtextbox
            // 
            this.URLtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.URLtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URLtextbox.ForeColor = System.Drawing.Color.White;
            this.URLtextbox.Location = new System.Drawing.Point(104, 41);
            this.URLtextbox.Multiline = true;
            this.URLtextbox.Name = "URLtextbox";
            this.URLtextbox.Size = new System.Drawing.Size(368, 37);
            this.URLtextbox.TabIndex = 1;
            // 
            // URLlabel
            // 
            this.URLlabel.AutoSize = true;
            this.URLlabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.URLlabel.Location = new System.Drawing.Point(239, 15);
            this.URLlabel.Name = "URLlabel";
            this.URLlabel.Size = new System.Drawing.Size(98, 21);
            this.URLlabel.TabIndex = 2;
            this.URLlabel.Text = "Website URL";
            this.URLlabel.Click += new System.EventHandler(this.URLlabel_Click);
            // 
            // outputFolder
            // 
            this.outputFolder.AutoSize = true;
            this.outputFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.outputFolder.Location = new System.Drawing.Point(12, 218);
            this.outputFolder.Name = "outputFolder";
            this.outputFolder.Size = new System.Drawing.Size(0, 15);
            this.outputFolder.TabIndex = 5;
            this.outputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "MainMenu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPrograpmToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "More";
            // 
            // aboutPrograpmToolStripMenuItem
            // 
            this.aboutPrograpmToolStripMenuItem.Name = "aboutPrograpmToolStripMenuItem";
            this.aboutPrograpmToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aboutPrograpmToolStripMenuItem.Text = "About this prograpm";
            this.aboutPrograpmToolStripMenuItem.Click += new System.EventHandler(this.aboutPrograpmToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Mainpanel
            // 
            this.Mainpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mainpanel.Controls.Add(this.ChoseOutputbtn);
            this.Mainpanel.Controls.Add(this.outputFolder);
            this.Mainpanel.Controls.Add(this.Downloadbtn);
            this.Mainpanel.Controls.Add(this.URLtextbox);
            this.Mainpanel.Controls.Add(this.URLlabel);
            this.Mainpanel.Location = new System.Drawing.Point(0, 24);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(577, 242);
            this.Mainpanel.TabIndex = 9;
            // 
            // ChoseOutputbtn
            // 
            this.ChoseOutputbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChoseOutputbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChoseOutputbtn.BorderRadius = 25;
            this.ChoseOutputbtn.BorderSize = 1;
            this.ChoseOutputbtn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChoseOutputbtn.FlatAppearance.BorderSize = 0;
            this.ChoseOutputbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChoseOutputbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ChoseOutputbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoseOutputbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ChoseOutputbtn.ForeColor = System.Drawing.Color.White;
            this.ChoseOutputbtn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ChoseOutputbtn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ChoseOutputbtn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ChoseOutputbtn.Image = ((System.Drawing.Image)(resources.GetObject("ChoseOutputbtn.Image")));
            this.ChoseOutputbtn.Location = new System.Drawing.Point(104, 84);
            this.ChoseOutputbtn.Name = "ChoseOutputbtn";
            this.ChoseOutputbtn.Size = new System.Drawing.Size(368, 58);
            this.ChoseOutputbtn.TabIndex = 6;
            this.ChoseOutputbtn.Text = " Choose output file path";
            this.ChoseOutputbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChoseOutputbtn.TextColor = System.Drawing.Color.White;
            this.ChoseOutputbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChoseOutputbtn.UseVisualStyleBackColor = false;
            this.ChoseOutputbtn.Click += new System.EventHandler(this.ChoseOutputbtn_Click);
            // 
            // Downloadbtn
            // 
            this.Downloadbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Downloadbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Downloadbtn.BorderRadius = 25;
            this.Downloadbtn.BorderSize = 1;
            this.Downloadbtn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Downloadbtn.FlatAppearance.BorderSize = 0;
            this.Downloadbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Downloadbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Downloadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Downloadbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Downloadbtn.ForeColor = System.Drawing.Color.White;
            this.Downloadbtn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Downloadbtn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.Downloadbtn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Downloadbtn.Image = ((System.Drawing.Image)(resources.GetObject("Downloadbtn.Image")));
            this.Downloadbtn.Location = new System.Drawing.Point(104, 148);
            this.Downloadbtn.Name = "Downloadbtn";
            this.Downloadbtn.Size = new System.Drawing.Size(368, 58);
            this.Downloadbtn.TabIndex = 7;
            this.Downloadbtn.Text = "Download the source code!";
            this.Downloadbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Downloadbtn.TextColor = System.Drawing.Color.White;
            this.Downloadbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Downloadbtn.UseVisualStyleBackColor = false;
            this.Downloadbtn.Click += new System.EventHandler(this.crEaTiiOn_Ultimate_GradientButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(577, 266);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Website Source Code Downloader - CBH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox URLtextbox;
        private System.Windows.Forms.Label URLlabel;
        private System.Windows.Forms.Label outputFolder;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton ChoseOutputbtn;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton Downloadbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPrograpmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel Mainpanel;
    }
}

