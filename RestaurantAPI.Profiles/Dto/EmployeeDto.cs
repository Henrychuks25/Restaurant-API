using RestaurantAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public decimal? Salary { get; set; }
        public Guid JobId { get; set; }
        public Job? Job { get; set; } // Assuming JobDto is a DTO representing the Job entity
        [JsonIgnore]
        public List<Food> Foods { get; set; } // Assuming FoodDto is a DTO representing the Food entity
        [JsonIgnore]
        public List<MenuTable> MenuTables { get; set; } // Assuming MenuTableDto is a DTO representing the MenuTable entity
        [JsonIgnore]
        public List<Order> Orders { get; set; } // Assuming OrderDto is a DTO representing the Order entity
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
