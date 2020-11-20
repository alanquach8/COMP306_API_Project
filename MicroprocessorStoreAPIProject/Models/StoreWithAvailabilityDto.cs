using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreAPIProject.Models
{
    public class StoreWithAvailabilityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NumberOfAvailability
        {
            get
            {
                return Availability.Count;
            }
        }

        public ICollection<AvailabilityForStoresDto> Availability { get; set; }
        = new List<AvailabilityForStoresDto>();
    }
}
