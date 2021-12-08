using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Common.Email
{
    public class Personalization
    {
        [JsonProperty(PropertyName = "to")]
        public List<EmailData> Tos { get; set; }

        [JsonProperty(PropertyName = "cc")]
        public List<EmailData> Ccs { get; set; }

        [JsonProperty(PropertyName = "bcc")]
        public List<EmailData> Bccs { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "headers")]
        public Dictionary<string, string> Headers { get; set; }

        [JsonProperty(PropertyName = "substitutions")]
        public Dictionary<string, string> Substitutions { get; set; }

        [JsonProperty(PropertyName = "custom_args")]
        public Dictionary<string, string> CustomArgs { get; set; }

        [JsonProperty(PropertyName = "send_at")]
        public long? SendAt { get; set; }

        public void AddTo(EmailData email)
        {
            if (Tos == null)
                Tos = new List<EmailData>();

            Tos.Add(email);
        }

        public void AddCc(EmailData email)
        {
            if (Ccs == null)
                Ccs = new List<EmailData>();

            Ccs.Add(email);
        }

        public void AddBcc(EmailData email)
        {
            if (Bccs == null)
                Bccs = new List<EmailData>();

            Bccs.Add(email);
        }

        public void AddHeader(string key, string value)
        {
            if (Headers == null)
                Headers = new Dictionary<string, string>();

            Headers.Add(key, value);
        }

        public void AddSubstitution(string key, string value)
        {
            if (Substitutions == null)
                Substitutions = new Dictionary<string, string>();

            Substitutions.Add(key, value);
        }

        public void AddCustomArgs(string key, string value)
        {
            if (CustomArgs == null)
                CustomArgs = new Dictionary<string, string>();

            CustomArgs.Add(key, value);
        }
    }
}