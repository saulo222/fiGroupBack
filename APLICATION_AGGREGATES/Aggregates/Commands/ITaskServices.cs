using APLICATION_CORE.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION_AGGREGATES.Aggregates.Commands
{
    /// <summary>
    /// Created By : Saul Cruz
    /// Date Created : 20/07/2022
    /// Contains definitions  that a property implement
    /// </summary>
    public interface ITaskServices : IDisposable
    {
        Task<bool> Add(TaskDTO taskdto);
        bool Update(TaskDTO taskdto);
        bool Delete(TaskDTO taskdto);

    }
}
