﻿using FluentValidation;

namespace CoffeeShop.Core.AuthContext.Commands
{
    public class AssignManagerToAccountValidator : AbstractValidator<AssignManagerToAccount>
    {
        public AssignManagerToAccountValidator()
        {
            RuleFor(c => c.AccountId).NotEmpty();
            RuleFor(c => c.ManagerId).NotEmpty();
        }
    }
}