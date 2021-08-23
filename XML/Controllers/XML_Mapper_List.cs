using System;
using System.Collections.Generic;
using System.Xml;
using XML.Interfaces;
using XML.Models;

namespace XML.Controllers
{
    public class XML_List_Mapper : IMapperList<Item>
    {
        public XmlNodeList nodeList { get; set; }
        public XML_Mapper mapper { get; set; }

        public List<Item> MapList()
        {
            try
            {
                List<Item> returnList = new List<Item>();

                foreach (XmlNode node in nodeList)
                {
                    mapper.node = node;
                    returnList.Add(mapper.Map());
                }

                return returnList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
