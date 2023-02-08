using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Order
    {
        public Order()
        {
            Items = new HashSet<Item>();
            TIds = new HashSet<MenuTable>();
        }

        public Guid OId { get; set; }
        public string? OType { get; set; }
        public DateTime? ODate { get; set; }
        public Guid? CId { get; set; }
        public Guid? EId { get; set; }

        public virtual Customer? CIdNavigation { get; set; }
        public virtual Employee? EIdNavigation { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        public virtual ICollection<MenuTable> TIds { get; set; }
    }
}
