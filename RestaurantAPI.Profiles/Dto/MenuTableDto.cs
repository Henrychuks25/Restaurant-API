using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class MenuTableDto
    {
         public Guid TId { get; set; }
        public int Capacity { get; set; }
        public Guid EId { get; set; }

        public string? EIdNavigation { get; set; } = null!; 
        public string? Bookings { get; set; } = null!; 
        public string? OIds { get; set; } = null!; 

  
    }
}
