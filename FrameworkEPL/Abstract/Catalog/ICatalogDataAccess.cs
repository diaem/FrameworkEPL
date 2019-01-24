using System;
using System.Collections.Generic;
using FrameworkEPL.Entities;

namespace FrameworkEPL.Abstract
{
    public interface ICatalogDataAccess
    {
        List<State>    GetState();
        List<School>   GetSchool(State state);
    }
}
