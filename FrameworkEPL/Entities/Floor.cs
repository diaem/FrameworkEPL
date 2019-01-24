using System;
namespace FrameworkEPL.Entities
{
	public class Floor
	{
		public int    IdSchool      { get; set; }
		public int    IdBuild       { get; set; }
		public int    IdFloor       { get; set; }
		public string FloorName     { get; set; }
		public string FloorTagName  { get; set; }
		public bool   IsConsecutive { get; set; }
		public string FloorNumber   { get; set; }
	}
}
