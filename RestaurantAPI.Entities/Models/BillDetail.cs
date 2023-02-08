using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class BillDetail
    {
        public Guid Id { get; set; }
        public decimal? Bill { get; set; }
    }
}
