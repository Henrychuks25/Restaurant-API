using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Bookings = new HashSet<Booking>();
            Orders = new HashSet<Order>();
        }

        public Guid CId { get; set; }
        public string? CName { get; set; }
        public string? CPhone { get; set; }
        public string? CAddress { get; set; }
        public string? COccupation { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
