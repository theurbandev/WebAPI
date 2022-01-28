using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;


        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet] 
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItemCost(Guid id)
        {
            var item = repository.GetItem(id);

            if ( item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpGet("price/{id}")]
        public decimal GetPrice(Guid id)
        {
            var item = repository.GetItem(id);
            var itemPrice = item.Price;

            return itemPrice;
        }
    }
}
