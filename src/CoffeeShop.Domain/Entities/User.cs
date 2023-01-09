﻿using Microsoft.AspNetCore.Identity;
using System;

namespace CoffeeShop.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
