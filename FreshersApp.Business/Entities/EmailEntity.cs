using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Business.Entities
{
    public class EmailEntity
    {
        public string emailto { get; set; }
        public string emailsubject { get; set; }
        public string emailbody { get; set; }
        // public string attachmenturl { get; set; }
        public List<string> attachmenturl { get; set; }
    }
}
