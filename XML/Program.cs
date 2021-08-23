using System;
using System.Collections.Generic;
using XML.Controllers;
using XML.Models;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check-1");
            XML_Reader reader = new XML_Reader();

            Console.WriteLine("check-2");
            XML_List_Mapper mapper = new XML_List_Mapper();

            Console.WriteLine("check-3");
            mapper.nodeList = reader.ReadList("/Users/denizberkantdemirors/Desktop/programming projects/c# projects/XML/XML/dataAug-18-2021.xml");
            mapper.mapper = new XML_Mapper();
            Console.WriteLine("check-4");
            List<Item> items = new List<Item>();

            Console.WriteLine("check-5");
            items = mapper.MapList();

            Console.WriteLine("check-6");
            items.ForEach((item) => Console.WriteLine(item.ToString()));
        }
    }
}
