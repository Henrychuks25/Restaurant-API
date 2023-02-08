using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class Booking
    {
        public DateTime? BDate { get; set; }
        public TimeSpan? BHour { get; set; }
        public Guid CustomerId { get; set; }
        public Guid MenuTableId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual MenuTable MenuTable { get; set; } = null!;
    }
}
