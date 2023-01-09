using CoffeeShop.Domain.Views;
using System.Collections.Generic;

namespace CoffeeShop.Core.AuthContext.Queries
{
    public class GetAllUserAccounts : IQuery<IList<UserView>>
    {
    }
}
