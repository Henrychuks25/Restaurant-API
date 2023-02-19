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

    public class CreateFoodDto
    {
        public Guid FId { get; set;}
        public Guid UserId { get; set; }
        public string? FName { get; set;} = null;
        public decimal FPrice { get; set; }
        

    }

    public class UpdateFoodDto
    {
        public Guid FId { get; set;}
        public string? FName { get; set;}   
        public decimal FPrice { get; set; }
    }
}
