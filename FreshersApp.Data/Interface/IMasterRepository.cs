using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Data.Interface
{
    public interface IMasterRepository
    {
        IEnumerable<T> GetFoodSenseProjects<T>();
        IEnumerable<T> GetProjectTypeMaster<T>();
        IEnumerable<T> GetEnquery<T>();
        IEnumerable<T> LoginPage<T>();

        Int64 InsertFoodSenseProjects(object filter);
        Int64 InsertEnquery(object filter);
        Int64 UpdateFoodSenseProject(object filter);
        Int64 UpdateEnquery(object filter);
        Int64 DeleteFoodSenseProject(object filter);
        Int64 DeleteEnquery(object filter);

    }

}