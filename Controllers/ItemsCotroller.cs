using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsContoller : ControllerBase
    {
        private readonly IItemsRepository repository;


        public ItemsContoller(IItemsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet] // /items 
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        [HttpGet("{id}")] // /items/{id}
        public ActionResult<Item> GetItemCost(Guid id)
        {
            var item = repository.GetItem(id);

            if ( item == null)
            {
                return NotFound();
            }

            return item;
        }
    }
}
