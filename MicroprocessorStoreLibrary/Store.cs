using System;
using System.Collections.Generic;
using System.Text;

namespace MicroprocessorStoreLibrary
{
    public class Store
    {
        public Store()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Availability> Availability { get; set; }
    }
}
