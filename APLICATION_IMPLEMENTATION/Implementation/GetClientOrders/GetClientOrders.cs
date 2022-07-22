using APLICATION_AGGREGATES.Aggregates.Queries;
using DOMAIN_AGGREGATES.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION_IMPLEMENTATION.Implementation.Users.Queries
{
    /// <summary>
    /// Created By : Saul Cruz
    /// Date Created : 12\07\2022
    /// Service that contains the query operations that a property implements.
    /// </summary>
    public class GetClientOrdersService : IGetClientOrdersServices
    {
        private IGetClientOrders _clientOrders;

        public GetClientOrdersService(IGetClientOrders clientOrders) => _clientOrders = clientOrders;


        public IEnumerable<dynamic> GetClientOrders()
        {
            IEnumerable<dynamic> users = _clientOrders.GetClientOrders();
                                                                            
            return users;
        }

        

        public void Dispose()
        {
            _clientOrders.Dispose();
        }
    }
}
