using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Common.Email
{
    public class FooterSettings
    {
        [JsonProperty(PropertyName = "enable")]
        public bool Enable { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "html")]
        public string Html { get; set; }
    }
}