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
    public class GetProductsService : IGetProductsServices
    {
        private IGetProducts _products;

        public GetProductsService(IGetProducts products) => _products = products;


        public IEnumerable<dynamic> GetProducts()
        {
            IEnumerable<dynamic> users = _products.GetProducts();
                                                                            
            return users;
        }

        

        public void Dispose()
        {
            _products.Dispose();
        }
    }
}
