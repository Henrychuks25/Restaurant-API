using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Food
    {
        public Food()
        {
            Items = new HashSet<Item>();
        }

        public Guid FId { get; set; }
        public string? FName { get; set; }
        public decimal FPrice { get; set; }
        public Guid EId { get; set; }

        public virtual Employee EIdNavigation { get; set; } = null!;
        public virtual ICollection<Item> Items { get; set; }
    }
}
