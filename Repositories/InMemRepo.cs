using System.Collections.Generic;

namespace WebAPI.Reposoties
{
	public class InMemRepo
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreateDate = DateTimeOfSet.Utc.Now },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreateDate = DateTimeOfSet.Utc.Now },
            new Item { Id = Guid.NewGuid(), Name = "Shield", Price = 10, CreateDate = DateTimeOfSet.Utc.Now }
        };

        public IEnumerable<Item> GetItems() // returns a list of all avaiable items
        {
            return items;
        }

        public Item GetItems(Guid id) // gets a specific items (needs id)
        {
            return items.Where(item => item.Id == id).singleOrDefault();
        }
    }
}