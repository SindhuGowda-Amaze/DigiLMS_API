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
        IEnumerable<dynamic> GetFoodSenseProjects();
      
        Int64 InsertFoodSenseProjects(MasterEntity entity);
        
        Int64 UpdateFoodSenseProject(MasterEntity entity);
       
        Int64 DeleteFoodSenseProject(object filter);



        IEnumerable<dynamic> GetCompanyProfile();

        Int64 InsertCompany_Profile(MasterEntity entity);

        Int64 DeleteCompanyProfile(object filter);

    }
    
}

