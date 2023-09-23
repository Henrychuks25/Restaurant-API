using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Booking
    {
        public DateTime? Date { get; set; }
        public TimeSpan? Hour { get; set; }
        public Guid CustomerId { get; set; }
        public Guid MenuTableId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual MenuTable MenuTable { get; set; } = null!;
    }
}
