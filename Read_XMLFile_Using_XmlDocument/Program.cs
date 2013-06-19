using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Read_XMLFile_Using_XmlDocument
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
			XmlDocument doc = new XmlDocument();

			doc.LoadXml(sourceXml);

			Console.WriteLine("Publish year: {0}", doc.GetElementsByTagName("Book")[0].Attributes["PublishYear"].Value );

			Console.WriteLine("Author: {0}", doc.GetElementsByTagName("Author")[0].InnerText);
		}
	}
}
