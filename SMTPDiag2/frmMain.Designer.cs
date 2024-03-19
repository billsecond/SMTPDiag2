namespace SMTPDiag2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            cmbConnectionLogFontSize = new ComboBox();
            label12 = new Label();
            btnClear = new Button();
            txtSMTPConnectionLog = new TextBox();
            chkAutoClear = new CheckBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            resourcesToolStripMenuItem = new ToolStripMenuItem();
            whatIsMyIPAddressToolStripMenuItem = new ToolStripMenuItem();
            mXToolboxToolStripMenuItem = new ToolStripMenuItem();
            testEmailServerToolStripMenuItem = new ToolStripMenuItem();
            portListnerToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            btnRemoveAttachments = new Button();
            btnAddAttachment = new Button();
            label11 = new Label();
            lstAttachments = new ListBox();
            groupBox3 = new GroupBox();
            chkAutoIncrement = new CheckBox();
            txtHTMLMessage = new TextBox();
            txtSubject = new TextBox();
            label9 = new Label();
            txtCC = new TextBox();
            label8 = new Label();
            txtBCC = new TextBox();
            label7 = new Label();
            txtTo = new TextBox();
            label6 = new Label();
            btnSwap = new Button();
            btnSend = new Button();
            txtFrom = new TextBox();
            label10 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            cmbAuthType = new ComboBox();
            label5 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            chkServerRequiresAuthentication = new CheckBox();
            cmbPort = new ComboBox();
            label2 = new Label();
            btnDNSLookup = new Button();
            txtSMTPServer = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbConnectionLogFontSize
            // 
            cmbConnectionLogFontSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbConnectionLogFontSize.FormattingEnabled = true;
            cmbConnectionLogFontSize.Items.AddRange(new object[] { "8", "8.25", "9", "10", "11", "12", "13" });
            cmbConnectionLogFontSize.Location = new Point(1047, 490);
            cmbConnectionLogFontSize.Name = "cmbConnectionLogFontSize";
            cmbConnectionLogFontSize.Size = new Size(88, 23);
            cmbConnectionLogFontSize.TabIndex = 27;
            cmbConnectionLogFontSize.Text = "9";
            cmbConnectionLogFontSize.SelectedIndexChanged += cmbConnectionLogFontSize_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(1009, 493);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 26;
            label12.Text = "Size:";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Location = new Point(813, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtSMTPConnectionLog
            // 
            txtSMTPConnectionLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSMTPConnectionLog.BackColor = Color.Black;
            txtSMTPConnectionLog.ForeColor = Color.Lime;
            txtSMTPConnectionLog.Location = new Point(545, 32);
            txtSMTPConnectionLog.Multiline = true;
            txtSMTPConnectionLog.Name = "txtSMTPConnectionLog";
            txtSMTPConnectionLog.ReadOnly = true;
            txtSMTPConnectionLog.ScrollBars = ScrollBars.Vertical;
            txtSMTPConnectionLog.Size = new Size(590, 452);
            txtSMTPConnectionLog.TabIndex = 23;
            txtSMTPConnectionLog.Text = "Ready!";
            // 
            // chkAutoClear
            // 
            chkAutoClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkAutoClear.AutoSize = true;
            chkAutoClear.Checked = true;
            chkAutoClear.CheckState = CheckState.Checked;
            chkAutoClear.Location = new Point(545, 492);
            chkAutoClear.Name = "chkAutoClear";
            chkAutoClear.Size = new Size(153, 19);
            chkAutoClear.TabIndex = 24;
            chkAutoClear.Text = "Automatically Clear Log";
            chkAutoClear.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, resourcesToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1147, 24);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // resourcesToolStripMenuItem
            // 
            resourcesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whatIsMyIPAddressToolStripMenuItem, mXToolboxToolStripMenuItem, portListnerToolStripMenuItem });
            resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            resourcesToolStripMenuItem.Size = new Size(72, 20);
            resourcesToolStripMenuItem.Text = "&Resources";
            // 
            // whatIsMyIPAddressToolStripMenuItem
            // 
            whatIsMyIPAddressToolStripMenuItem.Name = "whatIsMyIPAddressToolStripMenuItem";
            whatIsMyIPAddressToolStripMenuItem.Size = new Size(191, 22);
            whatIsMyIPAddressToolStripMenuItem.Text = "What is my &IP Address";
            whatIsMyIPAddressToolStripMenuItem.Click += whatIsMyIPAddressToolStripMenuItem_Click;
            // 
            // mXToolboxToolStripMenuItem
            // 
            mXToolboxToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testEmailServerToolStripMenuItem });
            mXToolboxToolStripMenuItem.Name = "mXToolboxToolStripMenuItem";
            mXToolboxToolStripMenuItem.Size = new Size(191, 22);
            mXToolboxToolStripMenuItem.Text = "MX Toolbox";
            // 
            // testEmailServerToolStripMenuItem
            // 
            testEmailServerToolStripMenuItem.Name = "testEmailServerToolStripMenuItem";
            testEmailServerToolStripMenuItem.Size = new Size(161, 22);
            testEmailServerToolStripMenuItem.Text = "Test Email Server";
            testEmailServerToolStripMenuItem.Click += testEmailServerToolStripMenuItem_Click;
            // 
            // portListnerToolStripMenuItem
            // 
            portListnerToolStripMenuItem.Name = "portListnerToolStripMenuItem";
            portListnerToolStripMenuItem.Size = new Size(191, 22);
            portListnerToolStripMenuItem.Text = "Port Listner";
            portListnerToolStripMenuItem.Click += portListnerToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // btnRemoveAttachments
            // 
            btnRemoveAttachments.Location = new Point(446, 304);
            btnRemoveAttachments.Name = "btnRemoveAttachments";
            btnRemoveAttachments.Size = new Size(75, 23);
            btnRemoveAttachments.TabIndex = 16;
            btnRemoveAttachments.Text = "Remove";
            btnRemoveAttachments.UseVisualStyleBackColor = true;
            btnRemoveAttachments.Click += btnRemoveAttachments_Click;
            // 
            // btnAddAttachment
            // 
            btnAddAttachment.Location = new Point(446, 278);
            btnAddAttachment.Name = "btnAddAttachment";
            btnAddAttachment.Size = new Size(75, 23);
            btnAddAttachment.TabIndex = 15;
            btnAddAttachment.Text = "Add";
            btnAddAttachment.UseVisualStyleBackColor = true;
            btnAddAttachment.Click += btnAddAttachment_Click;
            // 
            // label11
            // 
            label11.Location = new Point(11, 260);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 14;
            label11.Text = "Attachments";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstAttachments
            // 
            lstAttachments.FormattingEnabled = true;
            lstAttachments.ItemHeight = 15;
            lstAttachments.Location = new Point(11, 278);
            lstAttachments.Name = "lstAttachments";
            lstAttachments.Size = new Size(429, 49);
            lstAttachments.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRemoveAttachments);
            groupBox3.Controls.Add(btnAddAttachment);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lstAttachments);
            groupBox3.Controls.Add(chkAutoIncrement);
            groupBox3.Controls.Add(txtHTMLMessage);
            groupBox3.Controls.Add(txtSubject);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtCC);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtBCC);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTo);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnSwap);
            groupBox3.Controls.Add(btnSend);
            groupBox3.Controls.Add(txtFrom);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(12, 179);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(527, 336);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mail Server Settings";
            // 
            // chkAutoIncrement
            // 
            chkAutoIncrement.AutoSize = true;
            chkAutoIncrement.Checked = true;
            chkAutoIncrement.CheckState = CheckState.Checked;
            chkAutoIncrement.Location = new Point(404, 110);
            chkAutoIncrement.Name = "chkAutoIncrement";
            chkAutoIncrement.Size = new Size(109, 19);
            chkAutoIncrement.TabIndex = 8;
            chkAutoIncrement.Text = "Auto Increment";
            chkAutoIncrement.UseVisualStyleBackColor = true;
            // 
            // txtHTMLMessage
            // 
            txtHTMLMessage.Location = new Point(11, 137);
            txtHTMLMessage.Multiline = true;
            txtHTMLMessage.Name = "txtHTMLMessage";
            txtHTMLMessage.ScrollBars = ScrollBars.Both;
            txtHTMLMessage.Size = new Size(502, 112);
            txtHTMLMessage.TabIndex = 12;
            txtHTMLMessage.Text = "This is a test message from SMTP Diag Tool 2.2";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(69, 108);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(329, 23);
            txtSubject.TabIndex = 11;
            txtSubject.Text = "Test from Diag Tool - Test 1";
            // 
            // label9
            // 
            label9.Location = new Point(11, 111);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 10;
            label9.Text = "Subject:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCC
            // 
            txtCC.Location = new Point(121, 79);
            txtCC.Name = "txtCC";
            txtCC.Size = new Size(163, 23);
            txtCC.TabIndex = 7;
            // 
            // label8
            // 
            label8.Location = new Point(279, 82);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 8;
            label8.Text = "BCC:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBCC
            // 
            txtBCC.Location = new Point(337, 79);
            txtBCC.Name = "txtBCC";
            txtBCC.Size = new Size(176, 23);
            txtBCC.TabIndex = 9;
            // 
            // label7
            // 
            label7.Location = new Point(63, 82);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 6;
            label7.Text = "CC:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(121, 50);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(335, 23);
            txtTo.TabIndex = 5;
            // 
            // label6
            // 
            label6.Location = new Point(63, 53);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 4;
            label6.Text = "To:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSwap
            // 
            btnSwap.Location = new Point(462, 22);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new Size(51, 51);
            btnSwap.TabIndex = 3;
            btnSwap.Text = "Swap";
            btnSwap.UseVisualStyleBackColor = true;
            btnSwap.Click += btnSwap_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(6, 22);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(51, 80);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(121, 21);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(335, 23);
            txtFrom.TabIndex = 1;
            // 
            // label10
            // 
            label10.Location = new Point(63, 24);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 0;
            label10.Text = "From:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "SMTP Server:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cmbPort);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnDNSLookup);
            groupBox1.Controls.Add(txtSMTPServer);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 141);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mail Server Settings";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbAuthType);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtUsername);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(chkServerRequiresAuthentication);
            groupBox2.Location = new Point(30, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(491, 83);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Authentication Settings";
            // 
            // cmbAuthType
            // 
            cmbAuthType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuthType.Enabled = false;
            cmbAuthType.FormattingEnabled = true;
            cmbAuthType.Items.AddRange(new object[] { "User and Password (Default)", "CRAM-MD5", "NTLM", "Keberos", "None" });
            cmbAuthType.Location = new Point(365, 19);
            cmbAuthType.Name = "cmbAuthType";
            cmbAuthType.Size = new Size(118, 23);
            cmbAuthType.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 22);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 6;
            label5.Text = "Auth Type:";
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(320, 47);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(163, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(82, 47);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(146, 23);
            txtUsername.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 50);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 50);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // chkServerRequiresAuthentication
            // 
            chkServerRequiresAuthentication.AutoSize = true;
            chkServerRequiresAuthentication.Location = new Point(16, 22);
            chkServerRequiresAuthentication.Name = "chkServerRequiresAuthentication";
            chkServerRequiresAuthentication.Size = new Size(188, 19);
            chkServerRequiresAuthentication.TabIndex = 0;
            chkServerRequiresAuthentication.Text = "Server Requires Authentication";
            chkServerRequiresAuthentication.UseVisualStyleBackColor = true;
            chkServerRequiresAuthentication.CheckedChanged += chkServerRequiresAuthentication_CheckedChanged;
            // 
            // cmbPort
            // 
            cmbPort.FormattingEnabled = true;
            cmbPort.Items.AddRange(new object[] { "25", "465", "587", "2525" });
            cmbPort.Location = new Point(433, 22);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(88, 23);
            cmbPort.TabIndex = 4;
            cmbPort.Text = "25";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 25);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Port:";
            // 
            // btnDNSLookup
            // 
            btnDNSLookup.Location = new Point(290, 22);
            btnDNSLookup.Name = "btnDNSLookup";
            btnDNSLookup.Size = new Size(90, 23);
            btnDNSLookup.TabIndex = 2;
            btnDNSLookup.Text = "DNS Lookup";
            btnDNSLookup.UseVisualStyleBackColor = true;
            btnDNSLookup.Click += btnDNSLookup_Click;
            // 
            // txtSMTPServer
            // 
            txtSMTPServer.Location = new Point(92, 22);
            txtSMTPServer.Name = "txtSMTPServer";
            txtSMTPServer.Size = new Size(192, 23);
            txtSMTPServer.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 525);
            Controls.Add(cmbConnectionLogFontSize);
            Controls.Add(label12);
            Controls.Add(btnClear);
            Controls.Add(txtSMTPConnectionLog);
            Controls.Add(chkAutoClear);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1163, 546);
            Name = "frmMain";
            Text = "SMTP Diag Tool 2.2";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbConnectionLogFontSize;
        private Label label12;
        private Button btnClear;
        private TextBox txtSMTPConnectionLog;
        private CheckBox chkAutoClear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem resourcesToolStripMenuItem;
        private ToolStripMenuItem whatIsMyIPAddressToolStripMenuItem;
        private ToolStripMenuItem mXToolboxToolStripMenuItem;
        private ToolStripMenuItem testEmailServerToolStripMenuItem;
        private ToolStripMenuItem portListnerToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button btnRemoveAttachments;
        private Button btnAddAttachment;
        private Label label11;
        private ListBox lstAttachments;
        private GroupBox groupBox3;
        private CheckBox chkAutoIncrement;
        private TextBox txtHTMLMessage;
        private TextBox txtSubject;
        private Label label9;
        private TextBox txtCC;
        private Label label8;
        private TextBox txtBCC;
        private Label label7;
        private TextBox txtTo;
        private Label label6;
        private Button btnSwap;
        private Button btnSend;
        private TextBox txtFrom;
        private Label label10;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cmbAuthType;
        private Label label5;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private CheckBox chkServerRequiresAuthentication;
        private ComboBox cmbPort;
        private Label label2;
        private Button btnDNSLookup;
        private TextBox txtSMTPServer;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
