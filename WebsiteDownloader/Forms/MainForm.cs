using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSrcDL_CBH.Forms;

namespace WebsiteDownloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Download_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void crEaTiiOn_Ultimate_GradientButton1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //  string[] files = Directory.GetFiles(fbd.SelectedPath);
                    //   string[] directories = Directory.GetDirectories(fbd.SelectedPath);

                    outputFolder.Text = fbd.SelectedPath;
                    Downloadbtn.Enabled = true;
                }
            }
        }

        private void crEaTiiOn_Ultimate_GradientButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(URLtextbox.Text))
            {
                MessageBox.Show("You have to provide the url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!File.Exists("C:\\wget.exe"))
                {
                    using (var fileStream = new FileStream(@"C:\wget.exe", FileMode.Create, FileAccess.Write))
                    {
                        using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                        {
                            binaryWriter.Write(WebSrcDL_CBH.Properties.Resources.Runner);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Permission required to run this application, try to run it as administrator, ERROR: {exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var url = new Uri(URLtextbox.Text);
            var outputFolderTextUrlHost = $"{outputFolder.Text}\\{url.Host}";
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:\\wget.exe",
                    WorkingDirectory = outputFolder.Text,
                    Arguments = $"-r -p -e robots=off -U mozilla  {url} -P ./{url.Host} ",
                }
            };

            Task.Run(() =>
            {
                process.Start();
                process.WaitForExit();

                if (Directory.Exists(outputFolderTextUrlHost))
                {
                    Process.Start(outputFolderTextUrlHost);
                }
                else
                {
                    MessageBox.Show("Something went wrong..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void discordServerComingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add server link once the server has been made.
        }

        private void aboutPrograpmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm F2 = new AboutForm(); // Instantiate a Form3 object.
            F2.Show(); // Show Form3 and
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebSrcDL_CBH.Classes.Network.CheckUpdate();
        }

        private void URLlabel_Click(object sender, EventArgs e)
        {

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm F3 = new UpdateForm(); // Instantiate a Form3 object.
            F3.Show(); // Show Form3 and
        }
    }
}
