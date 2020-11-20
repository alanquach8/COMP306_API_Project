using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreAPIProject.Models
{
    public class AvailabilityDto
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int MicroprocessorId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
