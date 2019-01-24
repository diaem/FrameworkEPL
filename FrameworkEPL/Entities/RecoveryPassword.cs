using System;
namespace FrameworkEPL.Entities
{
    public class RecoveryPassword
    {
        public string Token    {get; set;}
        public string Email    { get; set;}
        public string Password { get; set;}
    }
}
