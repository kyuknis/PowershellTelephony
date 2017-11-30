using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management.Automation;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using PowerShellModules.Models;

namespace PowerShellModules
{
    [Cmdlet(VerbsCommon.New, "SmsMessage")]
    [OutputType(typeof(TwilioMessage))]
    public class NewSmsMessageCmdlet: Cmdlet
    {
        [Parameter]
        public string AccountSid { get; set; }

        [Parameter(ValueFromPipeline = true)]
        public string AuthToken { get; set; }

        [Parameter]
        public string Recipient { get; set; }

        [Parameter]
        public string Sender { get; set; }

        [Parameter(ValueFromPipeline = true)]
        public string Body { get; set; }


        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
