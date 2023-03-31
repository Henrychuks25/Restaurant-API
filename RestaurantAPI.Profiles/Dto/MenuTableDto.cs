using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class MenuTableDto
    {
         public Guid Id { get; set; }
        public int Capacity { get; set; }
        public Guid EmployeeId { get; set; }

        public string? EmployeeIdNavigation { get; set; } = null!; 
        public string? Bookings { get; set; } = null!; 
        public string? OrderIds { get; set; } = null!; 

  
    }
}
