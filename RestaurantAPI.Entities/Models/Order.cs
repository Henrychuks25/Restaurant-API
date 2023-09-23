using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Order
    {
        public Order()
        {
            Items = new HashSet<Item>();
            MenuTables = new HashSet<MenuTable>();
        }

        public Guid Id { get; set; }
        public string? Type { get; set; }
        public DateTime? Date { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? EmployeeId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        public virtual ICollection<MenuTable> MenuTables { get; set; }
    }
}
