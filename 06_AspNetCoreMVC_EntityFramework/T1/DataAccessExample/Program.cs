using System;
using DataAccessExample.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessExample
{

    class Program
    {
        const string connectionSettings = "Server=localhost;User=root;Port=3307;Password='let us gou';Database=sqltesting";
        static void Main(String[] args)
        {

            GetUsers();
            GetUser(1);
            CreateCompany("Tesla", "EU", "admin@elAdmin.com", "emploeyee@employ.com");

        }
        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            Console.WriteLine(String.Format("{0}, {1}, {2}, {3}", dataRecord[0], dataRecord[1], dataRecord[2], dataRecord[3]));
        }
        private static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var connection = new MySqlConnector.MySqlConnection(connectionSettings))
            {
                connection.Open();

                using var command = new MySqlConnector.MySqlCommand("GetAllUsers", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            Id = (int)reader["iduser"],
                            UserName = reader["username"] as string,
                            Email = reader["email"] as string,
                            CompanyId = (int)reader["id_company"]
                        };
                        ReadSingleRow((IDataRecord)reader);
                        users.Add(user);
                    }
            }

            return users;
        }
        private static User GetUser(int id)
        {
            User user = null;
            using (var connection = new MySqlConnector.MySqlConnection(connectionSettings))
            {
                connection.Open();

                using var command = new MySqlConnector.MySqlCommand("GetUserById", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", id);
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        user = new User
                        {
                            Id = (int)reader["iduser"],
                            UserName = reader["username"] as string,
                            Email = reader["email"] as string,
                            CompanyId = (int)reader["id_company"]
                        };
                        ReadSingleRow((IDataRecord)reader);
                    }
            }

            return user;
        }

        private static CompanyCreationResult CreateCompany(string companyName, string location, string adminEmail, string employeeEmail)
        {

            CompanyCreationResult companyR = null;
            using (var connection = new MySqlConnector.MySqlConnection(connectionSettings))
            {
                connection.Open();

                using var command = new MySqlConnector.MySqlCommand("CreateCompany", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_companyName", companyName);
                command.Parameters.AddWithValue("_location", location);
                command.Parameters.AddWithValue("_adminEmail", adminEmail);
                command.Parameters.AddWithValue("_userEmail", employeeEmail);

                var companyIdParameter = command.Parameters.Add("_idCompany", System.Data.DbType.Int32);
                companyIdParameter.Direction = System.Data.ParameterDirection.Output;
                var adminIdParameter = command.Parameters.Add("_idAdmin", System.Data.DbType.Int32);
                adminIdParameter.Direction = System.Data.ParameterDirection.Output;
                var employeeIdParameter = command.Parameters.Add("_idUser", System.Data.DbType.Int32);
                employeeIdParameter.Direction = System.Data.ParameterDirection.Output;

                command.ExecuteNonQuery();
                companyR = new CompanyCreationResult
                {
                    CompanyId = (int)companyIdParameter.Value,
                    AdminId = (int)adminIdParameter.Value,
                    UserId = (int)employeeIdParameter.Value
                };
            }
            Console.WriteLine(companyR);
            return companyR;
        }
    }
}