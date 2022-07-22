using DOMAIN_AGGREGATES.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.Dynamic;

namespace PERSITENCE_CORE.Users
{
    public class MainContextGetUsers : DbContext, IGetUsers
    {



        public MainContextGetUsers(DbContextOptions<MainContextGetUsers> options)
            : base(options)
        {

        }

        public IEnumerable<dynamic> GetAllUsers()
        {


            Microsoft.Data.SqlClient.SqlParameter[] parameters = {
                //parameterOwner,
                //parameterYear,
                //parameterLowPrice,
                //parameterHighPrice,
                //parameterCodInternal,
                //parameterProperty
            };

            var connection = Database.GetDbConnection();
            // Open the connection if isn't open
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT  [EmployeeID]
      ,[EmployeeName]
      ,[EmployeeLastName]
      ,[EmployeeTypeIdentificacion]
      ,[EmployeeIdentificacion]
      ,[EmployeeUnit]
      ,[EmployeeSalary]
      ,[EmployeeCategorie]
      ,[EmployeeState]
      ,[EmployeeSection]
      ,[EmployeeDepartment]
      ,[EmployeeDivision]
      ,[EmployeeManagment]
      ,[EmployeeCompany]
      ,[EmployeeMail]
      ,[ContractTypeiD]
      ,[ContractName]
      ,[RelationalPositionName]
  FROM [Moksecurity].[dbo].[Usuarios]";
                command.Connection = connection;
                try
                {
                    if (parameters?.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                }
                catch (Exception e)
                {
                    connection.Close();
                    yield break;
                }
                using (var dataReader = command.ExecuteReader())
                {
                    // List for column names
                    var names = new List<string>();

                    if (dataReader.HasRows)
                    {
                        // Add column names to list
                        for (var i = 0; i < dataReader.VisibleFieldCount; i++)
                        {
                            names.Add(dataReader.GetName(i));
                        }

                        while (dataReader.Read())
                        {
                            // Create the dynamic result for each row

                            var result = new ExpandoObject() as IDictionary<string, object>;

                            foreach (var name in names)
                            {
                                result.Add(name, dataReader[name]);
                            }

                            yield return result;
                        }
                    }
                }

            }
        }


       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          //  modelBuilder.ApplyConfiguration(new PropertyConfig());
        }
    }
}
