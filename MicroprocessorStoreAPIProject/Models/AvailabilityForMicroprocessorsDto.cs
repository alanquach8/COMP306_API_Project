﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreAPIProject.Models
{
    public class AvailabilityForMicroprocessorsDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public StoreDto Store { get; set; }
    }
}
