using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class OrderDto
    {
          public Guid OId { get; set; }
        public string? OType { get; set; }
        public DateTime? ODate { get; set; }
        public Guid? CId { get; set; }
        public Guid? EId { get; set; }
        public string? CIdNavigation { get; set; }
        public string? EIdNavigation { get; set; }
        public string? Items { get; set; }
        public string? TIds { get; set; }

    }
}
