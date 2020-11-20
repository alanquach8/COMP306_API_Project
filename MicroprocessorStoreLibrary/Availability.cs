using System;
using System.Collections.Generic;
using System.Text;

namespace MicroprocessorStoreLibrary
{
    public class Availability
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int MicroprocessorId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public virtual Store Store { get; set; }
        public virtual Microprocessor Microprocessor { get; set; }
    }
}
