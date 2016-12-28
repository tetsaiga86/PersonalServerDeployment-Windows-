﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void load()
        {
            try
            {
                rootTextBox.Text = Properties.Settings.Default.root;
                portTextBox.Text = Properties.Settings.Default.port.ToString();
                startCheckBox.Checked = Properties.Settings.Default.start_checkBox;
                minimizeCheckBox.Checked = Properties.Settings.Default.close_checBox;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Could not retrieve settings");
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
            psi.UseShellExecute = false;   // This is important
            psi.CreateNoWindow = true;     // This is what hides the command window.
            psi.FileName = @"C:\Program Files\nodejs\node.exe";
            psi.Arguments = @"./serverApi/index.js";   // Probably you will pass the port number here
            if (start)
            {
                mProcess = System.Diagnostics.Process.Start(psi);
            }
            else
            {
                mProcess.Kill();
                
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
    }
}