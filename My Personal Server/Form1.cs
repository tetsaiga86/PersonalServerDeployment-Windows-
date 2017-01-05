﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Personal_Server
{
    public partial class Form1 : Form
    {
        System.Diagnostics.Process mProcess;
        public Form1()
        {
            InitializeComponent();
            load();
            FileSystemWatcher fileWatcher = new FileSystemWatcher();
            fileWatcher.NotifyFilter = NotifyFilters.Size | NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            fileWatcher.Path = "./";
            fileWatcher.Filter = "server.log";
            fileWatcher.Changed += new FileSystemEventHandler(readLogFile);
            fileWatcher.EnableRaisingEvents = true;
        }

        private void load()
        {
            setFields();
            if (clearLogsCheckBox.Checked)
            {
                deletePreviousLog();
            } 
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.FileName = @"C:\Program Files\nodejs\node.exe";
            psi.Arguments = @"./serverApi/index.js";
            try
            {
                if (start)
                {
                    mProcess = System.Diagnostics.Process.Start(psi);
                    switchBtns();
                }
                else
                {
                    mProcess.Kill();
                    switchBtns();
                }
            }
            catch (Exception err)
            {
                Console.Write(err);
            }
        }

        private void switchBtns()
        {
            if (startButton.Enabled)
            {
                startButton.Enabled = false;
                stopButton.Enabled = true;
            }
            else
            {
                startButton.Enabled = true;
                stopButton.Enabled = false;
            }
        }

        private void deletePreviousLog()
        {
            string path = "./server.log";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                File.Create(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
 
        }

        private void readLogFile(object source, FileSystemEventArgs e)
        {
            try
            {
                int counter = 0;
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("./server.log");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
                file.Close();

                // Suspend the screen.
                logTextBox.Text = Console.ReadLine();
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
                Properties.Settings.Default.port = Int32.Parse(portTextBox.Text);
                Properties.Settings.Default.start_checkBox = startCheckBox.Checked;
                Properties.Settings.Default.close_checBox = minimizeCheckBox.Checked;
                Properties.Settings.Default.clear_logs_checBox = clearLogsCheckBox.Checked;
                Properties.Settings.Default.Save();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString(), "Invalid input");
                
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
            deletePreviousLog();
        }

        private void setFields() {
            try
            {
                rootTextBox.Text = Properties.Settings.Default.root;
                portTextBox.Text = Properties.Settings.Default.port.ToString();
                startCheckBox.Checked = Properties.Settings.Default.start_checkBox;
                minimizeCheckBox.Checked = Properties.Settings.Default.close_checBox;
                clearLogsCheckBox.Checked = Properties.Settings.Default.clear_logs_checBox;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Could not retrieve settings");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            setFields();
        }
    }
}
