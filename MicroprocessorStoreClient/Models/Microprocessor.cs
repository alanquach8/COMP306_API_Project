using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreClient.Models
{
    public class Microprocessor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfAvailability { get; set; }
        public IEnumerable<AvailabilityForMicroprocessor> Availability { get; set; }
    }
}
