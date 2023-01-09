using CoffeeShop.Domain.Views;
using Optional;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Repositories
{
    public interface IUserViewRepository
    {
        Task<IList<UserView>> GetAll();

        Task<Option<UserView>> Get(Guid id);
    }
}
