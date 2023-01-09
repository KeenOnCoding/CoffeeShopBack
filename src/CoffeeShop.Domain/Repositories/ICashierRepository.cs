using CoffeeShop.Domain.Entities;
using MediatR;
using Optional;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Repositories
{
    public interface ICashierRepository
    {
        Task<Option<Cashier>> Get(Guid id);

        Task<Unit> Add(Cashier cashier);
    }
}
