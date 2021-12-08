using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudra.Data.Interface
{
    public interface IRudra_CustomerDetailsRepository
    {

        /// <summary>
        /// method to Insert Chakra Customer Details
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <returns></returns>
        T GetRudra_Authentication<T>(object filter);
        Int64 InsertChakraRudraCustomerDetails(object filter);
        Int64 ChangePassword(object filter);
        T GetCustomerLoginDetails<T>(object filter);
        Int64 UpdateRudraCustomerDetails(object filter);
        T GetCustomerDetailsByCustID<T>(object filter);
        Int64 ChakraInsertNewsLetter(object filter);
        Int64 GetvalidateCustomerDetails<T>(object filter);
        Int64 GetvalidateCustomerloginDetails<T>(object filter);
        Int64 GetAndroidVersion<T>();
        string Getpassword<T>(object filter);
        Int64 UpdateIsPaidBitAgainstPaymentDone(object filter);
        IEnumerable<T> GetCartID<T>(object filter);
        Int64 UpdateOrderedBitForCart(object filter);





        //------------------------------Rudra------------------------------------
        Int64 InsertRud_CustomerMbl(object filter);
        IEnumerable<T> GetCustomerProductReviews<T>(object filter);
    }
}
