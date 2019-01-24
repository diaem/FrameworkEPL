using System;
using System.Collections.Generic;
using FrameworkEPL.Abstract.Login;
using FrameworkEPL.Entities;

namespace FrameworkEPL.Concret.Mock.Login
{
    public class LoginDataAccessMock : ILoginDataAccess
    {
        public List<Users> ValidateUser(string UserName, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
