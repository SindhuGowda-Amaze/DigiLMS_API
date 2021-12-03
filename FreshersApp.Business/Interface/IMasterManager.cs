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
        IEnumerable<dynamic> GetProjectTypeMaster();
        IEnumerable<dynamic> GetEnquery();
        IEnumerable<dynamic> LoginPage();
        Int64 InsertFoodSenseProjects(MasterEntity entity);
        Int64 InsertEnquery(MasterEntity entity);
        Int64 UpdateFoodSenseProject(MasterEntity entity);
        Int64 UpdateEnquery(MasterEntity entity);
        Int64 DeleteFoodSenseProject(object filter);
        Int64 DeleteEnquery(object filter);
    }
    
}

