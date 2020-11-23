using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreClient.Models
{
    public class AvailabilityForStore
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Microprocessor Microprocessor { get; set; }
    }
}
