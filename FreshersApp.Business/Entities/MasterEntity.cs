using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Business.Entities
{
    public class MasterEntity
    { 
        public string Changes { get; set; }
        public string ModifiedBy { get; set; }
        public Int64 Monthly_Basic_Salary_Into_Five { get; set; }
        public Int64 Monthly_Share { get; set; }
        public Int64 Personal_Share { get; set; }
        public Int64 Employee_Share { get; set; }
        public bool BeforeTax { get; set; }
        public float Amount { get; set; }
        public bool Taxable { get; set; }
        public string MaxAccumulated { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string Remarks { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public Int64 ID { get; set; }
        public string TrainerName { get; set; }
        public string ProjectType { get; set; }
        public Int64? YearsOfExperience { get; set; }
        public string TrainerDescription { get; set; }
        public string BlogName { get; set; }
        public string Author { get; set; }
        public string Tags { get; set; }
        public string Description { get; set; }
        public string PhotoURL { get; set; }
        public string VideoURL { get; set; }
        public string BannerURL { get; set; }
        public string Status { get; set; }
        public Int64 CategoryID { get; set; }
        public string TrainerType { get; set; }
        public DateTime Date { get; set; }
        public Int64 ProjectID { get; set; }
        public Int64 ProjectTypeID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ClientName { get; set; }
        public string ClientLocation { get; set; }
        public string Highlights { get; set; }
        public string Desgination { get; set; }
        public string WorkPlace { get; set; }
        public string Testimonial { get; set; }
        public string Action { get; set; }

    }
}