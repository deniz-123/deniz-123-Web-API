using System.Collections.Generic;
using XML.ENTITIES;

namespace XML.DATA.Interfaces
{
    public interface IItemAccess
    {
        public Item CreateItem(Item item);
        public void DeleteItem(int id);
        public Item GetItemByID(int id);
        public List<Item> GetItems();
        public Item UpdateItem(Item item);
    }
}
