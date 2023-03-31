using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class OrderDto
    {
          public Guid Id { get; set; }
        public string? Type { get; set; }
        public DateTime? Date { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? EmployeeId { get; set; }
        public string? CustomerIdNavigation { get; set; }
        public string? EmployeeIdNavigation { get; set; }
        public string? Items { get; set; }
        public string? TableIds { get; set; }

    }
}
