using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Item
    {
        public int Quantity { get; set; }
        public Guid OrderId { get; set; }
        public Guid FoodId { get; set; }
        public string? ImageUrl { get; set; }

        public virtual Food Foods { get; set; } = null!;
        public virtual Order Orders { get; set; } = null!;
    }
}
