﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreClient.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int NumberOfAvailability { get; set; }
        public IEnumerable<AvailabilityForStore> Availability { get; set; }
    }
}
