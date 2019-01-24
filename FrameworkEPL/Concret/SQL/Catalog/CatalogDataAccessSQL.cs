using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FrameworkEPL.Abstract;
using FrameworkEPL.Entities;

namespace FrameworkEPL.Concret.SQL.Catalog
{
    public class CatalogDataAccessSQL : ICatalogDataAccess
    {

        public List<State> GetState()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "Nsp_GetState";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;

                List<State> state = new  List<State>();

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        state.Add(new State()
                        {
                            ID = int.Parse( dr["Id"].ToString() ),
                            Value = dr["Name"].ToString()
                        });
                    }
                    return state;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        List<Entities.School> ICatalogDataAccess.GetSchool(State state)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "GetFullSchoolsForState";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@state", state.ID));

                List<Entities.School> schools = new List<Entities.School>();

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        bool Primary = false, Secundary = false, HighSchool = false, University = false;

                        if (dr["isPrimary"].ToString()    != "0") { Primary   = true; } else { Primary    = false; }
                        if (dr["isSecundary"].ToString()  != "0") { Secundary = true; } else { Secundary  = false; }
                        if (dr["isHighSchool"].ToString() != "0") {HighSchool = true; } else { HighSchool = false; }
                        if (dr["isUniversity"].ToString() != "0") {University = true; } else { University = false; }

                        schools.Add(new Entities.School()
                        {
                            ID               =  int.Parse(dr["ID"].ToString()),
                            Name             =  (dr["Name"].ToString()),
                            StreetAndNumber  =  (dr["StreetAndNumber"].ToString()),
                            Colony           =  (dr["Colony"].ToString()),
                            Township         =  (dr["Township"].ToString()),
                            Zipcode          =  int.Parse(dr["Zipcode"].ToString()),
                            Lada             =  (dr["Lada"].ToString()),
                            PhoneNumber      =  (dr["PhoneNumber"].ToString()),
                            Email            =  (dr["Email"].ToString()),
                            IdState          =  int.Parse(dr["IdState"].ToString()),
                            IsPrimary        =  Primary,
                            IsSecundary      =  Secundary,
                            IsHighSchool     =  HighSchool,
                            IsUniversity     =  University
                        });
                    }
                    return schools;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }
    }
}
