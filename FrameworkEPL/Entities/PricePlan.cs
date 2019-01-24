using System;
namespace FrameworkEPL.Entities
{
	public class PricePlan
	{
		public int      IdAssignation  { get; set; }
		public string   Name 		   { get; set; }
		public DateTime ExpirationDate { get; set; }
		public float    P2 		       { get; set; }
		public float    P3 		       { get; set; }
		public float    P4 		       { get; set; }
		public float    P5 		       { get; set; }
		public float    CashCommission { get; set; }
	}
}
