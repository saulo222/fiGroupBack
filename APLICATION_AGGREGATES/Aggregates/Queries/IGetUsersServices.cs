using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION_AGGREGATES.Aggregates.Queries
{
    /// <summary>
    /// Created By : Saul Cruz
    /// Date Created : 27/01/2022
    /// Contains the query operations implemented by Property
    /// </summary>
    public interface IGetUsersServices : IDisposable
    {
        public IEnumerable<dynamic> GetAllUsers();

    }

}
