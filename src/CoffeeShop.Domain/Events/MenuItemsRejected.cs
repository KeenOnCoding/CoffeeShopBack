using CoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CoffeeShop.Domain.Events
{
    public class MenuItemsRejected : IEvent
    {
        public Guid TabId { get; set; }

        public IList<MenuItem> MenuItems { get; set; }
    }
}
