using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudra.Data.Interface
{
    public interface IRudra_MastersRepository
    {
        IEnumerable<T> GetCountryMaster<T>(object filter);
        IEnumerable<T> GetCurrencyMaster<T>(object filter);
        IEnumerable<T> GetWristSize<T>();
    }
}
