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
    public class GetemployeesService : IGetemployeesServices
    {
        private IGetemployees _etemployees;

        public GetemployeesService(IGetemployees etemployees) => _etemployees = etemployees;


        public IEnumerable<dynamic> Getemployees()
        {
            IEnumerable<dynamic> users = _etemployees.Getemployees();
                                                                            
            return users;
        }

        

        public void Dispose()
        {
            _etemployees.Dispose();
        }
    }
}
