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


		public string Company_logo { get; set; }
		public string Company_Name { get; set; }
		public string Nature_Of_Business { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Zipcode { get; set; }
		public Int64 RDO { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Password { get; set; }
		public string Fax { get; set; }
		public string Tin { get; set; }
		public string SSN_No { get; set; }
		public string PhilHealthNumber { get; set; }
		public string HDMFNumber { get; set; }
		public string Admin_AuthorisedPerson { get; set; }
		public string Admin_PositionTitle { get; set; }
		public string HR_AuthorisedPerson { get; set; }
		public string HR_PositionTitle { get; set; }
		public string Finance_AuthorisedPerson { get; set; }
		public string Finance_PositionTitle { get; set; }
		public string E_Signatory { get; set; }
		public Int64 Work_Days_Per_Year { get; set; }
		public Int64 Work_Days_Per_Day { get; set; }
		public Int64 Work_Months_Per_Year { get; set; }
		public DateTime Work_hour_Start { get; set; }
		public DateTime Work_hour_End { get; set; }
		public DateTime Break_Hours { get; set; }
		public string Periods_Per_Month { get; set; }
		public string Absent_Deduction { get; set; }
		public string Late_Deduction { get; set; }
		public string OverTime_Comeptition_Optional { get; set; }
		public string OverTime_Comeptition_OTRates { get; set; }
		public string RestDays { get; set; }
		public string thirteen_Month_Compuatation_Type { get; set; }
		public bool thirteen_Month_Deduct_Absent { get; set; }
		public bool thirteen_Month_Deduct_Late { get; set; }
		public string thirteen_Month_Optional { get; set; }
		public bool FinalPay_Deduct_Absent { get; set; }
		public bool FinalPay_Deduct_Late { get; set; }
		public bool Final_Pay_13th_Month { get; set; }
		public bool NetPay_Threshold { get; set; }
		public string SSS_Coverage { get; set; }
		public string SSS_Optional { get; set; }
		public string PhilHealth_Coverage { get; set; }
		public string PhilHealth_Optional { get; set; }
		public string HDMS { get; set; }
		public string HDMF_Employer_Contribution { get; set; }
		public bool PayRoll_Calender { get; set; }
		public string Tax_Table { get; set; }
		public string Tax_Table_Starts_on { get; set; }
		public bool Tax_Table_Including_13thmonth { get; set; }
		public string Non_Tax_Essential_Sealing { get; set; }
		public string Deminimis_Exemption { get; set; }
		public string Day { get; set; }
		public string Normal { get; set; }
		public string OT { get; set; }
		public string ND { get; set; }
		public string NDOT { get; set; }
		


		public Int64 Min_Range { get; set; }
		public Int64 Max_Range { get; set; }
		public Int64 Monthly_Salary_Creadited { get; set; }
		public Int64 SS_ER { get; set; }
		public Int64 SS_EE { get; set; }
		public Int64 SS_Total { get; set; }
		public Int64 MPF_ER { get; set; }
		public Int64 MPF_EE { get; set; }
		public Int64 EC_ER { get; set; }
		public Int64 Total_Contribution { get; set; }
	




	}
}