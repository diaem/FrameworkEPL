using System;
using FrameworkEPL.Abstract;
using FrameworkEPL.Entities;

namespace FrameworkEPL.Concret.Mock.School
{
    public class SchoolDataAccessMock : ISchoolDataAccess
    {
        public int DeleteSchool(Entities.School school)
        {
            throw new NotImplementedException();
        }
    }
}
