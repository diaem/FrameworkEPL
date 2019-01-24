using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FrameworkEPL.Abstract.Login;
using FrameworkEPL.Entities;

namespace FrameworkEPL.Concret.SQL.Login
{
    public class LoginDataAccessSQL : ILoginDataAccess
    {
        public List<Users> ValidateUser(string UserName, string Password)
        {
            int Id_Users = 0;
            List <Module> modules = new List<Module>();
            List<Users> users;

            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_ValidateUser";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@User",     UserName));
                command.Parameters.Add(new SqlParameter("@Password", Password));

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Id_Users = int.Parse(dr["Status"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
            }

            if(Id_Users > 0)
            {
                using (SqlConnection connection = new SqlConnection(App.ConnectionString))
                {
                    connection.Open();
                    string query = "sp_GetModule";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@IdUser", Id_Users));

                    try
                    {
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            bool IsFather = false;

                            if (dr["IsFather"].ToString() != "0") { IsFather = true; } else { IsFather = false; }

                            modules.Add(new Module()
                            {
                                Id_Module  = int.Parse(dr["Id_Module"].ToString()),
                                NameModule = (dr["Name"].ToString()),
                                NameClient = (dr["NameClient"].ToString()),
                                IsFather   = (IsFather),
                                Father     = (dr["Father"].ToString()),
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                    }
                }

                string accessTocken = DateTime.Now.ToString("d") + Id_Users;
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(accessTocken);
                accessTocken = System.Convert.ToBase64String(plainTextBytes);

                users = new List<Users>();
                users.Add(new Users()
                {
                    Id_User         = Id_Users,
                    NameUser        = "",
                    LastName        = "",
                    Age             = 0,
                    UserName        = "",
                    Password        = "",
                    PhoneNumber     = 0,
                    Email           = "",
                    IsUserApp       = false,
                    modules         = modules,
                    AccessTocken    = accessTocken,
                }
                         );

            }
            else
            {
                users = new List<Users>();
                users.Add( new Users() {
                                         Id_User      = 0,
                                         NameUser     = "",
                                         LastName     = "",
                                         Age          = 0,
                                         UserName     = "",
                                         Password     = "",
                                         PhoneNumber  = 0,
                                         Email        = "",
                                         IsUserApp    = false,
                                         modules      = new List <Module>(),
                                         AccessTocken = "",
                                       }
                         );
            }

            return users;
        }
    }
}
