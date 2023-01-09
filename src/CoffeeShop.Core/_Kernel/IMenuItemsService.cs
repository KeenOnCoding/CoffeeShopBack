using CoffeeShop.Domain;
using CoffeeShop.Domain.Entities;
using Optional;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeShop.Core
{
    public interface IMenuItemsService
    {
        Task<Option<IList<MenuItem>, Error>> ItemsShouldExist(IList<int> menuItemNumbers);
    }
}
