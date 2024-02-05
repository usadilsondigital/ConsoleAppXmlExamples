using System;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleAppXmlExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salute = "Hello World";
            XElement newSalute = new XElement("Salute", salute);
            Console.WriteLine(newSalute);
        }
    }
}
