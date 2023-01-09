﻿using CoffeeShop.Domain.Views;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Repositories
{
    public interface IBaristaViewRepository
    {
        Task<IList<BaristaView>> GetAll();
    }
}
