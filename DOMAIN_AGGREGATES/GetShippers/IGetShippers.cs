using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN_AGGREGATES.Users
{
    /// <summary>
    /// Created By : Saul Cruz
    /// Date Created : 12\07\2022
    /// Contains the query operations implemented by Shippers
    /// </summary>
    public interface IGetShippers : IDisposable
    {
        public IEnumerable<dynamic> GetShippers();
       
    }
}
