using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class ResMenu
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
