using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Common.Email
{
    public class SandboxMode
    {
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
    }
}