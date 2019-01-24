using System;
using System.Data;
using System.Data.SqlClient;
using FrameworkEPL.Abstract;

namespace FrameworkEPL.Concret.SQL.School
{
    public class SchoolDataAccessSQL : ISchoolDataAccess
    {
        public int DeleteSchool(Entities.School school)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "DeleteSchoolAndGrade";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@idSchool", school.ID));
                int code = 500;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        code = int.Parse(dr.GetString(0));
                    }
                    return code;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return code;
                }
            }
        }
    }
}
