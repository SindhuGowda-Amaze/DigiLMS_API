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






    }

}

