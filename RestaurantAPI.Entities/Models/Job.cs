using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Job
    {
        public Job()
        {
            Employees = new HashSet<Employee>();
        }

        public Guid Id { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
