using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class FoodDto
    {
          public Guid FId { get; set; }
        public string? FName { get; set; }
        public decimal FPrice { get; set; }
        public Guid EId { get; set; }
        public string? EIdNavigation { get; set; }
        public string? Items { get; set; }

   
    }
}
