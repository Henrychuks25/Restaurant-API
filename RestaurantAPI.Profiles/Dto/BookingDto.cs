using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class BookingDto
    {
          public DateTime BookingDate { get; set; }
        public TimeSpan BookingHour { get; set; }
        public Guid CustomerId { get; set; }
        public Guid MenuTableId { get; set; }
        public string CustomerName {get; set;}
        public string MenuTable {get; set;}

   
    }
}
