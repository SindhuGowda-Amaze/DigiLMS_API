using Rudra.Data.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Rudra.Data.Repositories
{
    public class Rudra_AllLevelProductsRepository : Repository, IRudra_AllLevelProductsRepository, IDisposable
    {
        public IEnumerable<T> GetFirst_SecondAndThirdLevelProducts<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetFirst_SecondAndThirdLevelProducts", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetProductDetailsByproduct_id<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetProductDetailsByproduct_id", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetProductMakingOptions<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetProductMakingOptions", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public IEnumerable<T> GetProd_orderDetails<T>()
        //{
        //    try
        //    {
        //        MySqlConnection db = Repository.GetConnection();
        //        return db.Query<T>("GetProd_orderDetails",  commandType: CommandType.StoredProcedure);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public IEnumerable<T> GetProd_productsDetails<T>(object filter)
        //{
        //    try
        //    {
        //        MySqlConnection db = Repository.GetConnection();
        //        return db.Query<T>("GetProd_productsDetails", filter, commandType: CommandType.StoredProcedure);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}






        public void Dispose()
        {
           // throw new NotImplementedException();
        }
    }
}
