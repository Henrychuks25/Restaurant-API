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

        public Guid EId { get; set; }
        public string EName { get; set; } = null!;
        public string EPhone { get; set; } = null!;
        public string EAddress { get; set; } = null!;
        public decimal? ESalary { get; set; }
        public Guid JId { get; set; }

        public virtual Job JIdNavigation { get; set; } = null!;
        public virtual ICollection<Food> Foods { get; set; }
        public virtual ICollection<MenuTable> MenuTables { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
