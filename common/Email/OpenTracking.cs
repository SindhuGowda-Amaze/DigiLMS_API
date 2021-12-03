using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Common.Email
{
    public class OpenTracking
    {
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }

        [JsonProperty(PropertyName = "substitution_tag")]
        public string SubstitutionTag { get; set; }
    }
}