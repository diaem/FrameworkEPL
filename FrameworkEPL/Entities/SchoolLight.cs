using System;
namespace FrameworkEPL.Entities
{
	public class SchoolLight
	{
		public int     Id     { get; set; }
		public string  Name   { get; set; }
		public Grade[] Grades { get; set; }
	}
}
