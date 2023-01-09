using CoffeeShop.Domain.Entities;
using Optional;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Repositories
{
    public interface ITabRepository
    {
        Task<Option<Tab>> Get(Guid id);
    }
}
