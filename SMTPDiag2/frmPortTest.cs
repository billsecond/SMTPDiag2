using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SMTPDiag2
{
    public partial class frmPortTest : Form
    {
        public frmPortTest()
        {
            InitializeComponent();
        }

        private void FrmPortTest_Load(object sender, EventArgs e)
        {
        }

        public string Port = "";
        public string SendText = "";

        private void BtnListen_Click(object sender, EventArgs e)
        {
            this.Port = this.txtPort.Text;
            this.SendText = this.txtResponseText.Text;

            if (!Information.IsNumeric((object)this.txtPort.Text))
            {
                int num = (int)MessageBox.Show("Port must be a number", "Port Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (Convert.ToDouble(this.txtPort.Text) > (double)ushort.MaxValue | Convert.ToDouble(this.txtPort.Text) < 0.0)
            {
                int num = (int)MessageBox.Show("Port number must be between 0 and 65535", "Port Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.txtPort.Text = "";
                this.txtResponseText.Text = "";

                IProgress<string> addPorts = new Progress<string>(valueToAdd =>
                {
                    this.lstPorts.Items.Add(valueToAdd);
                });

                IProgress<string> addLog = new Progress<string>(valueToAdd =>
                {
                    this.lstConnections.Items.Add(valueToAdd);
                });


                new Thread(delegate ()
                {

                    Thread.Sleep(100);
                    int port = Convert.ToInt32(this.Port);

                    TcpListener tcpListener = new TcpListener(port);
                    try
                    {
                        tcpListener.Start();

                        addPorts.Report(port.ToString() + " - " + this.SendText);

                        while (true)
                        {
                            TcpClient tcpClient = tcpListener.AcceptTcpClient();
                            string str = "Connection on port: " + port.ToString() + " at " + DateAndTime.Now.ToString();
                            addLog.Report(str);
                            NetworkStream stream = tcpClient.GetStream();
                            byte[] bytes = Encoding.ASCII.GetBytes(SendText);
                            stream.Write(bytes, 0, bytes.Length);
                            stream.Close();
                            tcpClient.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        addLog.Report("Error: " + ex.Message);
                    }
                }).Start();
            }
        }

        private void FrmPortTest_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
