using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreClient.Models
{
    public class AddAvailabilityForMicroprocessorVM
    {
        public Microprocessor Microprocessor { get; set; }
        public IEnumerable<Store> AllStores { get; set; }
    }
}
