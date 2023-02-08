using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class TableDetail
    {
        public Guid Id { get; set; }
        public int Space { get; set; }
    }
}
