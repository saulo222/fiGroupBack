﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN_AGGREGATES.Users
{
    /// <summary>
    /// Created By : Saul Cruz
    /// Date Created : 12\07\2022
    /// Contains the query operations implemented by Products
    /// </summary>
    public interface IGetProducts : IDisposable
    {
        public IEnumerable<dynamic> GetProducts();
       
    }
}
