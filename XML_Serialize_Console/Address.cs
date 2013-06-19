using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace XML_Serialize_Console
{
public class Address
	{
	public string AddressLine1 { get; set; }
	public string AddressLine2 { get; set; }
	public string City { get; set; }
	public StateAbbreviation State { get; set; }
	public string ZipCode { get; set; }


	public Address( string addressLine1, string addressLine2,
		string city, StateAbbreviation state, string zipCode )
	{
		this.AddressLine1 = addressLine1;
		this.AddressLine2 = addressLine2;
		this.City = city;
		this.State = state;
		this.ZipCode = zipCode;
	}


	public Address()
	{
		
	}

	public override string ToString()
	{
		return AddressLine1 + Environment.NewLine + AddressLine2 + Environment.NewLine + City + ", " +
		       State + " " +
		       ZipCode;
	}
	}

}
