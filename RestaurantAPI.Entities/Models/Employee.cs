using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Foods = new HashSet<Food>();
            MenuTables = new HashSet<MenuTable>();
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal? Salary { get; set; }
        public Guid JobId { get; set; }

        public virtual Job Job { get; set; } = null!;
        public virtual ICollection<Food> Foods { get; set; }
        public virtual ICollection<MenuTable> MenuTables { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
