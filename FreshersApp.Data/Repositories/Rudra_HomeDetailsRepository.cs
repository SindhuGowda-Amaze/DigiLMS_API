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
    public class Rudra_HomeDetailsRepository : Repository, IRudra_HomeDetailsRepository, IDisposable
    {

        public IEnumerable<T> GetTestimonials<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetTestimonials", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetVideoleftside<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetVideoleftside", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 InsertCustomerProduct_Reviews(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<Int64>("InsertCustomerProduct_Reviews", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 InsertNewsletterintoCrm_contacts(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<Int64>("InsertNewsletterintoCrm_contacts", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public T GetAboutUsMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetAboutUsMbl", commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       

        public T GetContactUsMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetContactUsMbl", commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetMissionsMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetMissionsMbl", commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public T GetSecurePaymentsMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetSecurePaymentsMbl", commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetNeethaAwardsMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetNeethaAwardsMbl", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetNeethaVideosMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetNeethaVideosMbl", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetCourierChargesMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetCourierChargesMbl", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetHolisticNetworkMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetHolisticNetworkMbl", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetHolisticNetworkDetailsByCountryID<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetHolisticNetworkDetailsByCountryID", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetPoojaServicesMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetPoojaServicesMbl", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetRRSTMbl<T>()
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetRRSTMbl", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
