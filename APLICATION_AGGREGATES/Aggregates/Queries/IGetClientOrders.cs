using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION_AGGREGATES.Aggregates.Queries
{
    /// <summary>
    /// Created By : Saul Cruz
    /// Date Created : 12\07\2022
    /// Contains the query operations implemented by Property
    /// </summary>
    public interface IGetClientOrdersServices : IDisposable
    {
        public IEnumerable<dynamic> GetClientOrders();

    }

}
