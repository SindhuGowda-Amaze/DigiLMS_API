using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudra.Data.Interface
{
    public interface IRudra_HomeDetailsRepository
    {
        IEnumerable<T> GetTestimonials<T>();
        IEnumerable<T> GetVideoleftside<T>(object filter);
        Int64 InsertCustomerProduct_Reviews(object filter);
        Int64 InsertNewsletterintoCrm_contacts(object filter);
        T GetAboutUsMbl<T>();
        

        T GetContactUsMbl<T>();
        T GetMissionsMbl<T>();
        T GetSecurePaymentsMbl<T>();
        IEnumerable<T> GetNeethaAwardsMbl<T>();
        IEnumerable<T> GetNeethaVideosMbl<T>();
        IEnumerable<T> GetCourierChargesMbl<T>();
        IEnumerable<T> GetHolisticNetworkMbl<T>();
        IEnumerable<T> GetHolisticNetworkDetailsByCountryID<T>(object filter);
        IEnumerable<T> GetPoojaServicesMbl<T>();
        IEnumerable<T> GetRRSTMbl<T>();
    }
}
