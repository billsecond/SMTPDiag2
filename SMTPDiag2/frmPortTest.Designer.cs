namespace SMTPDiag2
{
    partial class frmPortTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortTest));
            label1 = new Label();
            txtPort = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnListen = new Button();
            txtResponseText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnClearLog = new Button();
            lstPorts = new ListBox();
            lstConnections = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Port Number:";
            // 
            // txtPort
            // 
            txtPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPort.Location = new Point(104, 14);
            txtPort.Margin = new Padding(4, 3, 4, 3);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(206, 23);
            txtPort.TabIndex = 1;
            // 
            // btnListen
            // 
            btnListen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnListen.Location = new Point(317, 12);
            btnListen.Margin = new Padding(4, 3, 4, 3);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(88, 27);
            btnListen.TabIndex = 2;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += BtnListen_Click;
            // 
            // txtResponseText
            // 
            txtResponseText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtResponseText.Location = new Point(219, 44);
            txtResponseText.Margin = new Padding(4, 3, 4, 3);
            txtResponseText.Name = "txtResponseText";
            txtResponseText.Size = new Size(185, 23);
            txtResponseText.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 3;
            label2.Text = "Response to Remote on Connect:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 77);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Listening on Ports:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 263);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 7;
            label4.Text = "Connections Made:";
            // 
            // btnClearLog
            // 
            btnClearLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearLog.Location = new Point(317, 252);
            btnClearLog.Margin = new Padding(4, 3, 4, 3);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(88, 27);
            btnClearLog.TabIndex = 9;
            btnClearLog.Text = "Clear Log";
            btnClearLog.UseVisualStyleBackColor = true;
            // 
            // lstPorts
            // 
            lstPorts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstPorts.FormattingEnabled = true;
            lstPorts.ItemHeight = 15;
            lstPorts.Location = new Point(14, 96);
            lstPorts.Margin = new Padding(4, 3, 4, 3);
            lstPorts.Name = "lstPorts";
            lstPorts.Size = new Size(390, 139);
            lstPorts.TabIndex = 10;
            // 
            // lstConnections
            // 
            lstConnections.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstConnections.FormattingEnabled = true;
            lstConnections.ItemHeight = 15;
            lstConnections.Location = new Point(14, 285);
            lstConnections.Margin = new Padding(4, 3, 4, 3);
            lstConnections.Name = "lstConnections";
            lstConnections.Size = new Size(390, 184);
            lstConnections.TabIndex = 11;
            // 
            // frmPortTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 489);
            Controls.Add(lstConnections);
            Controls.Add(lstPorts);
            Controls.Add(btnClearLog);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtResponseText);
            Controls.Add(label2);
            Controls.Add(btnListen);
            Controls.Add(txtPort);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(729, 772);
            MinimumSize = new Size(387, 461);
            Name = "frmPortTest";
            Text = "Port Listener";
            FormClosing += FrmPortTest_FormClosing;
            Load += FrmPortTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtResponseText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ListBox lstPorts;
        private System.Windows.Forms.ListBox lstConnections;
    }
}