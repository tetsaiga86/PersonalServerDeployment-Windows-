namespace My_Personal_Server
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearLogsCheckBox = new System.Windows.Forms.CheckBox();
            this.startServerChkBx = new System.Windows.Forms.CheckBox();
            this.startMinChkBx = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rootTextBox = new System.Windows.Forms.TextBox();
            this.nodeFileTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.folderButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.clearLogBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.startCheckBox = new System.Windows.Forms.CheckBox();
            this.minimizeCheckBox = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.createCertBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(854, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to your personal server!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.71663F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.59485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(854, 334);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.stopButton);
            this.flowLayoutPanel6.Controls.Add(this.startButton);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(224, 266);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(337, 65);
            this.flowLayoutPanel6.TabIndex = 5;
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(3, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(162, 60);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(171, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(162, 60);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.clearLogsCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.startServerChkBx);
            this.flowLayoutPanel1.Controls.Add(this.startMinChkBx);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 257);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Root Directory: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Node File:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Logs:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // clearLogsCheckBox
            // 
            this.clearLogsCheckBox.Location = new System.Drawing.Point(3, 174);
            this.clearLogsCheckBox.Margin = new System.Windows.Forms.Padding(3, 55, 3, 3);
            this.clearLogsCheckBox.Name = "clearLogsCheckBox";
            this.clearLogsCheckBox.Size = new System.Drawing.Size(183, 24);
            this.clearLogsCheckBox.TabIndex = 5;
            this.clearLogsCheckBox.Text = "Clear logs on restart";
            this.clearLogsCheckBox.UseVisualStyleBackColor = true;
            this.clearLogsCheckBox.CheckedChanged += new System.EventHandler(this.clearLogsCheckBox_CheckedChanged);
            // 
            // startServerChkBx
            // 
            this.startServerChkBx.Location = new System.Drawing.Point(3, 204);
            this.startServerChkBx.Name = "startServerChkBx";
            this.startServerChkBx.Size = new System.Drawing.Size(183, 24);
            this.startServerChkBx.TabIndex = 7;
            this.startServerChkBx.Text = "Autostart Server";
            this.startServerChkBx.UseVisualStyleBackColor = true;
            this.startServerChkBx.CheckedChanged += new System.EventHandler(this.startServerChkBx_CheckedChanged);
            // 
            // startMinChkBx
            // 
            this.startMinChkBx.Location = new System.Drawing.Point(3, 234);
            this.startMinChkBx.Name = "startMinChkBx";
            this.startMinChkBx.Size = new System.Drawing.Size(183, 24);
            this.startMinChkBx.TabIndex = 8;
            this.startMinChkBx.Text = "Start in Tray";
            this.startMinChkBx.UseVisualStyleBackColor = true;
            this.startMinChkBx.CheckedChanged += new System.EventHandler(this.startMinChkBx_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rootTextBox);
            this.flowLayoutPanel2.Controls.Add(this.nodeFileTextBox);
            this.flowLayoutPanel2.Controls.Add(this.portTextBox);
            this.flowLayoutPanel2.Controls.Add(this.logTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(197, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(409, 257);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // rootTextBox
            // 
            this.rootTextBox.Location = new System.Drawing.Point(3, 3);
            this.rootTextBox.Name = "rootTextBox";
            this.rootTextBox.Size = new System.Drawing.Size(406, 26);
            this.rootTextBox.TabIndex = 0;
            this.rootTextBox.TextChanged += new System.EventHandler(this.rootTextBox_TextChanged);
            // 
            // nodeFileTextBox
            // 
            this.nodeFileTextBox.Location = new System.Drawing.Point(3, 35);
            this.nodeFileTextBox.Name = "nodeFileTextBox";
            this.nodeFileTextBox.Size = new System.Drawing.Size(406, 26);
            this.nodeFileTextBox.TabIndex = 10;
            this.nodeFileTextBox.TextChanged += new System.EventHandler(this.nodeFileTextBox_TextChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(3, 67);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(406, 26);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.TextChanged += new System.EventHandler(this.portTextBox_TextChanged);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(3, 99);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(406, 157);
            this.logTextBox.TabIndex = 9;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.cancelButton);
            this.flowLayoutPanel4.Controls.Add(this.applyButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(612, 266);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(239, 65);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 60);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(122, 3);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(113, 60);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.folderButton);
            this.flowLayoutPanel3.Controls.Add(this.fileButton);
            this.flowLayoutPanel3.Controls.Add(this.clearLogBtn);
            this.flowLayoutPanel3.Controls.Add(this.createCertBtn);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(672, 3);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(63, 3, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(118, 257);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(3, 0);
            this.folderButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(113, 26);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "...";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(3, 26);
            this.fileButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(113, 26);
            this.fileButton.TabIndex = 4;
            this.fileButton.Text = "...";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // clearLogBtn
            // 
            this.clearLogBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLogBtn.Location = new System.Drawing.Point(3, 57);
            this.clearLogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.clearLogBtn.Name = "clearLogBtn";
            this.clearLogBtn.Size = new System.Drawing.Size(113, 74);
            this.clearLogBtn.TabIndex = 3;
            this.clearLogBtn.Text = "Clear Logs";
            this.clearLogBtn.UseVisualStyleBackColor = true;
            this.clearLogBtn.Click += new System.EventHandler(this.clearLogBtn_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.startCheckBox);
            this.flowLayoutPanel5.Controls.Add(this.minimizeCheckBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 266);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(188, 65);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // startCheckBox
            // 
            this.startCheckBox.Checked = true;
            this.startCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startCheckBox.Location = new System.Drawing.Point(3, 3);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(183, 24);
            this.startCheckBox.TabIndex = 3;
            this.startCheckBox.Text = "Start with Windows";
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.startCheckBox_CheckedChanged);
            // 
            // minimizeCheckBox
            // 
            this.minimizeCheckBox.Checked = true;
            this.minimizeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimizeCheckBox.Location = new System.Drawing.Point(3, 33);
            this.minimizeCheckBox.Name = "minimizeCheckBox";
            this.minimizeCheckBox.Size = new System.Drawing.Size(196, 24);
            this.minimizeCheckBox.TabIndex = 4;
            this.minimizeCheckBox.Text = "Close minimizes to tray";
            this.minimizeCheckBox.UseVisualStyleBackColor = true;
            this.minimizeCheckBox.CheckedChanged += new System.EventHandler(this.minimizeCheckBox_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Server stopped";
            this.notifyIcon.BalloonTipTitle = "My Personal Server";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Node (*.exe)|*.exe|All files (*.*)|*.*";
            this.openFileDialog.InitialDirectory = "C:/";
            // 
            // createCertBtn
            // 
            this.createCertBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createCertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCertBtn.Location = new System.Drawing.Point(3, 136);
            this.createCertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.createCertBtn.Name = "createCertBtn";
            this.createCertBtn.Size = new System.Drawing.Size(113, 74);
            this.createCertBtn.TabIndex = 5;
            this.createCertBtn.Text = "Create Cert";
            this.createCertBtn.UseVisualStyleBackColor = true;
            this.createCertBtn.Click += new System.EventHandler(this.createCertBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(874, 390);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox rootTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.CheckBox startCheckBox;
        private System.Windows.Forms.CheckBox minimizeCheckBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.CheckBox clearLogsCheckBox;
        private System.Windows.Forms.Button clearLogBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox startServerChkBx;
        private System.Windows.Forms.CheckBox startMinChkBx;
        private System.Windows.Forms.TextBox nodeFileTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button createCertBtn;
    }
}

