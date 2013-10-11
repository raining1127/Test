using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootElement = XElement.Load("test.xml");
            var nameNodes = rootElement.Descendants(rootElement.Name.Namespace + "Name");

            foreach (var nameNode in nameNodes)
            {
                Console.WriteLine(nameNode.Value);
            }

            Console.ReadLine();
        }
    }
}
