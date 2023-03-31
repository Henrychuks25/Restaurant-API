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
        public Guid OrderId { get; set; }
        public Guid FoodId { get; set; }
        public string? ImageUrl { get; set; }
        public string? FoodIdNavigation { get; set; }
        public string? OrderIdNavigation { get; set; }

  
    }
}
