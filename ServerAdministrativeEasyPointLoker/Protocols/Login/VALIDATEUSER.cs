using System;
using OKYSoft.Net.WebSocket.SubProtocol;
using FrameworkEPL.Entities;
using OKYSoft.Net.WebSocket;
using FrameworkEPL;

namespace ServerAdministrativeEasyPointLoker.Protocols.Login
{
    public class VALIDATEUSER : JsonSubCommand<FrameworkEPL.Entities.Users>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, FrameworkEPL.Entities.Users commandInfo)
        {
            Console.WriteLine("Protocolo VALIDATEUSER alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.SendResult(1, App.DataAccess.LoginDataAccess.ValidateUser(
                    
                        commandInfo.UserName,
                        commandInfo.Password
           
                ).ToArray());
        }
    }
}
