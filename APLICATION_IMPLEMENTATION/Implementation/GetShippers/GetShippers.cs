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
    public class GetShippersService : IGetShippersServices
    {
        private IGetShippers _shippers;

        public GetShippersService(IGetShippers shippers) => _shippers = shippers;


        public IEnumerable<dynamic> GetShippers()
        {
            IEnumerable<dynamic> users = _shippers.GetShippers();
                                                                            
            return users;
        }

        

        public void Dispose()
        {
            _shippers.Dispose();
        }
    }
}
