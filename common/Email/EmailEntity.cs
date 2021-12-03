using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  FreshersApp.Promoter.Api.Controllers.Email
{
    public class EmailEntity
    {
        public string ToEmail { get; set; }
        public string FromEmail { get; set; }
        public string ContentType { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }
        public string Filename { get; set; }
    }
}