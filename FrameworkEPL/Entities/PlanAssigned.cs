using System;
namespace FrameworkEPL.Entities
{
	public class PlanAssigned
	{
		public int      IdAssignation  { get; set; }
		public int      IdSchool       { get; set; }
		public int      IdPlan         { get; set; }
		public int      IdGrade        { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string   Name           { get; set; }
	}
}
