using System;
using FrameworkEPL;
using FrameworkEPL.Entities;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;

namespace ServerAdministrativeEasyPointLoker.Protocols.School
{
    public class DELETESCHOOL : JsonSubCommand<FrameworkEPL.Entities.School>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, FrameworkEPL.Entities.School commandInfo)
        {
            Console.WriteLine("Protocolo DELETESCHOOL alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.SendResult(App.DataAccess.SchoolDataAccess.DeleteSchool(
            new FrameworkEPL.Entities.School()
            {
                ID = commandInfo.ID,
                Name = "",
                StreetAndNumber = "",
                Colony = "",
                Township = "",
                Zipcode = 0,
                Lada = "",
                PhoneNumber = "",
                Email = "",
                IdState = 0,
                IsPrimary = false,
                IsSecundary = false,
                IsHighSchool = false,
                IsUniversity = false
            }), 
                    new FrameworkEPL.Entities.School()
                    {
                        ID = 0,
                        Name = "",
                        StreetAndNumber = "",
                        Colony = "",
                        Township = "",
                        Zipcode = 0,
                        Lada = "",
                        PhoneNumber = "",
                        Email = "",
                        IdState = 0,
                        IsPrimary = false,
                        IsSecundary = false,
                        IsHighSchool = false,
                        IsUniversity = false
                    });
        }
    }
}
