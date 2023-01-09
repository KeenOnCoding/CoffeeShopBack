using CoffeeShop.Domain.Entities;
using MediatR;
using Optional;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Repositories
{
    public interface IWaiterRepository
    {
        Task<Option<Waiter>> Get(Guid id);

        Task<Unit> Add(Waiter waiter);
    }
}
