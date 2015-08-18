namespace BVSCDiagnostics
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
            this.lblTestsPerformed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTestBvscSrvIP = new System.Windows.Forms.Label();
            this.lblTestBvscSrvName = new System.Windows.Forms.Label();
            this.lblTestRouterIP = new System.Windows.Forms.Label();
            this.lblTestGoogleDnsIP = new System.Windows.Forms.Label();
            this.lblTestGoogleDnsName = new System.Windows.Forms.Label();
            this.lblTestEzyVetIP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDnsAddress = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnRunDiagnostics = new System.Windows.Forms.Button();
            this.progressBarTest = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnFlushDNS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveScreenshotResults = new System.Windows.Forms.Button();
            this.btnShowRouter = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRunTeamViewer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTestsPerformed
            // 
            this.lblTestsPerformed.AutoSize = true;
            this.lblTestsPerformed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestsPerformed.Location = new System.Drawing.Point(15, 77);
            this.lblTestsPerformed.Name = "lblTestsPerformed";
            this.lblTestsPerformed.Size = new System.Drawing.Size(47, 16);
            this.lblTestsPerformed.TabIndex = 0;
            this.lblTestsPerformed.Text = "Tests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connect to BVSC Server IP (192.168.1.8): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connect to BVSC Server Name (bvsc1): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Connect to Router IP (192.168.1.1):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Connect to Google DNS (8.8.8.8):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Connect to Google (google.com.au):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Connect to EzyVet (54.240.192.109):";
            // 
            // lblTestBvscSrvIP
            // 
            this.lblTestBvscSrvIP.AutoSize = true;
            this.lblTestBvscSrvIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestBvscSrvIP.Location = new System.Drawing.Point(269, 99);
            this.lblTestBvscSrvIP.Name = "lblTestBvscSrvIP";
            this.lblTestBvscSrvIP.Size = new System.Drawing.Size(58, 16);
            this.lblTestBvscSrvIP.TabIndex = 7;
            this.lblTestBvscSrvIP.Text = "Pending";
            // 
            // lblTestBvscSrvName
            // 
            this.lblTestBvscSrvName.AutoSize = true;
            this.lblTestBvscSrvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestBvscSrvName.Location = new System.Drawing.Point(269, 116);
            this.lblTestBvscSrvName.Name = "lblTestBvscSrvName";
            this.lblTestBvscSrvName.Size = new System.Drawing.Size(58, 16);
            this.lblTestBvscSrvName.TabIndex = 8;
            this.lblTestBvscSrvName.Text = "Pending";
            // 
            // lblTestRouterIP
            // 
            this.lblTestRouterIP.AutoSize = true;
            this.lblTestRouterIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestRouterIP.Location = new System.Drawing.Point(269, 133);
            this.lblTestRouterIP.Name = "lblTestRouterIP";
            this.lblTestRouterIP.Size = new System.Drawing.Size(58, 16);
            this.lblTestRouterIP.TabIndex = 9;
            this.lblTestRouterIP.Text = "Pending";
            // 
            // lblTestGoogleDnsIP
            // 
            this.lblTestGoogleDnsIP.AutoSize = true;
            this.lblTestGoogleDnsIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestGoogleDnsIP.Location = new System.Drawing.Point(269, 150);
            this.lblTestGoogleDnsIP.Name = "lblTestGoogleDnsIP";
            this.lblTestGoogleDnsIP.Size = new System.Drawing.Size(58, 16);
            this.lblTestGoogleDnsIP.TabIndex = 10;
            this.lblTestGoogleDnsIP.Text = "Pending";
            // 
            // lblTestGoogleDnsName
            // 
            this.lblTestGoogleDnsName.AutoSize = true;
            this.lblTestGoogleDnsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestGoogleDnsName.Location = new System.Drawing.Point(269, 167);
            this.lblTestGoogleDnsName.Name = "lblTestGoogleDnsName";
            this.lblTestGoogleDnsName.Size = new System.Drawing.Size(58, 16);
            this.lblTestGoogleDnsName.TabIndex = 11;
            this.lblTestGoogleDnsName.Text = "Pending";
            // 
            // lblTestEzyVetIP
            // 
            this.lblTestEzyVetIP.AutoSize = true;
            this.lblTestEzyVetIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestEzyVetIP.Location = new System.Drawing.Point(269, 184);
            this.lblTestEzyVetIP.Name = "lblTestEzyVetIP";
            this.lblTestEzyVetIP.Size = new System.Drawing.Size(58, 16);
            this.lblTestEzyVetIP.TabIndex = 12;
            this.lblTestEzyVetIP.Text = "Pending";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Computer Details";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Computer Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(359, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "DNS IP Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(359, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "IP Address:";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerName.Location = new System.Drawing.Point(475, 99);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(0, 16);
            this.lblComputerName.TabIndex = 18;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(475, 116);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 16);
            this.lblUsername.TabIndex = 19;
            // 
            // lblDnsAddress
            // 
            this.lblDnsAddress.AutoSize = true;
            this.lblDnsAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDnsAddress.Location = new System.Drawing.Point(475, 133);
            this.lblDnsAddress.Name = "lblDnsAddress";
            this.lblDnsAddress.Size = new System.Drawing.Size(0, 16);
            this.lblDnsAddress.TabIndex = 20;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(475, 150);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(0, 16);
            this.lblIPAddress.TabIndex = 21;
            // 
            // btnRunDiagnostics
            // 
            this.btnRunDiagnostics.Location = new System.Drawing.Point(15, 229);
            this.btnRunDiagnostics.Name = "btnRunDiagnostics";
            this.btnRunDiagnostics.Size = new System.Drawing.Size(105, 23);
            this.btnRunDiagnostics.TabIndex = 22;
            this.btnRunDiagnostics.Text = "Run Diagnostics";
            this.btnRunDiagnostics.UseVisualStyleBackColor = true;
            this.btnRunDiagnostics.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBarTest
            // 
            this.progressBarTest.Location = new System.Drawing.Point(18, 206);
            this.progressBarTest.Maximum = 6;
            this.progressBarTest.Name = "progressBarTest";
            this.progressBarTest.Size = new System.Drawing.Size(247, 17);
            this.progressBarTest.Step = 6;
            this.progressBarTest.TabIndex = 23;
            this.progressBarTest.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(15, 292);
            this.lblResults.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 19);
            this.lblResults.TabIndex = 24;
            // 
            // btnFlushDNS
            // 
            this.btnFlushDNS.Enabled = false;
            this.btnFlushDNS.Location = new System.Drawing.Point(6, 19);
            this.btnFlushDNS.Name = "btnFlushDNS";
            this.btnFlushDNS.Size = new System.Drawing.Size(104, 23);
            this.btnFlushDNS.TabIndex = 25;
            this.btnFlushDNS.Text = "Flush DNS Cache";
            this.btnFlushDNS.UseVisualStyleBackColor = true;
            this.btnFlushDNS.Click += new System.EventHandler(this.btnFlushDNS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRunTeamViewer);
            this.groupBox1.Controls.Add(this.btnSaveScreenshotResults);
            this.groupBox1.Controls.Add(this.btnShowRouter);
            this.groupBox1.Controls.Add(this.btnFlushDNS);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 56);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSaveScreenshotResults
            // 
            this.btnSaveScreenshotResults.Enabled = false;
            this.btnSaveScreenshotResults.Location = new System.Drawing.Point(232, 19);
            this.btnSaveScreenshotResults.Name = "btnSaveScreenshotResults";
            this.btnSaveScreenshotResults.Size = new System.Drawing.Size(151, 23);
            this.btnSaveScreenshotResults.TabIndex = 27;
            this.btnSaveScreenshotResults.Text = "Save Screenshot of Results";
            this.btnSaveScreenshotResults.UseVisualStyleBackColor = true;
            this.btnSaveScreenshotResults.Click += new System.EventHandler(this.btnSaveScreenshotResults_Click);
            // 
            // btnShowRouter
            // 
            this.btnShowRouter.Enabled = false;
            this.btnShowRouter.Location = new System.Drawing.Point(117, 19);
            this.btnShowRouter.Name = "btnShowRouter";
            this.btnShowRouter.Size = new System.Drawing.Size(109, 23);
            this.btnShowRouter.TabIndex = 26;
            this.btnShowRouter.Text = "Show Router Image";
            this.btnShowRouter.UseVisualStyleBackColor = true;
            this.btnShowRouter.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(557, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "© YesIT 2015. Ver 0.9.0";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnRunTeamViewer
            // 
            this.btnRunTeamViewer.Location = new System.Drawing.Point(390, 19);
            this.btnRunTeamViewer.Name = "btnRunTeamViewer";
            this.btnRunTeamViewer.Size = new System.Drawing.Size(105, 23);
            this.btnRunTeamViewer.TabIndex = 28;
            this.btnRunTeamViewer.Text = "Run TeamViewer";
            this.btnRunTeamViewer.UseVisualStyleBackColor = true;
            this.btnRunTeamViewer.Click += new System.EventHandler(this.btnRunTeamViewer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 603);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.progressBarTest);
            this.Controls.Add(this.btnRunDiagnostics);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.lblDnsAddress);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblComputerName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTestEzyVetIP);
            this.Controls.Add(this.lblTestGoogleDnsName);
            this.Controls.Add(this.lblTestGoogleDnsIP);
            this.Controls.Add(this.lblTestRouterIP);
            this.Controls.Add(this.lblTestBvscSrvName);
            this.Controls.Add(this.lblTestBvscSrvIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTestsPerformed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "YesIT - BVSC Diagnostics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestsPerformed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTestBvscSrvName;
        private System.Windows.Forms.Label lblTestRouterIP;
        private System.Windows.Forms.Label lblTestGoogleDnsIP;
        private System.Windows.Forms.Label lblTestGoogleDnsName;
        private System.Windows.Forms.Label lblTestEzyVetIP;
        private System.Windows.Forms.Label lblTestBvscSrvIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDnsAddress;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Button btnRunDiagnostics;
        private System.Windows.Forms.ProgressBar progressBarTest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnFlushDNS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowRouter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveScreenshotResults;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRunTeamViewer;
    }
}

