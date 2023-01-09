using CoffeeShop.Domain.Views;
using System.Collections.Generic;

namespace CoffeeShop.Core.MenuContext.Commands
{
    public class AddMenuItems : ICommand
    {
        public IList<MenuItemView> MenuItems { get; set; }
    }
}
