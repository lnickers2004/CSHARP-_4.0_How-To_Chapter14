using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Transform_XML_To_Html
{
	class Program
	{
		static void Main( string[] args )
		{
			XslCompiledTransform transform = new XslCompiledTransform();
			transform.Load("BookTransform.xslt");

			transform.Transform("LesMis.xml", "LesMis.html");

			//view web page in a browser
			Process.Start("LesMis.html");
		}
	}
}
