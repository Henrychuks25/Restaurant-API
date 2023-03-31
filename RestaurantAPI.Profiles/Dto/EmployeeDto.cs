using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal? Salary { get; set; }
        public Guid JobId { get; set; }
        public string JobIdNavigation { get; set; } = null!;
        public string Foods { get; set; } = null!;
        public string MenuTables { get; set; } = null!;
        public string Orders { get; set; } = null!;

      
    }

    public class CreateEmployeeDto
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal? ESalary { get; set; }


    }

    public class UpdateEmployeeDto
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal? Salary { get; set; }


    }
}
