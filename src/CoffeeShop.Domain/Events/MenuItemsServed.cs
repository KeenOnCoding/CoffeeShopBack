using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CoffeeShop.Domain.Events
{
    public class MenuItemsServed : IEvent
    {
        public Guid TabId { get; set; }

        public IList<MenuItem> MenuItems { get; set; }
    }
}
