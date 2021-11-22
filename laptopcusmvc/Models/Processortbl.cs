using System;
using System.Collections.Generic;

#nullable disable

namespace tech4you.Models
{
    public partial class Processortbl
    {
        public Processortbl()
        {
            Customizedlaptops = new HashSet<Customizedlaptop>();
        }

        public int Processorid { get; set; }
        public string Processorname { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Customizedlaptop> Customizedlaptops { get; set; }
    }
}
