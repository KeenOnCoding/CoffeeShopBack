﻿namespace CoffeeShop.Core.ManagerContext.Commands
{
    public class HireManager : ICommand
    {
        public Guid Id { get; set; }

        public string ShortName { get; set; }
    }
}