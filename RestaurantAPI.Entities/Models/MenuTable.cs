using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class MenuTable
    {
        public MenuTable()
        {
            Bookings = new HashSet<Booking>();
            OIds = new HashSet<Order>();
        }

        public Guid TId { get; set; }
        public int Capacity { get; set; }
        public Guid EId { get; set; }

        public virtual Employee EIdNavigation { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual ICollection<Order> OIds { get; set; }
    }
}
