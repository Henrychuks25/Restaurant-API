using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Item
    {
        public int Quantity { get; set; }
        public Guid OId { get; set; }
        public Guid FId { get; set; }

        public virtual Food FIdNavigation { get; set; } = null!;
        public virtual Order OIdNavigation { get; set; } = null!;
    }
}
