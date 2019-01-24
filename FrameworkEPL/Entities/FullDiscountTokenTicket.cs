using System;
namespace FrameworkEPL.Entities
{
	public class FullDiscountTokenTicket
	{
		public int      IdCoupon      { get; set; }
		public string   Token         { get; set; }
		public string   SecurityToken { get; set; }
		public int      IdUser        { get; set; }
		public DateTime Expiration    { get; set; }
	}
}
