using System;
using System.Collections.Generic;
using System.Linq;
using XML.DATA.Interfaces;
using XML.ENTITIES;

namespace XML.DATA.Concrete
{
    public class ItemAccess : IItemAccess
    {
        private ItemDbContext _context;

        public ItemAccess()
        {
            _context = new ItemDbContext();
        }

        public Item CreateItem(Item item)
        {
            try
            {
                _context.Items.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        public void DeleteItem(int id)
        {
            try
            {
                Item item = GetItemByID(id);
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        public Item GetItemByID(int id)
        {
            try
            {
                return _context.Items.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        public List<Item> GetItems()
        {
            try
            {
                return _context.Items.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        public Item UpdateItem(Item item)
        {
            try
            {
                _context.Items.Update(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }
    }
}
