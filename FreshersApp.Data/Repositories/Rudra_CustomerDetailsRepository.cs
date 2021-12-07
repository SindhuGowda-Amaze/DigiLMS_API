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
    public class Rudra_CustomerDetailsRepository : Repository, IRudra_CustomerDetailsRepository, IDisposable
    {


        /// <summary>
        /// method to Insert Chakra Customer Details
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// 
        public Int64 InsertChakraRudraCustomerDetails(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<Int64>("SProc_InsertChakra_Rudra_CustomerDetails", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// method to Get ChakraRudra CustomerDetails]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param> 
        /// <returns></returns>
        /// 



        public Int64 UpdateRudraCustomerDetails(object filter)
        {
            try
            {
                return db.Execute("SProc_UpdateCustomerDetails", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public T GetCustomerDetailsByCustID<T>(object filter)
        {
            try
            {
                return db.Query<T>("SProc_GetCustomerDetails", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 ChakraInsertNewsLetter(object filter)
        {
            try
            {
                return db.Query<Int64>("SProc_ChakraInsertNewsLetter", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// method to Get valid CustomerDetails]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param> 
        /// <returns></returns>
        /// 

        public Int64 GetvalidateCustomerDetails<T>(object filter)
        {
            try
            {
                return db.Query<Int64>("GetvalidateCustomerDetails", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        /// <summary>
        /// method to Get valid CustomerDetails]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param> 
        /// <returns></returns>
        /// 

        public Int64 GetvalidateCustomerloginDetails<T>(object filter)
        {
            try
            {
                return db.Query<Int64>("GetvalidateCustomerloginDetails", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 GetAndroidVersion<T>()
        {
            return db.Query<Int64>("[dbo].[Sproc_GetAndroidVersion]", commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        /// <summary>
        /// method to ChangePassword
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <returns></returns>

        public Int64 ChangePassword(object filter)
        {
            try
            {
                return db.Query<Int64>("SProc_Changepassword", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// method to ChangePassword
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <returns></returns>
        public string Getpassword<T>(object filter)
        {
            try
            {
                return db.Query<string>("[SprocGetpassword_CustomerDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 UpdateIsPaidBitAgainstPaymentDone(object filter)
        {
            try
            {
                return db.Execute("Sproc_UpdateIsPaidBitAgainstPaymentDone", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetCartID<T>(object filter)
        {
            try
            {
                return db.Query<T>("Sproc_GetCartID", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateOrderedBitForCart(object filter)
        {
            try
            {
                return db.Execute("proc_UpdateOrderedBitForCart", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //-----------------------------RUDRA----------------------------------------------------
        public T GetRudra_Authentication<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetRudra_Authentication", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetCustomerLoginDetails<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetCustomerLoginDetails", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetCustomerProductReviews<T>(object filter)
        {
            try
            {
                MySqlConnection db = Repository.GetConnection();
                return db.Query<T>("GetCustomerProductReviews", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Int64 InsertRud_CustomerMbl(object filter)
        {
            try
            {
                return db.Query("InsertRud_CustomerMbl", filter, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
