using System;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class InMemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Shield", Price = 10, CreatedDate = DateTimeOffset.UtcNow }
        };

        public IEnumerable<Item> GetItems() // returns a list of all avaiable items
        {
            return items;
        }

        public Item GetItem(Guid id) // gets a specific items (needs id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public Item GetId(string name)
        {
            return items.Where(item => item.Name == name).SingleOrDefault();
        }
    }
    
}
