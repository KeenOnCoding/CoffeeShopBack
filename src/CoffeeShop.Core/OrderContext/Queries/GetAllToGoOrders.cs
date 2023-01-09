using CoffeeShop.Domain.Views;
using System.Collections.Generic;

namespace CoffeeShop.Core.OrderContext.Queries
{
    public class GetAllToGoOrders : IQuery<IList<ToGoOrderView>>
    {
    }
}
