using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreClient.Models
{
    public class AddAvailabilityForStoreVM
    {
        public Store Store { get; set; }
        public IEnumerable<Microprocessor> AllMicroprocessors { get; set; }
    }
}
