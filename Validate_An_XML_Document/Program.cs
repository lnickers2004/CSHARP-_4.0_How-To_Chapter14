using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Validate_An_XML_Document
{
	class Program
	{
		const string sourceXml =
		"<Book PublishYear=\"2009\">" +
		"<Title>Programming, art or engineering?</Title>" +
		"<Author>LeTigre Woods</Author>" +
		"</Book>";

		static void Main( string[] args )
		{
			XmlSchemaSet schemaSet = new XmlSchemaSet();

			schemaSet.Add(null, "XmlBookSchema.xsd");

			XmlReaderSettings settings = new XmlReaderSettings();
			settings.ValidationType= ValidationType.Schema;
			settings.Schemas = schemaSet;
			settings.ValidationEventHandler += settings_ValidationEventHandler;

			using(StringReader reader = new StringReader(sourceXml))
			using (XmlReader xmlReader = XmlTextReader.Create(reader,settings))
			{
				while (xmlReader.Read()) ;
			}
		}

		static void settings_ValidationEventHandler( object sender, ValidationEventArgs e )
		{
			//throw new NotImplementedException();
			Console.WriteLine("Validation Failed: " + e.Message);
		}
	}
}
