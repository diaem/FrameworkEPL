using System;

namespace FrameworkEPL.Entities
{
	public enum IdGrade {
		Primary    = 1,
		Secundary  = 2,
		HighSchool = 3,
		University = 4
	}

	public class Grade
	{
        public int     IdSchoolGrade { get; set; }
		public IdGrade Id 			 { get; set; }
        public int     IdSchool      { get; set; }
		public Boolean Value 		 { get; set; }
	}
}

