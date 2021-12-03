using System;
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

        IEnumerable<T> GetFoodSenseProjects<T>();
        Int64 InsertFoodSenseProjects(object filter);
        Int64 UpdateFoodSenseProject(object filter);
        Int64 DeleteFoodSenseProject(object filter);
    }

}