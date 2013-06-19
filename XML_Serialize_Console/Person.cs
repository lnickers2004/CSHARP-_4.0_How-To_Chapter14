using System;

namespace XML_Serialize_Console
{
	public class Person
	{
		public string FirstName { get; set; }
		public char MiddleInitial { get; set; }
		public string LastName { get; set; }

		public DateTime BirthDate { get; set; }
		public double HighschoolGPA { get; set; }

		public Address Address { get; set; }


		//to be XML serialized, the type must have
		//a parameterless constructor
		public Person()
		{}

		public Person(string firstName, char middleInitial, string lastName,
			DateTime birthDate, double highSchoolGpa, Address address)
		{
			this.FirstName = firstName;
			this.MiddleInitial = middleInitial;
			this.LastName = lastName;
			this.BirthDate = birthDate;
			this.HighschoolGPA = highSchoolGpa;
			this.Address = address;
		}

		public override string ToString()
		{
			return FirstName + " " + MiddleInitial + ". " + LastName +
			       ", DOB:" + BirthDate.ToShortDateString() + ", GPA: " +
			       this.HighschoolGPA + Environment.NewLine + Address.ToString();

		}
	}
}