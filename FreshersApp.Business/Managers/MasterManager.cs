using FreshersApp.Business.Entities;
using FreshersApp.Business.Interface;
using FreshersApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Business.Managers
{
    public class MasterManager : IMasterManager

    {
        private IMasterRepository IMasterRepository;

        public MasterManager(IMasterRepository IMasterRepository)
        {
            this.IMasterRepository = IMasterRepository;
        }

        public long DeleteCompanyProfile(object filter)
        {
            try
            {
                return IMasterRepository.DeleteCompanyProfile(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteFoodSenseProject(object filter)
        {
            try
            {
                return IMasterRepository.DeleteFoodSenseProject(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetCompanyProfile()
        {

            try
            {
                return IMasterRepository.GetCompanyProfile<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetFoodSenseProjects()
        {
            try
            {
                return IMasterRepository.GetFoodSenseProjects<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCompany_Profile(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Company_logo = entity.Company_logo,
                    Company_Name = entity.Company_Name,
                    Nature_Of_Business = entity.Nature_Of_Business,
                    Address1 = entity.Address1,
                    Address2 = entity.Address2,
                    Zipcode = entity.Zipcode,
                    RDO = entity.RDO,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    Password = entity.Password,
                    Fax = entity.Fax,
                    Tin = entity.Tin,
                    SSN_No = entity.SSN_No,
                    PhilHealthNumber = entity.PhilHealthNumber,
                    HDMFNumber = entity.HDMFNumber,
                    Admin_AuthorisedPerson = entity.Admin_AuthorisedPerson,
                    Admin_PositionTitle = entity.Admin_PositionTitle,
                    HR_AuthorisedPerson = entity.HR_AuthorisedPerson,
                    HR_PositionTitle = entity.HR_PositionTitle,
                    Finance_AuthorisedPerson = entity.Finance_AuthorisedPerson,
                    Finance_PositionTitle = entity.Finance_PositionTitle,
                    E_Signatory = entity.E_Signatory,
                    Work_Days_Per_Year = entity.Work_Days_Per_Year,
                    Work_Days_Per_Day = entity.Work_Days_Per_Day,
                    Work_Months_Per_Year = entity.Work_Months_Per_Year,
                    Work_hour_Start = entity.Work_hour_Start,
                    Work_hour_End = entity.Work_hour_End,
                    Break_Hours = entity.Break_Hours,
                    Periods_Per_Month = entity.Periods_Per_Month,
                    Absent_Deduction = entity.Absent_Deduction,
                    Late_Deduction = entity.Late_Deduction,
                    OverTime_Comeptition_Optional = entity.OverTime_Comeptition_Optional,
                    OverTime_Comeptition_OTRates = entity.OverTime_Comeptition_OTRates,
                    RestDays = entity.RestDays,
                    thirteen_Month_Compuatation_Type = entity.thirteen_Month_Compuatation_Type,
                    thirteen_Month_Deduct_Absent = entity.thirteen_Month_Deduct_Absent,
                    thirteen_Month_Deduct_Late = entity.thirteen_Month_Deduct_Late,
                    thirteen_Month_Optional = entity.thirteen_Month_Optional,
                    FinalPay_Deduct_Absent = entity.FinalPay_Deduct_Absent,
                    FinalPay_Deduct_Late = entity.FinalPay_Deduct_Late,
                    Final_Pay_13th_Month = entity.Final_Pay_13th_Month,
                    NetPay_Threshold = entity.NetPay_Threshold,
                    SSS_Coverage = entity.SSS_Coverage,
                    SSS_Optional = entity.SSS_Optional,
                    PhilHealth_Coverage = entity.PhilHealth_Coverage,
                    PhilHealth_Optional = entity.PhilHealth_Optional,
                    HDMS = entity.HDMS,
                    HDMF_Employer_Contribution = entity.HDMF_Employer_Contribution,
                    PayRoll_Calender = entity.PayRoll_Calender,
                    Tax_Table = entity.Tax_Table,
                    Tax_Table_Starts_on = entity.Tax_Table_Starts_on,
                    Tax_Table_Including_13thmonth = entity.Tax_Table_Including_13thmonth,
                    Non_Tax_Essential_Sealing = entity.Non_Tax_Essential_Sealing,
                    Deminimis_Exemption = entity.Deminimis_Exemption
                };
                return IMasterRepository.InsertFoodSenseProjects(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertFoodSenseProjects(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ProjectTypeID = entity.@ProjectTypeID,
                    ProjectName = entity.ProjectName,
                    ProjectDescription = entity.ProjectDescription,
                    ClientName = entity.ClientName,
                    ClientLocation = entity.ClientLocation,
                    Highlights = entity.Highlights,
                    Photo = entity.PhotoURL
                };
                return IMasterRepository.InsertFoodSenseProjects(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateFoodSenseProject(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    ProjectTypeID = entity.ProjectTypeID,
                    ProjectName = entity.ProjectName,
                    ProjectDescription = entity.ProjectDescription,
                    ClientName = entity.ClientName,
                    ClientLocation = entity.ClientLocation,
                    Highlights = entity.Highlights,
                    Photo = entity.PhotoURL
                };
                return IMasterRepository.UpdateFoodSenseProject(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

