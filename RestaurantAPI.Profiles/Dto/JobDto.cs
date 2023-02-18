using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class JobDto
    {
         public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Employees { get; set; }

    }
}
