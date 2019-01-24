using System;
using System.Runtime.Serialization;

namespace FrameworkEPL.Entities
{

	//[DataContract]
	public class Login
	{
	//	[DataMember(Name="User")]
		public string User 			{ get; set; }

	//	[DataMember(Name = "Password")]
		public string Password 		{ get; set; }
	}
}
