using System;
namespace FrameworkEPL.Entities
{
	public enum SchoolTimePeriods
	{
		ElementarySchool = 1,   // Primaria
		SecondarySchool  = 2,   // Secundaria
		HighSchoolTrim   = 3,   // Prepa Trimestral
		HighSchoolCuatri = 4,   // Prepa Cuatrimestral
		HighSchoolSem    = 5,   // Prepa Semestral
		UniversityCuatri = 6,   // Universidad Cuatrimestral
		UniversitySem    = 7,   // Universidad Semestral
		UniversityAnual  = 8,   // Universidad Anual
		None = 0
	}

	public class SchoolPeriod
	{
		public string   Name                 { get; set; }
		public int      Id                   { get; set; }
		public string   Period               { get; set; }
		public float    Price                { get; set; }
		public string   Expiration           { get; set; }
		public DateTime ExpirationDate       { get; set; }
		public SchoolTimePeriods TimePeriods { get; set; }
	}
}
