using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedXMLReader
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLHandler hanlder = new XMLHandler();
            hanlder.ReadAllElements();
            Console.Read();
        }
    }
}
