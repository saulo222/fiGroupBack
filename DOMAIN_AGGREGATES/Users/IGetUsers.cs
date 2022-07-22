using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN_AGGREGATES.Users
{
    /// <summary>
    /// Created By : Saul Cruz
    /// Date Created : 30\06\2022
    /// Contains the query operations implemented by Users
    /// </summary>
    public interface IGetUsers : IDisposable
    {
        public IEnumerable<dynamic> GetAllUsers();
       
    }
}
