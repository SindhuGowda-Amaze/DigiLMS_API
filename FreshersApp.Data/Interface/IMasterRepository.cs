<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Data.Interface
{
    public interface IMasterRepository
    {
       
        IEnumerable<T>GetCostcenter<T>();
        Int64 InsertCostcenter(object filter);
        Int64 UpdateCostcenter(object filter);
        Int64 DeleteCostcenter(object filter);
        IEnumerable<T>GetDepartment<T>();
        Int64 InsertDepartment(object filter);
        Int64 UpdateDepartment(object filter);
        Int64 DeleteDepartment(object filter);

        IEnumerable<T> GetCompanyAdjustment<T>();
        Int64 InsertCompanyAdjustment(object filter);
        Int64 UpdateCompanyAdjustment(object filter);
        Int64 DeleteCompanyAdjustment(object filter);

        IEnumerable<T>GetPhilHealth<T>();
        Int64 InsertPhilHealth(object filter);
        Int64 UpdatePhilHealth(object filter);
        Int64 DeletePhilHealth(object filter);



        IEnumerable<T> GetFoodSenseProjects<T>();
        Int64 InsertFoodSenseProjects(object filter);

        Int64 DeleteFoodSenseProject(object filter);


        IEnumerable<T> GetCompanyProfile<T>();
        Int64 InsertCompany_Profile(object filter);
        Int64 DeleteCompanyProfile(object filter);

        IEnumerable<T> GetOTRates<T>();
        Int64 InsertOTRates(object filter); 
         Int64 UpdateOTRates(object filter);
        Int64 DeleteOTRates(object filter);

        IEnumerable<T> GetBanks<T>();
        Int64 InsertBanks(object filter);
        Int64 UpdateBanks(object filter);
        Int64 DeleteBanks(object filter);


        IEnumerable<T> GetPayGroup<T>();
        Int64 InsertPayGroup(object filter);
        Int64 UpdatePayGroup(object filter);
        Int64 DeletePayGroup(object filter);


        IEnumerable<T> GetSSS<T>();
        Int64 InsertSSS(object filter);
        Int64 UpdateSSS(object filter);
        Int64 DeleteSSS(object filter);


    }

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Data.Interface
{
    public interface IMasterRepository
    {

        IEnumerable<T> GetCostcenter<T>();
        IEnumerable<T>GetTaxtable<T>();
        Int64 InsertCostcenter(object filter);
        Int64 UpdateCostcenter(object filter);
        Int64 DeleteCostcenter(object filter);
        
        IEnumerable<T>GetDepartment<T>();
        Int64 InsertDepartment(object filter);
        Int64 UpdateDepartment(object filter);
        Int64 DeleteDepartment(object filter);

        IEnumerable<T> GetCompanyAdjustment<T>();
        Int64 InsertCompanyAdjustment(object filter);
        Int64 UpdateCompanyAdjustment(object filter);
        Int64 DeleteCompanyAdjustment(object filter);

        IEnumerable<T>GetPhilHealth<T>();
        Int64 InsertPhilHealth(object filter);
        Int64 UpdatePhilHealth(object filter);
        Int64 DeletePhilHealth(object filter);



        IEnumerable<T> GetFoodSenseProjects<T>();
        Int64 InsertFoodSenseProjects(object filter);

        Int64 DeleteFoodSenseProject(object filter);


        IEnumerable<T> GetCompanyProfile<T>();
        Int64 InsertCompany_Profile(object filter);
        Int64 DeleteCompanyProfile(object filter);

        IEnumerable<T> GetOTRates<T>();
        Int64 InsertOTRates(object filter); 
         Int64 UpdateOTRates(object filter);
        Int64 DeleteOTRates(object filter);

        IEnumerable<T> GetBanks<T>();
        Int64 InsertBanks(object filter);
        Int64 UpdateBanks(object filter);
        Int64 DeleteBanks(object filter);


        IEnumerable<T> GetPayGroup<T>();
        Int64 InsertPayGroup(object filter);
        Int64 UpdatePayGroup(object filter);
        Int64 DeletePayGroup(object filter);


        IEnumerable<T> GetSSS<T>();
        Int64 InsertSSS(object filter);
        Int64 UpdateSSS(object filter);
        Int64 DeleteSSS(object filter);

        IEnumerable<T> GetEmployeeInformation<T>();
        Int64 InsertEmployeeInformation(object filter);
        Int64 UpdateEmployeeInformation(object filter);
        Int64 DeleteEmployeeInformation(object filter);


        IEnumerable<T> GetGovernmentRecords<T>();
        Int64 InsertGovernmentRecords(object filter);
        Int64 UpdateGovernmentRecords(object filter);
        Int64 DeleteGovernmentRecords(object filter);


    }

>>>>>>> 6385576fc3a09aff9c616c33dbe947bdea3ce92e
}