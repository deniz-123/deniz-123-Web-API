using System.Collections.Generic;
using System.Xml;
using XML.BUSINESS.Interfaces;
using XML.DATA;
using XML.DATA.Concrete;
using XML.DATA.Interfaces;
using XML.ENTITIES;

namespace XML.BUSINESS
{
    public class ItemManager : IItemManager
    {
        private IMapper<Item> _itemMapper;
        private IItemAccess _itemAccess;

        public ItemManager(IMapper<Item> itemMapper, IItemAccess itemAccess)
        {
            _itemAccess = itemAccess;
            _itemMapper = itemMapper;
        }

        public Item GetItemFromXML(XmlNode node)
        {
            _itemMapper.SetNode(node);
            return _itemMapper.Map();
        }

        public Item CreateItem(Item item)
        {
            return _itemAccess.CreateItem(item);
        }

        public void DeleteItem(int id)
        {
            _itemAccess.DeleteItem(id);
        }

        public Item GetItemByID(int id)
        {
            return _itemAccess.GetItemByID(id);
        }

        public List<Item> GetItems()
        {
            return _itemAccess.GetItems();
        }

        public Item UpdateItem(Item item)
        {
            return _itemAccess.UpdateItem(item);
        }
    }
}
