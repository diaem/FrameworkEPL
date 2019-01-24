using System;
using System.Collections.Generic;
using FrameworkEPL.Abstract;
using FrameworkEPL.Entities;

namespace FrameworkEPL.Concret.Mock.Catalog
{
    public class CatalogDataAccessMock : ICatalogDataAccess
    {
        public List<Entities.School> GetSchool(State state)
        {
            throw new NotImplementedException();
        }

        public List<State> GetState()
        {
            throw new NotImplementedException();
        }
    }
}
