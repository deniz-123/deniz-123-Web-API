using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XML.BUSINESS.Interfaces;
using XML.ENTITIES;
using XML.BUSINESS;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace XML.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsDbController : ControllerBase
    {
        private IItemManager _itemManager;

        public ItemsDbController(IItemManager itemManager)
        {
            _itemManager = itemManager;
        }

        [HttpGet]
        public List<Item> Get()
        {
            return _itemManager.GetItems();
        }

        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _itemManager.GetItemByID(id);
        }

        [HttpPost]
        public Item Post([FromBody] Item item)
        {
            return _itemManager.CreateItem(item);
        }

        [HttpPost]
        public Item Put([FromBody] Item item)
        {
            return _itemManager.UpdateItem(item);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _itemManager.DeleteItem(id);
        }

    }
}
