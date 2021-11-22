using System;
using System.Collections.Generic;

#nullable disable

namespace tech4you.Models
{
    public partial class Ostbl
    {
        public Ostbl()
        {
            Customizedlaptops = new HashSet<Customizedlaptop>();
        }

        public int Osid { get; set; }
        public string Osname { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Customizedlaptop> Customizedlaptops { get; set; }
    }
}
