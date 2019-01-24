using System;
namespace FrameworkEPL.Entities
{
	public class Locker
	{
		public int    IdSchool          { get; set; }
		public int    IdBuild           { get; set; }
		public int    IdFloor           { get; set; }
		public int    IdBlock           { get; set; }
		public int    IdLocker          { get; set; }
		public int    LockerDoors       { get; set; }
		public bool   IsPaddingIdLocker { get; set; }
		public string LockerTempTag     { get; set; }

		public Door[] Doors             { get; set; }
	}
}

