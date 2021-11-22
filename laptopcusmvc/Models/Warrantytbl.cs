using System;
using System.Collections.Generic;

#nullable disable

namespace tech4you.Models
{
    public partial class Warrantytbl
    {
        public Warrantytbl()
        {
            Customizedlaptops = new HashSet<Customizedlaptop>();
        }

        public int Warrantyid { get; set; }
        public string Warrantyperiod { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Customizedlaptop> Customizedlaptops { get; set; }
    }
}
