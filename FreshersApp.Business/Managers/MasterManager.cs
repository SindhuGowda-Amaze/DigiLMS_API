﻿using FreshersApp.Business.Entities;
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

        //getCostcenter and department



        public IEnumerable<dynamic> GetCostcenter()
        {
            try
            {
                return IMasterRepository.GetCostcenter<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetDepartment()
        {
            try
            {
                return IMasterRepository.GetDepartment<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertDepartment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                };
                return IMasterRepository.InsertDepartment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateDepartment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                };
                return IMasterRepository.UpdateDepartment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeleteDepartment(object filter)
        {
            try
            {
                return IMasterRepository.DeleteDepartment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public long InsertCostcenter(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                };
                return IMasterRepository.InsertCostcenter(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCostcenter(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                };
                return IMasterRepository.UpdateCostcenter(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCostcenter(object filter)
        {
            try
            {
                return IMasterRepository.DeleteCostcenter(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        //public long InsertCompany_Profile(MasterEntity entity)
        //{
        //    try
        //    {
        //        var filter = new
        //        {
        //            Company_logo = entity.Company_logo,
        //            Company_Name = entity.Company_Name,
        //            Nature_Of_Business = entity.Nature_Of_Business,
        //            Address1 = entity.Address1,
        //            Address2 = entity.Address2,
        //            Zipcode = entity.Zipcode,
        //            RDO = entity.RDO,
        //            Email = entity.Email,
        //            Phone = entity.Phone,
        //            Password = entity.Password,
        //            Fax = entity.Fax,
        //            Tin = entity.Tin,
        //            SSN_No = entity.SSN_No,
        //            PhilHealthNumber = entity.PhilHealthNumber,
        //            HDMFNumber = entity.HDMFNumber,
        //            Admin_AuthorisedPerson = entity.Admin_AuthorisedPerson,
        //            Admin_PositionTitle = entity.Admin_PositionTitle,
        //            HR_AuthorisedPerson = entity.HR_AuthorisedPerson,
        //            HR_PositionTitle = entity.HR_PositionTitle,
        //            Finance_AuthorisedPerson = entity.Finance_AuthorisedPerson,
        //            Finance_PositionTitle = entity.Finance_PositionTitle,
        //            E_Signatory = entity.E_Signatory,
        //            Work_Days_Per_Year = entity.Work_Days_Per_Year,
        //            Work_Days_Per_Day = entity.Work_Days_Per_Day,
        //            Work_Months_Per_Year = entity.Work_Months_Per_Year,
        //            Work_hour_Start = entity.Work_hour_Start,
        //            Work_hour_End = entity.Work_hour_End,
        //            Break_Hours = entity.Break_Hours,
        //            Periods_Per_Month = entity.Periods_Per_Month,
        //            Absent_Deduction = entity.Absent_Deduction,
        //            Late_Deduction = entity.Late_Deduction,
        //            OverTime_Comeptition_Optional = entity.OverTime_Comeptition_Optional,
        //            OverTime_Comeptition_OTRates = entity.OverTime_Comeptition_OTRates,
        //            RestDays = entity.RestDays,
        //            thirteen_Month_Compuatation_Type = entity.thirteen_Month_Compuatation_Type,
        //            thirteen_Month_Deduct_Absent = entity.thirteen_Month_Deduct_Absent,
        //            thirteen_Month_Deduct_Late = entity.thirteen_Month_Deduct_Late,
        //            thirteen_Month_Optional = entity.thirteen_Month_Optional,
        //            FinalPay_Deduct_Absent = entity.FinalPay_Deduct_Absent,
        //            FinalPay_Deduct_Late = entity.FinalPay_Deduct_Late,
        //            Final_Pay_13th_Month = entity.Final_Pay_13th_Month,
        //            NetPay_Threshold = entity.NetPay_Threshold,
        //            SSS_Coverage = entity.SSS_Coverage,
        //            SSS_Optional = entity.SSS_Optional,
        //            PhilHealth_Coverage = entity.PhilHealth_Coverage,
        //            PhilHealth_Optional = entity.PhilHealth_Optional,
        //            HDMS = entity.HDMS,
        //            HDMF_Employer_Contribution = entity.HDMF_Employer_Contribution,
        //            PayRoll_Calender = entity.PayRoll_Calender,
        //            Tax_Table = entity.Tax_Table,
        //            Tax_Table_Starts_on = entity.Tax_Table_Starts_on,
        //            Tax_Table_Including_13thmonth = entity.Tax_Table_Including_13thmonth,
        //            Non_Tax_Essential_Sealing = entity.Non_Tax_Essential_Sealing,
        //            Deminimis_Exemption = entity.Deminimis_Exemption
        //        };
        //        return IMasterRepository.InsertFoodSenseProjects(filter);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

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
                return IMasterRepository.InsertCompany_Profile(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetOTRates()
        {
            try
            {
                return IMasterRepository.GetOTRates<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public long InsertOTRates(MasterEntity entity)
        //{
        //    try
        //    {
        //        var filter = new
        //        {
        //            Day = entity.Day,
        //            Normal = entity.Normal,
        //            OT = entity.OT,
        //            ND = entity.ND,
        //            NDOT = entity.NDOT,
        //            ModifiedBy = entity.ModifiedBy,
                
        //        };
        //        return IMasterRepository.InsertOTRates(filter);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public long UpdateOTRates(MasterEntity entity)
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
                return IMasterRepository.UpdateOTRates(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteOTRates(object filter)
        {
            try
            {
                return IMasterRepository.DeleteOTRates(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetBanks()
        {
            try
            {
                return IMasterRepository.GetBanks<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertBanks(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks
                };
                return IMasterRepository.InsertBanks(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateBanks(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks

                };
                return IMasterRepository.UpdateBanks(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteBanks(object filter)
        {
            try
            {
                return IMasterRepository.DeleteBanks(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetPayGroup()
        {
            try
            {
                return IMasterRepository.GetPayGroup<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertPayGroup(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    
                    Description = entity.Description
                };
                return IMasterRepository.InsertPayGroup(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdatePayGroup(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Description = entity.Description

                };
                return IMasterRepository.UpdatePayGroup(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeletePayGroup(object filter)
        {
            try
            {
                return IMasterRepository.DeletePayGroup(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetSSS()
        {
            try
            {
                return IMasterRepository.GetSSS<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertSSS(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Min_Range=entity.Min_Range,
                    Max_Range = entity.Max_Range,
                    Monthly_Salary_Creadited = entity.Monthly_Salary_Creadited,
                    SS_ER = entity.SS_ER,
                    SS_EE = entity.SS_EE,
                    SS_Total = entity.SS_Total,
                    MPF_ER = entity.MPF_ER,
                    MPF_EE = entity.MPF_EE,
                    EC_ER = entity.EC_ER,
                    Total_Contribution = entity.Total_Contribution

                };
                return IMasterRepository.InsertSSS(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertOTRates(MasterEntity entity)
        {
            throw new NotImplementedException();
        }

        public long UpdateSSS(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    Min_Range = entity.Min_Range,
                    Max_Range = entity.Max_Range,
                    Monthly_Salary_Creadited = entity.Monthly_Salary_Creadited,
                    SS_ER = entity.SS_ER,
                    SS_EE = entity.SS_EE,
                    SS_Total = entity.SS_Total,
                    MPF_ER = entity.MPF_ER,
                    MPF_EE = entity.MPF_EE,
                    EC_ER = entity.EC_ER,
                    Total_Contribution = entity.Total_Contribution
                };
                return IMasterRepository.UpdateSSS(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteSSS(object filter)
        {
            try
            {
                return IMasterRepository.DeleteSSS(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertCompany_Profile(MasterEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<dynamic> GetGovernmentRecords()
        {
            try
            {
                return IMasterRepository.GetGovernmentRecords<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertGovernmentRecords(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    
                    SSS_Number = entity.SSS_Number,
                    SSS_DatePaid = entity.SSS_DatePaid,
                    SSSLoan_Number = entity.SSSLoan_Number,
                    SSSLoan_DatePaid = entity.SSSLoan_DatePaid,
                    SSSCalamityLoan_Number = entity.SSSCalamityLoan_Number,
                    SSSCalamityLoan_DatePaid = entity.SSSCalamityLoan_DatePaid,
                    PhilHealth_Number = entity.PhilHealth_Number,
                    PhilHealth_DatePaid = entity.PhilHealth_DatePaid,
                    HDMF_Number = entity.HDMF_Number,
                    HDMF_DatePaid = entity.HDMF_DatePaid,
                    HDMFLoan_Number = entity.HDMFLoan_Number,
                    HDMFLoan_DatePaid = entity.HDMFLoan_DatePaid,
                    HDMPCalamityLoan_Number = entity.HDMPCalamityLoan_Number,
                    HDMPCalamityLoan_DatePaid = entity.HDMPCalamityLoan_DatePaid

                };
                return IMasterRepository.InsertGovernmentRecords(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       

        public long UpdateGovernmentRecords(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    SSS_Number = entity.SSS_Number,
                    SSS_DatePaid = entity.SSS_DatePaid,
                    SSSLoan_Number = entity.SSSLoan_Number,
                    SSSLoan_DatePaid = entity.SSSLoan_DatePaid,
                    SSSCalamityLoan_Number = entity.SSSCalamityLoan_Number,
                    SSSCalamityLoan_DatePaid = entity.SSSCalamityLoan_DatePaid,
                    PhilHealth_Number = entity.PhilHealth_Number,
                    PhilHealth_DatePaid = entity.PhilHealth_DatePaid,
                    HDMF_Number = entity.HDMF_Number,
                    HDMF_DatePaid = entity.HDMF_DatePaid,
                    HDMFLoan_Number = entity.HDMFLoan_Number,
                    HDMFLoan_DatePaid = entity.HDMFLoan_DatePaid,
                    HDMPCalamityLoan_Number = entity.HDMPCalamityLoan_Number,
                    HDMPCalamityLoan_DatePaid = entity.HDMPCalamityLoan_DatePaid

                };
                return IMasterRepository.UpdateGovernmentRecords(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteGovernmentRecords(object filter)
        {
            try
            {
                return IMasterRepository.DeleteGovernmentRecords(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

