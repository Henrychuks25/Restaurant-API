using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class FoodDto
    {
          public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Guid EmployeeId { get; set; }
        public string? EmployeeIdNavigation { get; set; }
        public string? Items { get; set; }

   
    }

    public class CreateFoodDto
    {
        public Guid Id { get; set;}
        public Guid EmployeeId { get; set; }
        public string? Name { get; set;} = null;
        public decimal Price { get; set; }
        

    }

    public class UpdateFoodDto
    {
        public Guid Id { get; set;}
        public string? Name { get; set;}   
        public decimal Price { get; set; }
    }
}
