using System;
namespace FrameworkEPL.Entities
{
    public class UserReserveInfo
    {
        public int      IdUser   { get; set; }
        public string   DoorData { get; set; }
        public DateTime Fecha    { get; set; }
        public int      Intents  { get; set; }
    }
}
