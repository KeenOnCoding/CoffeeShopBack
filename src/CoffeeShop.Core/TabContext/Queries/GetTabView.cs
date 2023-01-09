using CoffeeShop.Domain;
using CoffeeShop.Domain.Views;
using Optional;
using System;

namespace CoffeeShop.Core.TabContext.Queries
{
    public class GetTabView : IQuery<Option<TabView, Error>>
    {
        public Guid Id { get; set; }
    }
}
