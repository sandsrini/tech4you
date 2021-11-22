using System;
using System.Collections.Generic;

#nullable disable

namespace tech4you.Models
{
    public partial class Displaytbl
    {
        public Displaytbl()
        {
            Customizedlaptops = new HashSet<Customizedlaptop>();
        }

        public int Displayid { get; set; }
        public string Displaysize { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Customizedlaptop> Customizedlaptops { get; set; }
    }
}
