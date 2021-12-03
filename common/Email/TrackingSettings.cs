using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Common.Email
{
    public class TrackingSettings
    {
        [JsonProperty(PropertyName = "click_tracking")]
        public ClickTracking ClickTracking { get; set; }

        [JsonProperty(PropertyName = "open_tracking")]
        public OpenTracking OpenTracking { get; set; }

        [JsonProperty(PropertyName = "subscription_tracking")]
        public SubscriptionTracking SubscriptionTracking { get; set; }

        [JsonProperty(PropertyName = "ganalytics")]
        public Ganalytics Ganalytics { get; set; }
    }
}