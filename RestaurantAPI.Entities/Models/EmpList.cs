﻿using System;
using System.Collections.Generic;

namespace RestaurantAPI.Entities.Models
{
    public partial class EmpList
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
