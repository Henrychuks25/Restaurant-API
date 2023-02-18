using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class EmployeeDto
    {
        public Guid EId { get; set; }
        public string EName { get; set; } = null!;
        public string EPhone { get; set; } = null!;
        public string EAddress { get; set; } = null!;
        public decimal? ESalary { get; set; }
        public Guid JId { get; set; }
        public string JIdNavigation { get; set; } = null!;
        public string Foods { get; set; } = null!;
        public string MenuTables { get; set; } = null!;
        public string Orders { get; set; } = null!;

      
    }
}
