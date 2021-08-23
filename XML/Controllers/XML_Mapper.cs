using System;
using System.Collections.Generic;
using System.Xml;
using XML.Interfaces;
using XML.Models;

namespace XML.Controllers
{
    public class XML_Mapper : IMapper<Item>
    {
        public XmlNode node { get; set; }

        public Item Map()
        {
            try
            {
                Item item = new Item();

                item.ID = node["ID"].InnerXml;
                item.UUID = node["UUID"].InnerXml;
                item.IssueDate = DateTime.ParseExact(node["IssueDate"].InnerXml, "yyyy-MM-dd HH:mm:ss", null);
                item.SupplierVKN = Int64.Parse(node["SupplierVKN"].InnerXml);
                item.Customer = Int64.Parse(node["Customer"].InnerXml);
                item.TotalAmount = double.Parse(node["TotalAmount"].InnerXml);

                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
