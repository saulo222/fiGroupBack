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
    /// Date Created : 18/07/2022
    /// Service that contains the query operations that a property implements.
    /// </summary>
    public class GetTaskService : IGetTaskServices
    {
        private IGetTask _task;

        public GetTaskService(IGetTask task) => _task = task;


        public IEnumerable<dynamic> GetTask()
        {
            IEnumerable<dynamic> users = _task.GetTask();
                                                                            
            return users;
        }

        

        public void Dispose()
        {
            _task.Dispose();
        }
    }
}
