﻿using DOMAIN_AGGREGATES.Base;
using DOMAIN_CORE.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN_AGGREGATES.GetTask.Commands
{
    /// <summary>
    /// Created By : Saul Cruz
    /// Date Created : 20/07/2022
    /// Contains operations implemented by Task
    /// </summary>
    public interface ITask : IRepositoryBase<Tasks>, IDisposable
    {

    }
}
