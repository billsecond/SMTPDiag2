using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTPDiag2
{
    public enum DNSItemType
    {
        A,
        MX,
        NS,
        SOA,
        TXT,
        CNAME,
        PTR,
        SRV,
        AAAA,
        ANY
    }

    public class DNSItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public DNSItemType Type { get; set; }
    }
}