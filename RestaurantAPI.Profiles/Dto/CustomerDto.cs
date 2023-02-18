using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Profiles.Dto
{
    public class CustomerDto
    {
        public Guid CId { get; set; }
        public string? CName { get; set; }
        public string? CPhone { get; set; }
        public string? CAddress { get; set; }
        public string? COccupation { get; set; }
        public string? BookingName {get; set;}
        public string? Orders {get; set;}


     
    }
}
