using FreshersApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Business.Interface
{
    public interface IMasterManager
    {

        //GetCostCenter
        IEnumerable<dynamic>GetCostcenter();

        Int64 InsertCostcenter(MasterEntity entity);

        Int64 UpdateCostcenter(MasterEntity entity);
        Int64 DeleteCostcenter(object filter);

        IEnumerable<dynamic>GetDepartment();
        Int64 InsertDepartment(MasterEntity entity);
        Int64 UpdateDepartment(MasterEntity entity);
        Int64 DeleteDepartment(object filter);


        IEnumerable<dynamic> GetFoodSenseProjects();
      
        Int64 InsertFoodSenseProjects(MasterEntity entity);
        

       
        Int64 DeleteFoodSenseProject(object filter);

        IEnumerable<dynamic> GetOTRates();

        Int64 InsertOTRates(MasterEntity entity);

        Int64 UpdateOTRates(MasterEntity entity);

        Int64 DeleteOTRates(object filter);




        IEnumerable<dynamic> GetCompanyProfile();

        Int64 InsertCompany_Profile(MasterEntity entity);

        Int64 DeleteCompanyProfile(object filter);


        IEnumerable<dynamic> GetSSS();

        Int64 InsertSSS(MasterEntity entity);

        Int64 UpdateSSS(MasterEntity entity);

        Int64 DeleteSSS(object filter);


        IEnumerable<dynamic> GetGovernmentRecords();

        Int64 InsertGovernmentRecords(MasterEntity entity);

        Int64 UpdateGovernmentRecords(MasterEntity entity);

        Int64 DeleteGovernmentRecords(object filter);



        IEnumerable<dynamic> GetBanks();

        Int64 InsertBanks(MasterEntity entity);

        Int64 UpdateBanks(MasterEntity entity);

        Int64 DeleteBanks(object filter);


        IEnumerable<dynamic> GetPayGroup();

        Int64 InsertPayGroup(MasterEntity entity);

        Int64 UpdatePayGroup(MasterEntity entity);

        Int64 DeletePayGroup(object filter);

    }

}

