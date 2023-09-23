using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class MenuTable
    {
        public MenuTable()
        {
            Bookings = new HashSet<Booking>();
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public int Capacity { get; set; }
        public Guid EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
