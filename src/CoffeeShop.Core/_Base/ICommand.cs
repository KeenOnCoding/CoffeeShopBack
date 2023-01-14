﻿using CoffeeShop.Domain;
using MediatR;
using Optional;

namespace CoffeeShop.Core
{
    public interface ICommand : IRequest<Option<Unit, Error>>
    {
    }

    public interface ICommand<TResult> : IRequest<Option<TResult, Error>>
    {
    }
}