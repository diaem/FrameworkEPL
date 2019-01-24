using System;
using System.Collections.Generic;
using FrameworkEPL.Entities;

namespace FrameworkEPL.Abstract.Login
{
    public interface ILoginDataAccess
    {
        List<Users> ValidateUser(string UserName,string Password);
    }
}
