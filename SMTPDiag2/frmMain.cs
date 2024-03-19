using MailKit.Net.Smtp;
using MimeKit;
using System.Text.RegularExpressions;
using DnsClient;
using Newtonsoft.Json;
using SMTPDiag2.Helpers;
using System.Net;
using System.Runtime.CompilerServices;
using MailKit;

namespace SMTPDiag2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDNSLookup_Click(object sender, EventArgs e)
        {
            var dnsText = LookupDNSAsync(this.txtSMTPServer.Text);

            if (dnsText.Count > 0)
            {
                this.txtSMTPConnectionLog.AppendText("\r\nDNS Record(s) for " + this.txtSMTPServer.Text + ":\r\n");
                this.txtSMTPServer.Text = dnsText[0].Value;

                // Gets the first MX record in the dnsText list where the type is MX and sets it as the value of the txtSMTPServer textbox
                this.txtSMTPServer.Text = dnsText.FirstOrDefault(x => x.Type == DNSItemType.MX).Value;


                foreach (var item in dnsText)
                {
                    if (item.Type == DNSItemType.MX)
                    {
                        this.txtSMTPConnectionLog.AppendText($"TYPE: {item.Type.ToString()}   VALUE: {item.Value} \r\n");
                    }
                    else
                    {
                        this.txtSMTPConnectionLog.AppendText($"TYPE: {item.Type.ToString()}   NAME: {item.Name}   VALUE: {item.Value} \r\n");
                    }
                }
            }
        }

        private void chkServerRequiresAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkServerRequiresAuthentication.Checked)
            {
                this.txtUsername.Enabled = true;
                this.txtPassword.Enabled = true;
                this.cmbAuthType.Enabled = true;
            }
            else
            {
                this.txtUsername.Enabled = false;
                this.txtPassword.Enabled = false;
                this.cmbAuthType.Enabled = false;
            }
        }
                

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.chkAutoIncrement.Checked)
            {
                try
                {
                    string oldSubject = this.txtSubject.Text;
                    string newSubject = Regex.Replace(oldSubject, "\\d+", m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
                    this.txtSubject.Text = newSubject;
                }
                catch { }
            }

            this.txtSMTPConnectionLog.AppendText("\r\n");

            SaveSettings();

            if (this.chkAutoClear.Checked)
            {
                this.txtSMTPConnectionLog.Clear();
            }

            this.txtSMTPConnectionLog.AppendText("");

            this.btnSend.Enabled = false;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(this.txtFrom.Text));
                message.To.Add(MailboxAddress.Parse(this.txtTo.Text));
                message.Subject = this.txtSubject.Text;

                if (!string.IsNullOrWhiteSpace(this.txtCC.Text))
                {
                    message.Cc.Add(MailboxAddress.Parse(this.txtCC.Text));
                }
                if (!string.IsNullOrWhiteSpace(this.txtBCC.Text))
                {
                    message.Bcc.Add(MailboxAddress.Parse(this.txtBCC.Text));
                }

                var builder = new BodyBuilder { HtmlBody = this.txtHTMLMessage.Text };

                foreach (var attachment in this.lstAttachments.Items)
                {
                    builder.Attachments.Add(attachment.ToString());
                }
                message.Body = builder.ToMessageBody();

                using (var memoryStream = new MemoryStream())
                {
                    using (var client = new SmtpClient(new ProtocolLogger(memoryStream)))
                    {
                        client.Timeout = 10000; // 10 seconds
                        client.Connect(this.txtSMTPServer.Text, Convert.ToInt32(this.cmbPort.Text), false);

                        if (this.chkServerRequiresAuthentication.Checked)
                        {
                            // Assuming "User and Password" as default
                            client.Authenticate(this.txtUsername.Text, this.txtPassword.Text);
                        }

                        client.Send(message);
                        client.Disconnect(true);

                        // Write logs to txtSMTPConnectionLog TextBox
                        memoryStream.Position = 0;
                        using (var reader = new StreamReader(memoryStream))
                        {
                            this.txtSMTPConnectionLog.AppendText(reader.ReadToEnd());
                        }
                    }
                }

                this.txtSMTPConnectionLog.AppendText("Message Sent Successfully");
            }
            catch (Exception ex)
            {
                this.txtSMTPConnectionLog.AppendText("\r\nError: " + ex.Message);
                this.txtSMTPConnectionLog.AppendText("\r\nFailed to send message");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.btnSend.Enabled = true;
            }

            if (!this.chkAutoClear.Checked)
            {
                this.txtSMTPConnectionLog.AppendText("\r\n---------------------------------");
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string oldTo = this.txtTo.Text;
            string oldFrom = this.txtFrom.Text;

            this.txtFrom.Text = oldTo;
            this.txtTo.Text = oldFrom;
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            this.lstAttachments.Items.Add(openFileDialog1.FileName);
        }

        private void btnRemoveAttachments_Click(object sender, EventArgs e)
        {
            this.lstAttachments.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstAttachments.SelectedItem));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSMTPConnectionLog.Clear();
        }

        private void cmbConnectionLogFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void whatIsMyIPAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetIPInfo();
        }


        private void testEmailServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://mxtoolbox.com/SuperTool.aspx?action=smtp%3a" + this.txtSMTPServer.Text + "&run=toolpage";
            BrowserOpener.OpenUrl(url);
        }

        private void portListnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPortTest frm = new frmPortTest();
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void ChangeFont()
        {

            try
            {
                if (this.cmbConnectionLogFontSize.Text.Length > 0)
                {
                    Single fontSize = Convert.ToSingle(this.cmbConnectionLogFontSize.Text);

                    if (fontSize > 4 && fontSize < 26)
                    {
                        this.txtSMTPConnectionLog.Font = new System.Drawing.Font("Lucida Console", fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }

            }
            catch { }
        }

        public List<DNSItem> LookupDNSAsync(string domain)
        {
            List<DNSItem> dnsItems = new List<DNSItem>();
            var dnsQuery = new LookupClient();
            var result = dnsQuery.Query(domain, QueryType.MX);

            foreach (var item in result.Answers.MxRecords().Select(mx => mx.Exchange.ToString()))
            {
                dnsItems.Add(new DNSItem() { Type = DNSItemType.MX, Value = item });
            }

            result = dnsQuery.Query(domain, QueryType.TXT);
            foreach (var item in result.Answers.TxtRecords().Select(txt => txt.Text))
            {
                dnsItems.Add(new DNSItem() { Type = DNSItemType.TXT, Value = item.FirstOrDefault().ToString() });
            }

            return dnsItems;
        }

        public async Task GetIPInfo()
        {
            List<IPAddress> addresses = GetLocalIPAddress();

            if (addresses.Count > 0) this.txtSMTPConnectionLog.AppendText("\r\nLocal IP Address(es):\r\n");
            foreach (IPAddress item in addresses)
            {
                this.txtSMTPConnectionLog.AppendText("\t" + item.ToString() + "\r\n");
            }

            // Await the GetPublicIP method and then append the result
            string publicIP = await GetPublicIPAsync(); // Make sure the method is named GetPublicIPAsync
            this.txtSMTPConnectionLog.AppendText("\r\nPublic IP Address: " + publicIP + "\r\n");
        }

        public async Task<string> GetPublicIPAsync()
        {

            string externalIP = "";
            // Instantiate HttpClient
            using (var client = new HttpClient())
            {
                // Set User-Agent header
                client.DefaultRequestHeaders.UserAgent.ParseAdd("curl - smtpdiag2.2");

                // Make asynchronous GET request
                externalIP = await client.GetStringAsync("http://ip4.info");
            }
            return externalIP.Replace("\r\n", "") + " (via ip4.info)";
        }

        private List<IPAddress> GetLocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host.AddressList.ToList();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.cmbAuthType.Text = "None";

            this.txtUsername.Enabled = false;
            this.txtPassword.Enabled = false;
            this.cmbAuthType.Enabled = false;

            LoadSettings();
        }

        private string GetSettingsFilePath()
        {
            var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appFolder = Path.Combine(appDataFolder, "SMTPDiag2");
            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }
            return Path.Combine(appFolder, "settings.json");
        }

        private void LoadSettings()
        {
            try
            {
                var filePath = GetSettingsFilePath();
                if (File.Exists(filePath))
                {
                    var settingsJson = File.ReadAllText(filePath);
                    var settings = JsonConvert.DeserializeObject<AppSettings>(settingsJson);

                    this.txtSMTPServer.Text = settings.SMTPServer;
                    this.cmbPort.Text = settings.Port.ToString();
                    this.chkServerRequiresAuthentication.Checked = Convert.ToBoolean(settings.ServerRequiresAuth);
                    this.cmbAuthType.Text = settings.AuthType;
                    this.txtUsername.Text = settings.Username;
                    this.txtPassword.Text = settings.Password;
                    this.txtFrom.Text = settings.From;
                    this.txtTo.Text = settings.To;
                    this.txtCC.Text = settings.CC;
                    this.txtBCC.Text = settings.BCC;
                    this.txtSubject.Text = settings.Subject;
                    this.txtHTMLMessage.Text = settings.HTMLMessage;
                    this.chkAutoClear.Checked = Convert.ToBoolean(settings.AutoClear);
                    this.cmbConnectionLogFontSize.Text = settings.FontSize;

                    List<string> attachments = settings.Attachments;

                    foreach (string item in attachments)
                    {
                        this.lstAttachments.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SaveSettings()
        {
            try
            {
                var settings = new AppSettings
                {
                    Attachments = this.lstAttachments.Items.Cast<string>().ToList(),
                    AutoClear = this.chkAutoClear.Checked,
                    BCC = this.txtBCC.Text,
                    CC = this.txtCC.Text,
                    FontSize = this.cmbConnectionLogFontSize.Text,
                    From = this.txtFrom.Text,
                    HTMLMessage = this.txtHTMLMessage.Text,
                    Password = this.txtPassword.Text,
                    Port = this.cmbPort.Text,
                    ServerRequiresAuth = this.chkServerRequiresAuthentication.Checked,
                    SMTPServer = this.txtSMTPServer.Text,
                    Subject = this.txtSubject.Text,
                    To = this.txtTo.Text,
                    Username = this.txtUsername.Text,
                    AuthType = this.cmbAuthType.Text
                };

                var settingsJson = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(GetSettingsFilePath(), settingsJson);
            }
            catch (Exception ex)
            {

            }
        }
    }

}
