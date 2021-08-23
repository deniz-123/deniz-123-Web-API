using System.Collections.Generic;
using System.Xml;
using XML.ENTITIES;

namespace XML.BUSINESS.Interfaces
{
    public interface IItemManager
    {
        public Item CreateItem(Item item);
        public void DeleteItem(int id);
        public Item GetItemByID(int id);
        public Item GetItemFromXML(XmlNode node);
        public List<Item> GetItems();
        public Item UpdateItem(Item item);
    }
}
