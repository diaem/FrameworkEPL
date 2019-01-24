using System;
using FrameworkEPL;
using FrameworkEPL.Entities;
using FrameworkEPL.Entities.Pojos;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;

namespace ServerAdministrativeEasyPointLoker.Protocols.Catalog
{
    public class GETSCHOOL : JsonSubCommand<StateMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, StateMessage commandInfo)
        {
            Console.WriteLine("Protocolo GETSCHOOL alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.SendResult(1, App.DataAccess.CatalogDataAccess.GetSchool(
                    new State()
                    {
                        ID = commandInfo.ID,
                        Value = ""
                    }
                ).ToArray());
        }
    }
}
