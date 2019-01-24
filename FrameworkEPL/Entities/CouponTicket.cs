using System;
namespace FrameworkEPL.Entities
{
	public class CouponTicket
	{
		public int      IdCoupon        { get; set; }
		public string   Token           { get; set; }
		public int      UsedTimes       { get; set; }
		public int      ReuseTimes      { get; set; }
		public bool     IsForever       { get; set; }
		public DateTime ExpirationDate  { get; set; }
		public DateTime StartDate       { get; set; }
		public int      PercentDiscount { get; set; }
		public float    TempPrice       { get; set; }
	}
}
