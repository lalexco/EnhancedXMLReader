using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnhancedXMLReader
{
    public class XMLHandler
    {
        public void ReadAllElements()
        {
            XElement xelement = XElement.Load("..\\..\\Yodlee.xml");
            var data = from nm in xelement.Elements("bankAccount")
                       //where (string)nm.Attribute("uniqueId") == "000000001"
                       select nm;
            Console.WriteLine("Details of Bank Accounts");
            foreach (XElement xEle in data)
            {
                Console.WriteLine("FirstName: " + xEle.Element("FirstName")?.Value ?? string.Empty);
                Console.WriteLine("Address1: " + xEle.Element("Address1")?.Value ?? string.Empty);
                Console.WriteLine("State: " + xEle.Element("State")?.Value ?? string.Empty);
            }
        }
    }
}
