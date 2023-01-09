using CoffeeShop.Domain;
using CoffeeShop.Domain.Views;
using Optional;
using System;

namespace CoffeeShop.Core.OrderContext.Queries
{
    public class GetToGoOrder : IQuery<Option<ToGoOrderView, Error>>
    {
        public Guid Id { get; set; }
    }
}
