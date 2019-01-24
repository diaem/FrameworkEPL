using System;
namespace FrameworkEPL.Entities
{
	public class UserApp
	{
		public int    IdUserApp      { get; set; }
		public string UserName       { get; set; }
		public string Password       { get; set; }
		public int    IdSchool       { get; set; }
		public int    IdGrade        { get; set; }
		public string Data           { get; set; }
		public string Token          { get; set; }
		public bool   IsFacebookUser { get; set; }
		public string FacebookUser   { get; set; }
		public bool   IsReset        { get; set; }
	}
}
