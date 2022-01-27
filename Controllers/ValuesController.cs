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
        private readonly InMemRepository repository;

        public ItemsContoller()
        {
            repository = new InMemRepository();
        }

        [HttpGet] // GET /items 
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        [HttpGet]
        [Route ("item")]
        public decimal GetItemCost(Guid id)
        {
            var item = repository.GetItem(id);
            return item.Price;
        }
    }
}
