using System;
namespace FrameworkEPL.Entities
{
	public class Plan
	{
		public int 	  Id 		 { get; set; }
		public string Name 		 { get; set; }
		public int 	  IdGrade 	 { get; set; }
		public int 	  PeriodType { get; set; }
		public string Duration 	 { get; set; }
	}
}
