using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class ItemDto
    {
        public int Quantity { get; set; }
        public Guid OId { get; set; }
        public Guid FId { get; set; }
        public string? ImageUrl { get; set; }
        public string? FIdNavigation { get; set; }
        public string? OIdNavigation { get; set; }

  
    }
}
