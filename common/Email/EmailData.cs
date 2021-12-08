using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Common.Email
{
    public class EmailData
    {
        public EmailData()
        {
        }

        public EmailData(string email, string name = null)
        {
            this.Address = email;
            this.Name = name;
        }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Address { get; set; }
    }
}