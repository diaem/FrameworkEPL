using System;
using System.Collections.Generic;

namespace FrameworkEPL.Entities
{
    public class Users
    {
        public int              Id_User         { get; set; }
        public string           NameUser        { get; set; }    
        public string           LastName        { get; set; }    
        public int              Age             { get; set; }
        public string           UserName        { get; set; }
        public string           Password        { get; set; }
        public int              PhoneNumber     { get; set; }
        public string           Email           { get; set; }
        public Boolean          IsUserApp       { get; set; }
        public List<Module>     modules         { get; set; }
        public string           AccessTocken    { get; set; }
    }
}
