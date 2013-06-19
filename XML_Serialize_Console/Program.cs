using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Serialize_Console
{
	class Program
	{
		static void Main( string[] args ) 
		{
			Person person = new Person( "Larry" , 'E', "Nickerson",new DateTime(1964,5,12),3.5,
				new Address("180-43 Farmers Ave.",null,"Bronx",StateAbbreviation.NY,"10434") );

			Console.WriteLine("Before serialize: " + Environment.NewLine +
				person.ToString());

			XmlSerializer serializer = new XmlSerializer(typeof(Person));

			//for demo purposes, just serialize to a string
			StringBuilder sb = new StringBuilder();

			using (StringWriter sw = new StringWriter(sb))
			{
				//the actual serialization
				serializer.Serialize(sw,person);

				Console.WriteLine(Environment.NewLine + "XML:" + Environment.NewLine +
				                  sb.ToString() + Environment.NewLine);
			}

			using (StringReader sr = new StringReader(sb.ToString()))
			{
				//deserialize from text back into binary
				Person newPerson = serializer.Deserialize(sr) as Person;

				Console.WriteLine("After deserialize:" + Environment.NewLine+newPerson.ToString());
			} 
		}
	}
}
