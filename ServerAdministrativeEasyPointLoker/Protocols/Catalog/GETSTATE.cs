using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FrameworkEPL;
using FrameworkEPL.Entities;
using FrameworkEPL.Entities.Pojos;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;

namespace ServerAdministrativeEasyPointLoker.Protocols.Catalog
{
    public class GETSTATE : JsonSubCommand<ExampleMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, ExampleMessage commandInfo)
        {
            Console.WriteLine("Protocolo GETSTATE alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.SendResult(1,App.DataAccess.CatalogDataAccess.GetState().ToArray());
        }
    }
}
