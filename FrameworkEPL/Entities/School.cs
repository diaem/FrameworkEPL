using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEPL.Entities
{
    public class School
    {
        public int 	    ID 			        { get; set; }
        public string   Name 	 		    { get; set; }
		public string   StreetAndNumber     { get; set; }
		public string   Colony 		        { get; set; }
		public string   Township 		    { get; set; }
		public int 	    Zipcode 		    { get; set; }
		public string   Lada 			    { get; set; }
		public string   PhoneNumber 	    { get; set; }
		public string   Email 		        { get; set; }
        public int 	    IdState 		    { get; set; }
		public bool     IsPrimary 	        { get; set; }
		public bool     IsSecundary 	    { get; set; }
		public bool     IsHighSchool 	    { get; set; }
		public bool     IsUniversity        { get; set; }
	}
}
