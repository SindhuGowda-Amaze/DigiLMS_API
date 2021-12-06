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

        public IEnumerable<T>GetPhilHealth<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetPhilHealth]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertPhilHealth(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertPhilHealth]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdatePhilHealth(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdatePhilHealth]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeletePhilHealth(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeletePhilHealth]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public IEnumerable<T> GetDepartment<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetDepartment]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertDepartment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertDepartment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateDepartment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateDepartment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
                return db.Query<Int64>("[dbo].[SProc_DeleteDepartment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public IEnumerable<T>GetCostcenter<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetCostcenter]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCostcenter(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCostcenter]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCostcenter(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateCostcenter]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
                return db.Query<Int64>("[dbo].[SProc_DeleteCostcenter]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetCompanyAdjustment<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetCompanyAdjustment]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCompanyAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCompanyAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCompanyAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateCompanyAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCompanyAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteCompanyAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

    }
}