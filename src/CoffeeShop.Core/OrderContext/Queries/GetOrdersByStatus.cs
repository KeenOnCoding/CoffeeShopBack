using CoffeeShop.Domain.Entities;
using CoffeeShop.Domain.Views;
using System.Collections.Generic;

namespace CoffeeShop.Core.OrderContext.Queries
{
    public class GetOrdersByStatus : IQuery<IList<ToGoOrderView>>
    {
        public ToGoOrderStatus Status { get; set; }
    }
}
