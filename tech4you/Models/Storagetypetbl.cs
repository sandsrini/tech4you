using System;
using System.Collections.Generic;

#nullable disable

namespace tech4you.Models
{
    public partial class Storagetypetbl
    {
        public Storagetypetbl()
        {
            Customizedlaptops = new HashSet<Customizedlaptop>();
        }

        public int Storagetypeid { get; set; }
        public string Storagetypename { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Customizedlaptop> Customizedlaptops { get; set; }
    }
}
