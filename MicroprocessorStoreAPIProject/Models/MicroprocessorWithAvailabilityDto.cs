using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreAPIProject.Models
{
    public class MicroprocessorWithAvailabilityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfAvailability
        {
            get
            {
                return Availability.Count;
            }
        }

        public ICollection<AvailabilityForMicroprocessorsDto> Availability { get; set; }
        = new List<AvailabilityForMicroprocessorsDto>();
    }
}
