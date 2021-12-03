using Dapper;
using FreshersApp.Data;
using FreshersApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Data.Repositories
{
    public class MasterRepository : Repository, IMasterRepository, IDisposable
    {

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetFoodSenseProjects<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetFoodSenseProjects]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertFoodSenseProjects(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertFoodSenseProjects]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateFoodSenseProject(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateFoodSenseProject]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
                return db.Query<Int64>("[dbo].[SProc_DeleteFoodSenseProject]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetProjectTypeMaster<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetProjectTypeMaster]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> LoginPage<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[GetLoginPage]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetEnquery<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetEnquery]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEnquery(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertEnquery]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateEnquery(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateEnquery]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteEnquery(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteEnquery]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}