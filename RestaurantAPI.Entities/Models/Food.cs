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

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Guid EmployeeId { get; set; }

        public virtual Employee Employees { get; set; } = null!;
        public virtual ICollection<Item> Items { get; set; }
    }
}
