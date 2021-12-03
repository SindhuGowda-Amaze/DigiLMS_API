using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudra.Data.Interface
{
    public interface IRudra_AllLevelProductsRepository
    {
        IEnumerable<T> GetFirst_SecondAndThirdLevelProducts<T>(object filter);
        IEnumerable<T> GetProductDetailsByproduct_id<T>(object filter);
        IEnumerable<T> GetProductMakingOptions<T>(object filter);
        //IEnumerable<T> GetProd_orderDetails<T>();
        //IEnumerable<T> GetProd_productsDetails<T>(object filter);
    }
}
