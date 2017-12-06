    /* 
     * Powershell Telephony Library
     * Copyright(C) 2017  Yuknis Corp
     * 
     * This program is free software: you can redistribute it and/or modify
     * it under the terms of the GNU General Public License as published by
     * the Free Software Foundation, either version 3 of the License, or
     * (at your option) any later version.
     * 
     * This program is distributed in the hope that it will be useful,
     * but WITHOUT ANY WARRANTY; without even the implied warranty of
     * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
     * GNU General Public License for more details.
     *
     * You should have received a copy of the GNU General Public License
     * along with this program.If not, see<http://www.gnu.org/licenses/>.
     */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management.Automation;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using PowershellTelephony.Models;

namespace PowershellTelephony
{
    [Cmdlet(VerbsCommon.New, "SmsMessage")]
    [OutputType(typeof(TwilioMessage))]
    public class NewSmsMessageCmdlet : Cmdlet
    {
        [Parameter]
        public string AccountSid { get; set; }

        [Parameter]
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
            this.CreateTwilioClient(this.AccountSid, this.AuthToken);
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            this.SendSmsMessage(this.Recipient, this.Sender, this.Body);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }

        public void CreateTwilioClient(string AccountSid, string AuthToken)
        {
            TwilioClient.Init(AccountSid, AuthToken);
        }

        public void SendSmsMessage(string Recipient, string Sender, string Body = "")
        {
            var message = MessageResource.Create(
                to: new PhoneNumber(Recipient),
                from: new PhoneNumber(Sender),
                body: Body);
        }
    }
}
