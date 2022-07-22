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
    /// Created by: Saul Cruz
    /// Date Created: 27/01/2022
    /// Service that contains the query operations that a property implements.
    /// </summary>
    public class GetUsersService : IGetUsersServices
    {
        private IGetUsers _users;

        public GetUsersService(IGetUsers users) => _users = users;


        //private void ValidatePropertyDTO(PropertyDTO propertyDTO)
        //{
        //    //if (!isExistForm(bodyFormDTO.FormId)) throw new Exception("El ID del Formulario no existe");

        //}
        public IEnumerable<dynamic> GetAllUsers()
        {
            IEnumerable<dynamic> users = _users.GetAllUsers();
                                                                            
            return users;
        }

        

        public void Dispose()
        {
            _users.Dispose();
        }
    }
}
