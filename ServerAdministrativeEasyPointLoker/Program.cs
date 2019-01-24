using System;
using ServerAdministrativeEasyPointLoker.Protocols;

namespace ServerAdministrativeEasyPointLoker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //PropertyType[] searchs = App.DataAccess.DataAccessPropertyType.GetPropertyType();
            //for (int i = 0; i < searchs.Length; i++)
            //{

            //}



            WebSocketServerTest server = new WebSocketServerTest();
            server.Setup(9097);
            Console.WriteLine("Server Administrative EasyPointLocker Listener .......");
            server.Start();
            Console.ReadLine();
            server.Stop();
            Console.WriteLine("Error");


            //ServiceBase.Run(new Service1());        }
        }
    }
}