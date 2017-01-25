using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace My_Personal_Server
{
    public partial class MainWindow : Form
    {
        long counter;
        System.Diagnostics.Process mProcess;
        System.Diagnostics.Process mNgrokProcess;
        public MainWindow()
        {
            InitializeComponent();
            counter = 0;
            load();
            FileSystemWatcher fileWatcher = new FileSystemWatcher();
            fileWatcher.NotifyFilter = NotifyFilters.Size;
            fileWatcher.Path = "./";
            fileWatcher.Filter = "server.log";
            fileWatcher.Changed += new FileSystemEventHandler(readLogFile);
            fileWatcher.EnableRaisingEvents = true;
            toggleApplyCancelBtns(false);
            if (startMinChkBx.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
        }

        private void load()
        {
            setFields();

            if (clearLogsCheckBox.Checked)
            {
                deletePreviousLog();
            }

            readLogFile(null, null);

            if (startServerChkBx.Checked)
            {
                startStopServer(true);
            }

            
        }

        private void toggleApplyCancelBtns(Boolean state)
        {
            cancelButton.Enabled = state;
            applyButton.Enabled = state;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                rootTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void startStopServer(Boolean start)
        {
            //Node Server
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.FileName = nodeFileTextBox.Text;
            psi.Arguments = @"./serverApi/index.js " + portTextBox.Text + " " + rootTextBox.Text.Replace('\\','/');

            //Ngrok
            System.Diagnostics.ProcessStartInfo ngrok = new System.Diagnostics.ProcessStartInfo();
            ngrok.RedirectStandardOutput = true;
            ngrok.UseShellExecute = false;
            ngrok.CreateNoWindow = true;
            ngrok.FileName = @"./ngrok/ngrok.exe";
            ngrok.Arguments = "http -bind-tls=true -auth=\"" + 
                Properties.Settings.Default.username + ":" + 
                Properties.Settings.Default.password + "\" " + 
                portTextBox.Text;
            try
            {
                if (start)
                {
                    mProcess = System.Diagnostics.Process.Start(psi);
                    notifyIcon.BalloonTipText = "Server running on port: " + portTextBox.Text;
                    mNgrokProcess = System.Diagnostics.Process.Start(ngrok);
                    switchBtns();
                    //MessageBox.Show(getNgrokHost(), "Your current server URL is: ");
                    QrForm qrForm = new QrForm(getNgrokHost(), 
                        Properties.Settings.Default.username, 
                        Properties.Settings.Default.password);
                    qrForm.Show();
                    Clipboard.SetText(getNgrokHost());
                }
                else
                {
                    if (!mNgrokProcess.HasExited) mNgrokProcess.Kill();
                    if (!mProcess.HasExited) mProcess.Kill();

                    notifyIcon.BalloonTipText = "Server stopped";
                    switchBtns();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Invalid input");
                Console.Write(err);
            }
        }

        private void switchBtns()
        {
            if (startButton.Enabled)
            {
                startButton.Enabled = false;
                ngrokBtn.Enabled = false;
                stopButton.Enabled = true;
            }
            else
            {
                startButton.Enabled = true;
                stopButton.Enabled = false;
                ngrokBtn.Enabled = true;
            }
        }

        private void deletePreviousLog()
        {
            string path = "./server.log";
            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                //File.Create(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
 
        }

        private void readLogFile(object source, FileSystemEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { readLogFile(source, e); });
                return;
            }
            try
            {
                if (!System.IO.File.Exists("./server.log"))
                {
                    return;
                }
                string line;

                // Read the file and display it line by line.
                System.IO.FileStream file = System.IO.File.Open("./server.log", 
                    FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                file.Seek(counter, SeekOrigin.Begin);
                StreamReader reader = new StreamReader(file);
                while ((line = reader.ReadLine()) != null)
                {
                    
                    logTextBox.AppendText(line + "\n");
                    Console.WriteLine(line);
                }
                counter = file.Position;
                reader.Close();
                file.Close();
            }
            catch (Exception err)
            {
                Console.Write(err);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.root = rootTextBox.Text;
                Properties.Settings.Default.node = nodeFileTextBox.Text;
                Properties.Settings.Default.port = Int32.Parse(portTextBox.Text);
                Properties.Settings.Default.start_checkBox = startCheckBox.Checked;
                Properties.Settings.Default.close_checBox = minimizeCheckBox.Checked;
                Properties.Settings.Default.clear_logs_checBox = clearLogsCheckBox.Checked;
                Properties.Settings.Default.startServerChkBx = startServerChkBx.Checked;
                Properties.Settings.Default.startMinChkBx = startMinChkBx.Checked;
                Properties.Settings.Default.Save();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString(), "Invalid input");
                
            }
            startWithWindows(startCheckBox.Checked);
            toggleApplyCancelBtns(false);
        }

        private void startWithWindows(Boolean launch)
        {
            String file = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
                    + "/My Personal Server.exe - Shortcut.lnk";
            if (launch)
            {
                if (!System.IO.File.Exists(file))
                {
                    var shell = new WshShell();
                    var windowsApplicationShortcut = (IWshShortcut)shell.CreateShortcut(file);
                    windowsApplicationShortcut.Description = "App for node server";
                    windowsApplicationShortcut.WorkingDirectory = Application.StartupPath;
                    windowsApplicationShortcut.TargetPath = Application.ExecutablePath;
                    windowsApplicationShortcut.Save();
                }
            }
            else
            {
                if (System.IO.File.Exists(file))
                {
                    System.IO.File.Delete(file);
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startStopServer(true);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startStopServer(false);
        }

        private void clearLogBtn_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
        }

        private void setFields() {
            try
            {
                rootTextBox.Text = Properties.Settings.Default.root;
                portTextBox.Text = Properties.Settings.Default.port.ToString();
                startCheckBox.Checked = Properties.Settings.Default.start_checkBox;
                minimizeCheckBox.Checked = Properties.Settings.Default.close_checBox;
                clearLogsCheckBox.Checked = Properties.Settings.Default.clear_logs_checBox;
                startServerChkBx.Checked = Properties.Settings.Default.startServerChkBx;
                startMinChkBx.Checked = Properties.Settings.Default.startMinChkBx;
                nodeFileTextBox.Text = Properties.Settings.Default.node;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Could not retrieve settings");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            setFields();
            toggleApplyCancelBtns(false);
        }

        private void startCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            startWithWindows(startCheckBox.Checked);
            toggleApplyCancelBtns(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (minimizeCheckBox.Checked)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    notifyIcon.Visible = true;
                    this.Hide();
                    e.Cancel = true;
                }
            }
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void rootTextBox_TextChanged(object sender, EventArgs e)
        {
            toggleApplyCancelBtns(true);
        }

        private void portTextBox_TextChanged(object sender, EventArgs e)
        {
            toggleApplyCancelBtns(true);
        }

        private void clearLogsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toggleApplyCancelBtns(true);
        }

        private void minimizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toggleApplyCancelBtns(true);
        }

        private void startMinChkBx_CheckedChanged(object sender, EventArgs e)
        {
            toggleApplyCancelBtns(true);
        }

        private void startServerChkBx_CheckedChanged(object sender, EventArgs e)
        {
            toggleApplyCancelBtns(true);
            
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nodeFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void nodeFileTextBox_TextChanged(object sender, EventArgs e)
        {
            toggleApplyCancelBtns(true);
        }

        private void ngrokBtn_Click(object sender, EventArgs e)
        {
            String username = Properties.Settings.Default.username;
            String password = Properties.Settings.Default.password;
            if (InputBox.inputBox("Enter Username & Password: ", "Username: ", ref username, ref password) == DialogResult.OK)
            {
                Console.Write(username, password);
                Properties.Settings.Default.username = username;
                Properties.Settings.Default.password = password;
                Properties.Settings.Default.Save();
            }

        }

        private String getNgrokHost()
        {
            String jsonResponseString;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:4040/api/tunnels");
            request.Accept = "application/json";
            request.ContentType = "application/json";
            
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    jsonResponseString = reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    Console.Write(errorText);
                }
                throw;
            }

            var responseObject = JObject.Parse(jsonResponseString);
            var tunnels = responseObject.Value<JArray>("tunnels");
            if (tunnels.Count == 0)
            {
                return getNgrokHost();
            }
            var tunnel = tunnels.Value<JObject>(0);
            return tunnel.Value<String>("public_url");
        }
    }
}
