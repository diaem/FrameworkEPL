using System;
namespace FrameworkEPL.Entities
{
	public enum DoorName
	{
		A = 1,
		B = 2,
		C = 3,
		D = 4,
		E = 5
	}

	public enum DoorState
	{
		ABLE        = 1,
		RESERVED    = 2,
		PAYPROCESS  = 3,
		OCUPPED     = 4,
		MAINTENANCE = 5
	}
	public class Door
	{
		public int       IdSchool { get; set; }
		public int       IdBuild  { get; set; }
		public int       IdFloor  { get; set; }
		public int       IdBlock  { get; set; }
		public int       IdLocker { get; set; }
		public DoorName  Name     { get; set; }
		public int       IdUser   { get; set; }
		public DoorState Status   { get; set; }
		public string    TagName  { get; set; }
        public DateTime  ReservationDate { get; set; }
    }
}
