using Dark.Net;
using System;
using System.Windows.Forms;

namespace WebsiteDownloader
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DarkNet.Instance.SetCurrentProcessTheme(Theme.Auto);

            Form mainForm = new MainForm();
            DarkNet.Instance.SetWindowThemeForms(mainForm, Theme.Auto);

            Application.Run(mainForm);
        }
    }
}
