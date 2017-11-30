using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellModules.Models
{
    public class TwilioMessage
    {
        public string AccountSid { get; set; }
        public string AuthToken { get; set; }
        public string Recepient { get; set; }
        public string Sender { get; set; }
        public string Body { get; set; }
    }
}
