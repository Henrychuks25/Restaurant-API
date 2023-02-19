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
    public class CreateJobDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
    }

    public class UpdateJobDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
    }
}
