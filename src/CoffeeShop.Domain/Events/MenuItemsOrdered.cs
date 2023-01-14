using CoffeeShop.Domain.Entities;

namespace CoffeeShop.Domain.Events
{
    public class MenuItemsOrdered : IEvent
    {
        public Guid TabId { get; set; }

        public IList<MenuItem> MenuItems { get; set; }
    }
}