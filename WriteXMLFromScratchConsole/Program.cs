using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace WriteXMLFromScratch_Console
{
	class Program
	{
		static void Main( string[] args )
		{
			#region Write XML Using XmlDocument

			//first method of Writing XML from scratch is to use the XmlDocument Class
			XmlDocument doc = new XmlDocument();

			XmlElement bookElem = doc.CreateElement("Book");

			bookElem.SetAttribute("PublishYear", "2009");

			XmlElement titelElem = doc.CreateElement("Title");

			titelElem.InnerText = "Programming, art or engineering?";

			XmlElement authorElem = doc.CreateElement("Author");

			authorElem.InnerText = "Billy Bob";

			bookElem.AppendChild(titelElem);
			bookElem.AppendChild(titelElem);
			bookElem.AppendChild(authorElem);

			doc.AppendChild(bookElem);

			StringBuilder sb = new StringBuilder();

			//you could write to a file or any stream jsut as well

			using (StringWriter sw = new StringWriter(sb))
			{
				using (XmlTextWriter xtw = new XmlTextWriter(sw))
				{
					//if you don't specify this, the XML will be a single
					//long line of un broken XML -- better for transmission,
					//but not console
					xtw.Formatting = Formatting.Indented;

					doc.WriteContentTo(xtw);

					Console.WriteLine(sb.ToString());
				}
			}


			#endregion

			#region Write Xml Using XmlWriter

			//alternative method is to use the XmlWriter


			#endregion

		}
	}
}
