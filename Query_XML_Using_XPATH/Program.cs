using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Query_XML_Using_XPATH
{
	class Program
	{
		static void Main( string[] args )
		{
			XPathDocument doc = new XPathDocument("LesMis.xml");

			XPathNavigator navigator = doc.CreateNavigator();
			XPathNodeIterator iter = navigator.Select("/Book/Chapters/Chapter");

			while (iter.MoveNext())
			{
				Console.WriteLine("Chapter: {0}", iter.Current.Value);
			}

			Console.WriteLine( "Found {0} Chapters", navigator.Evaluate(("count(/Book/Chapters/Chapter)")) );


			Console.WriteLine( "Press <Enter> to exit..." );
			Console.ReadLine();
		}



	}
}
