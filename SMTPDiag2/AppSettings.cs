using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTPDiag2
{
    public class AppSettings
    {
        public string SMTPServer { get; set; }
        public string Port { get; set; }
        public bool ServerRequiresAuth { get; set; }
        public string AuthType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string HTMLMessage { get; set; }
        public List<string> Attachments { get; set; } = new List<string>();
        public bool AutoClear { get; set; }
        public string FontSize { get; set; }
    }
}
