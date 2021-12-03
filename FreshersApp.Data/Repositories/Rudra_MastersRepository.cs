using Dapper;
using MySql.Data.MySqlClient;
using Rudra.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudra.Data.Repositories
{
    public class Rudra_MastersRepository : Repository, IRudra_MastersRepository, IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        
        public IEnumerable<T> GetCountryMaster<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetCountryMaster", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetCurrencyMaster<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetCurrencyMaster", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetWristSize<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetWristSize", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        


    }
}
