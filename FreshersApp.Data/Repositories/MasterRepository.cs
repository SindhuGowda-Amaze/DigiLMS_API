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


        public IEnumerable<T> GetOTRates<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetOTRates]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertOTRates(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertOTRates]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateOTRates(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateOTRates]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
                return db.Query<Int64>("[dbo].[SProc_DeleteOTRates]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetCompanyProfile<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetCompanyProfile]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCompany_Profile(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCompany_Profile]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
                return db.Query<Int64>("[dbo].[SProc_DeleteCompanyProfile]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetBanks<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[Spro_GetBanks]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertBanks(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[Sproc_InsertBanks]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateBanks(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[Sproc_UpdateBanks]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
                return db.Query<Int64>("[dbo].[Sproc_DeleteBanks]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetPayGroup<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[Spro_GetPayGroup]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertPayGroup(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[Sproc_InsertPayGroup]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdatePayGroup(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[Sproc_UpdatePayGroup]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
                return db.Query<Int64>("[dbo].[Sproc_DeletePayGroup]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetSSS<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetSSS]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertSSS(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertSSS]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateSSS(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateSSS]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
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
                return db.Query<Int64>("[dbo].[SProc_DeleteSSS]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}