using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadXML_File_with_XmlReader
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
			string publishYear = null, author = null;

			using (StringReader reader = new StringReader(sourceXml))
			{
				using (XmlTextReader xtr = new XmlTextReader(reader))
				{
					while (xtr.Read())
					{
						if (xtr.NodeType == XmlNodeType.Element)
						{
							if (xtr.Name == "Book")
							{
								if (xtr.MoveToAttribute("PublishYear"))
								{
									publishYear = xtr.Value;
								}
							}
							else if (xtr.Name == "Author")
							{
								xtr.Read();
								author = xtr.Value;
							}
						
						}
					}
				}
			}

			Console.WriteLine("Publish Year: {0}", publishYear);
			Console.WriteLine("Author: {0}", author);
		}
	}
}
