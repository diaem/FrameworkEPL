using System;
namespace FrameworkEPL.Entities
{
    public class Module
    {
           public int       Id_Module   { get; set; }
           public string    NameModule  { get; set; }
           public string    NameClient  { get; set; }
           public Boolean   IsFather    { get; set; }
           public string    Father      { get; set; }
    }
}
