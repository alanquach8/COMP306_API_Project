using System;
using System.Collections.Generic;
using System.Text;

namespace MicroprocessorStoreLibrary
{
    public class Microprocessor
    {
        public Microprocessor()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Availability> Availability { get; set; }
    }
}
