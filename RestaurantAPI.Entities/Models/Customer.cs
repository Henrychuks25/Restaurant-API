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

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Occupation { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
