using System;
using ServerSalesEasyPointLoker.Protocolos;

namespace ServerSalesEasyPointLoker
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
            server.Setup(9098);
            Console.WriteLine("Server Sales EasyPointLocker Listener .......");
            server.Start();
            Console.ReadLine();
            server.Stop();
            Console.WriteLine("Error");


            //ServiceBase.Run(new Service1());        }
        }
    }
}
