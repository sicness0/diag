using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Dynamic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using NetworkingConfig;

namespace BVSCDiagnostics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            if (pingURL("http://yesit.com.au") == true)
            {
                string json = new WebClient().DownloadString("http://yesit.com.au/bvsc.php");
                if (json.ToString() != "1")
                {
                    DialogResult result = MessageBox.Show("You are no longer authorized to run this diag.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            InitializeComponent();
        }

        private void MainForm_Loaded(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblComputerName.Text = Dns.GetHostName();
            lblUsername.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            NetworkData networkDetails = new NetworkData();
            lblDnsAddress.Text = NetworkData.GetDnsAddress().ToString();
            lblIPAddress.Text = NetworkData.GetIPv4Address();
        }

        static bool pingURL(string URL)
        {
            Uri url = new Uri(URL);
            string pingurl = string.Format("{0}", url.Host);
            string host = pingurl;
            bool result = false;
            var IPStatus = new System.Net.NetworkInformation.IPStatus();
            var p = new System.Net.NetworkInformation.Ping();
            try
            {
                var reply = p.Send(host, 3000);
                if (reply.Status == IPStatus)
                    return true;
            }
            catch { }
            return result;
        }

        static bool pingIP(string IP)
        {
            var ping = new System.Net.NetworkInformation.Ping();
            var result = ping.Send(IP);
            if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
            {
                return false;
            }

            return true;
        }

        static bool pingHostName(string HostName)
        {
            var ping = new System.Net.NetworkInformation.Ping();

            try
            {
                var result = ping.Send(HostName);
                if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private Dictionary<string, string> performTest(string GoogleDNS, string GoogleURL, string EzyVetIP, string ServerIP, string ServerName, string RouterIP)
        {

            var results = new Dictionary<string, string>();

            // Ping bvsc server IP
            if (pingIP(ServerIP) == true)
            {
                lblTestBvscSrvIP.Text = "Passed";
                lblTestBvscSrvIP.ForeColor = Color.DarkGreen;
                results["BvscIP"] = "Passed";
            }
            else
            {
                lblTestBvscSrvIP.Text = "Failed";
                lblTestBvscSrvIP.ForeColor = Color.Red;
                results["BvscIP"] = "Failed";
            }
            progressBarTest.Value = 1;

            // Ping bvsc server name
            if (pingHostName(ServerName) == true)
            {
                lblTestBvscSrvName.Text = "Passed";
                lblTestBvscSrvName.ForeColor = Color.DarkGreen;
                results["BvscHostname"] = "Passed";
            }
            else
            {
                lblTestBvscSrvName.Text = "Failed";
                lblTestBvscSrvName.ForeColor = Color.Red;
                results["BvscHostname"] = "Failed";
            }
            progressBarTest.Value = 2;

            // Ping router
            if (pingIP(RouterIP) == true)
            {
                lblTestRouterIP.Text = "Passed";
                lblTestRouterIP.ForeColor = Color.DarkGreen;
                results["RouterIP"] = "Passed";
            }
            else
            {
                lblTestRouterIP.Text = "Failed";
                lblTestRouterIP.ForeColor = Color.Red;
                results["RouterIP"] = "Failed";
            }
            progressBarTest.Value = 3;

            // Ping Google DNS IP
            if (pingIP(GoogleDNS) == true)
            {
                lblTestGoogleDnsIP.Text = "Passed";
                lblTestGoogleDnsIP.ForeColor = Color.DarkGreen;
                results["GoogleDNS"] = "Passed";
            }
            else
            {
                lblTestGoogleDnsIP.Text = "Failed";
                lblTestGoogleDnsIP.ForeColor = Color.Red;
                results["GoogleDNS"] = "Failed";
            }
            progressBarTest.Value = 4;

            // Ping Google url
            if (pingURL(GoogleURL) == true)
            {
                lblTestGoogleDnsName.Text = "Passed";
                lblTestGoogleDnsName.ForeColor = Color.DarkGreen;
                results["GoogleUrl"] = "Passed";
            }
            else
            {
                lblTestGoogleDnsName.Text = "Failed";
                lblTestGoogleDnsName.ForeColor = Color.Red;
                results["GoogleUrl"] = "Failed";
            }
            progressBarTest.Value = 5;

            // Ping EzyVet IP
            if (pingIP(EzyVetIP) == true)
            {
                lblTestEzyVetIP.Text = "Passed";
                lblTestEzyVetIP.ForeColor = Color.DarkGreen;
                results["EzyVetIP"] = "Passed";
            }
            else
            {
                lblTestEzyVetIP.Text = "Failed";
                lblTestEzyVetIP.ForeColor = Color.Red;
                results["EzyVetIP"] = "Failed";
            }
            progressBarTest.Value = 6;
            progressBarTest.Visible = false;

            return results;
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GoogleDNS = "8.8.8.8";
            string GoogleURL = "http://google.com.au";
            string EzyVetIP = "54.240.192.109";
            string ServerIP = "192.168.1.8";
            string ServerName = "bvsc1";
            string RouterIP = "192.168.1.1";
            //lblTestBvscSrvIP.Text = "Running"; lblTestBvscSrvName.Text = "Running"; lblTestRouterIP.Text = "Running"; lblTestGoogleDnsIP.Text = "Running"; lblTestGoogleDnsName.Text = "Running"; lblTestEzyVetIP.Text = "Running";

            btnFlushDNS.Enabled = false;
            btnSaveScreenshotResults.Enabled = false;
            btnShowRouter.Enabled = false;

            progressBarTest.Visible = true;

            lblResults.Text = "";
            btnRunDiagnostics.Text = "Re-run Diagnostics";
            var testResults = performTest(GoogleDNS, GoogleURL, EzyVetIP, ServerIP, ServerName, RouterIP);

            lblResults.Text = analyzeResults(testResults);

            btnFlushDNS.Enabled = true;
            btnSaveScreenshotResults.Enabled = true;
            btnShowRouter.Enabled = true;
        }

        private string analyzeResults(Dictionary<string, string> results)
        {
            var BvscIP = results["BvscIP"];
            var BvscHostname = results["BvscHostname"];
            var RouterIP = results["RouterIP"];
            var GoogleDNS = results["GoogleDNS"];
            var GoogleUrl = results["GoogleUrl"];
            var EzyVetIP = results["EzyVetIP"];

            string Message = "";
            // Test LAN connectivity
            if(BvscIP == "Failed" || BvscHostname == "Failed" || RouterIP == "Failed")
            {

                if (BvscIP == "Passed" && RouterIP == "Passed" && BvscHostname == "Failed")
                {
                    Message = "Able to ping Server and Router IP.\n";
                    Message += "Cannot ping Server name.\n";
                    Message += "\n";
                    Message += "\nRun diagnostics on another PC. Do they both have the same test results?\n";
                    Message += "\n";
                    Message += "        Yes) Please contact YesIT on 1300 885 001.\n";
                    Message += "        No) Under computer details check the following:\n";
                    Message += "                i)  Check DNS is 192.168.1.8\n";
                    Message += "                ii) Check IP looks like 192.168.1.x (x can be any number)\n";
                    Message += "                        If neither are correct then contact YesIT\n";
                }
                else if (RouterIP == "Failed" && BvscIP == "Passed" && BvscHostname == "Passed")
                {
                    Message = "Internet Router is not visible from this PC.\n";
                    Message += "Able to connect to server via IP and Server Name.\n";
                    Message += "\n";
                    Message += "\nRun diagnostics on another PC. Do they both have the same test results?\n";
                    Message += "\n";
                    Message += "        Yes) Check router – is Ethernet 5 EWAN light on?\n"; //TODO: Check instructions
                    Message += "                Under Tools click 'Show Router Image' to view router\n";
                    Message += "                       If Ethernet 5 EWAN off repower router. If still off contact Telstra.\n";
                    Message += "\n";
                    Message += "        No) May be isolated incident. Under Tools click 'Flush DNS Cache' then Re-run diagnostics\n";
                    Message += "                If still fails then email YesIT from another PC and include the computer details.";
                }
                else
                {
                    Message = "It appears this PC is not connected to the LAN Network.\n";
                    Message += "\n";
                    Message += "Run test on other machines. Are other machines having the same issue?\n";
                    Message += "\n";
                    Message += "        Yes) Check cable in back of computer/Check wireless connection is on.\n";
                    Message += "                Check computer in a different part of the building. May be isolated to that room.\n";
                    Message += "                If working in a different room a cable may still be disconnected on that PC.\n";
                    Message += "                Re-run test after checking. Contact YesIT if still having issues.\n";
                    Message += "\n";
                    Message += "        No) Check cable in back of computer/Check wireless connection on.\n";
                    Message += "                Re-run diagnostic after cable/wireless check.\n";
                    Message += "                    If still not working, check the following under computer details:\n";
                    Message += "                            i)  Check DNS is 192.168.1.8\n";
                    Message += "                            ii) Check IP looks like 192.168.1.x (x can be any number)\n";
                    Message += "                                    If neither are correct then contact YesIT.\n";
                }

            }
            // Test Connectivity to google DNS 8.8.8.8
            else if(GoogleDNS == "Failed")
            {
                Message = "Local server (bvsc1) and Router is visible from this PC.\n";
                Message += "Unable to connect to external servers. Internet is down.\n";
                Message += "Check router – is Ethernet 5 EWAN light on?\n";
                Message += "        Under Tools 'Show Router Image' to view router\n";
                Message += "                If Ethernet 5 EWAN off repower router.\n";
                Message += "                Wait for up to 5 minutes for light to flash green.\n";
                Message += "                If still off contact Telstra.\n";
            }
            // Connect to EzyVetIP 
            else if(EzyVetIP == "Failed")
            {
                Message = "Local server (bvsc1) and Router is visible from this PC.\n";
                Message += "Able to connect to external servers and websites. Internet is working.\n";
                Message += "Connecting to EzyVet has failed. Call EzyVet.\n";
            }
            else
            {
                Message = "All tests passed. Your internet browser may be having issues.\n";
                Message += "Please close all Chrome windows and trying again.\n";
                Message += "If issue still occurs, please test using Internet Explorer.\n";
                Message += "If Internet Explorer works, Chrome may be playing up.\n";
                Message += "Under Tools, please save a screenshot and email YesIT at helpdesk@yesit.com.au.\n";
            }
            return Message;
        }

        private void btnFlushDNS_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ipconfig /flushdns";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get user profile path to get teamviewer to run off the desktop.
            string router = string.Format(@"C:\toolkit\router.jpg");
            try
            {
                if (File.Exists(router))
                {
                    Process.Start(router);
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSaveScreenshotResults_Click(object sender, EventArgs e)
        {

            var proc = Process.GetCurrentProcess();
            var rect = new User32.Rect();
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);

            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;

            var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

            // Displays a SaveFileDialog so the user can save the Image
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save Results";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        bmp.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 2:
                        bmp.Save(fs, ImageFormat.Bmp);
                        break;

                    case 3:
                        bmp.Save(fs, ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            /*
             *  This application first developed by Matthew Day @ YesIT.
             *
             *  This application remains the property of YesIT.
             *
             *  Unauthorized use of this app can render a 'Fuck off' said from YesIT staff
             *
             *  This has been developed as a basic diagnostic tool customized 
             *  for our clients to assist outside of business hours.
             *
             */
        }

        private void btnRunTeamViewer_Click(object sender, EventArgs e)
        {
            // Get user profile path to get teamviewer to run off the desktop.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string teamviewer = string.Format(@"{0}\Desktop\TeamViewerQS.exe", path);
            try
            {
                if (File.Exists(teamviewer))
                {
                    @Process.Start(teamviewer);
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
