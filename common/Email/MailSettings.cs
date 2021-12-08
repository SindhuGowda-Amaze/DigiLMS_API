using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Common.Email
{
    public class MailSettings
    {
        [JsonProperty(PropertyName = "bcc")]
        public BCCSettings BccSettings { get; set; }

        [JsonProperty(PropertyName = "bypass_list_management")]
        public BypassListManagement BypassListManagement { get; set; }

        [JsonProperty(PropertyName = "footer")]
        public FooterSettings FooterSettings { get; set; }

        [JsonProperty(PropertyName = "sandbox_mode")]
        public SandboxMode SandboxMode { get; set; }

        [JsonProperty(PropertyName = "spam_check")]
        public SpamCheck SpamCheck { get; set; }
    }
}