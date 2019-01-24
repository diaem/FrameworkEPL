using System;
using System.Configuration;
using System.Reflection;
using FrameworkEPL.Abstract;

namespace FrameworkEPL
{
    public class App
    {
        private static IDataAccess dataAccess;
        public static IDataAccess DataAccess
        {
            get
            {
                if (App.dataAccess == null)
                {
                    string data = ConfigurationManager.AppSettings["DataAcessClass"];
                    App.dataAccess = (IDataAccess)Assembly.GetExecutingAssembly().CreateInstance(data);

                    //App.dataAccess = new DataAccessSQL();
                    //Assembly assem = typeof(IDataAccess).Assembly;
                    //App.dataAccess = (IDataAccess)assem.CreateInstance(data);
                }
                return App.dataAccess;
            }
        }
        private static string connectionString;
        public static string ConnectionString
        {
            get
            {
                if (App.connectionString == null)
                    App.connectionString = ConfigurationManager.AppSettings["connectionString"];

                return App.connectionString;
            }
        }
    }
}
