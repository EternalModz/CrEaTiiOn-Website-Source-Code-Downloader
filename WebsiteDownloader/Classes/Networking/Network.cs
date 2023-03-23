using System;
using System.Threading;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WebSrcDL_CBH.Classes
{
    class Network
    {
        static string Version = "2.0";
        public static bool Beta = false;
        public static bool NeedsUpdate = false;
        public static string MainURL = "https://eternalmodz.github.io/New-UltimateCraft-Website/";
        public static string BackURL = "https://eternalmodz.github.io/New-UltimateCraft-Website/";
        static string UpdateURL = "Updates/Versions/WebSrcDL-CBH/API/CurrentVersion.txt";
        static string BetaUpdateURL = "Updates/Versions/WebSrcDL-CBH/API/CurrentVersion.txt";

        public static void CheckUpdate()
        {
            WebClient wc = new WebClient();
            string docuDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                switch (Beta)
                {
                    case false:
                        if (float.Parse(Version) < float.Parse(wc.DownloadString(MainURL + UpdateURL)))
                        {
                            if (MessageBox.Show("An update is available! Do you want to update?\nYour Version:" + Version + "\nAvailable version:" + wc.DownloadString(MainURL + UpdateURL), "Update Available", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Classes.Update.UpdateProgram(Beta);
                            }
                            else
                            {
                                NeedsUpdate = true;
                            }
                            File.WriteAllText(docuDir + "\\WebSrcDL-CBH\\UserData\\Change.log", wc.DownloadString(MainURL + "Updates/Versions/WebSrcDL-CBH/API/Changelog.txt"));
                        }
                        break;
                    case true:
                        if (float.Parse(Version) < float.Parse(wc.DownloadString(MainURL + BetaUpdateURL)))
                        {
                            if (MessageBox.Show("An update is available! Do you want to update?\nYour Version:" + Version + "\nAvailable version:" + wc.DownloadString(MainURL + UpdateURL), "Update Available", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Classes.Update.UpdateProgram(Beta);
                            }
                            else
                            {
                                NeedsUpdate = true;
                            }
                            File.WriteAllText(docuDir + "\\WebSrcDL-CBH\\UserData\\Change.log", wc.DownloadString(MainURL + "Updates/Versions/WebSrcDL-CBH/Beta/API/ChangelogBeta.txt"));
                        }
                        break;
                }
            }
            catch
            {
                try
                {
                    switch (Beta)
                    {
                        case false:
                            if (float.Parse(Version) < float.Parse(wc.DownloadString(BackURL + UpdateURL)))
                            {
                                if (MessageBox.Show("An update is available! Do you want to update?\nYour Version:" + Version + "\nAvailable version:" + wc.DownloadString(BackURL + UpdateURL), "Update Available", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Classes.Update.UpdateProgram(Beta);
                                }
                                else
                                {
                                    NeedsUpdate = true;
                                }
                                File.WriteAllText(docuDir + "\\WebSrcDL-CBH\\UserData\\Change.log", wc.DownloadString(BackURL + "Updates/Versions/WebSrcDL-CBH/API/Changelog.txt"));
                            }
                            break;
                        case true:
                            if (float.Parse(Version) < float.Parse(wc.DownloadString(BackURL + BetaUpdateURL)))
                            {
                                if (MessageBox.Show("An update is available! Do you want to update?\nYour Version:" + Version + "\nAvailable version:" + wc.DownloadString(BackURL + UpdateURL), "Update Available", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Classes.Update.UpdateProgram(Beta);
                                }
                                else
                                {
                                    NeedsUpdate = true;
                                }
                                File.WriteAllText(docuDir + "\\WebSrcDL-CBH\\UserData\\Change.log", wc.DownloadString(BackURL + "Updates/Versions/WebSrcDL-CBH/API/changelogBeta.txt"));
                            }
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Server unavailabe", "Cannot connect to the server!");
                }
            }
        }


    }
}
