using System;
using System.Collections.Generic;

#nullable disable

namespace tech4you.Models
{
    public partial class Laptoplist
    {
        public int Laptopid { get; set; }
        public string Laptopname { get; set; }
        public string Brandname { get; set; }
        public double? Price { get; set; }
        public string Processor { get; set; }
        public string Display { get; set; }
        public string Graphicscard { get; set; }
        public string Memory { get; set; }
        public string Weight { get; set; }
        public string Os { get; set; }
        public string Storagetype { get; set; }
        public string Productcolor { get; set; }
        public string Antivirus { get; set; }
        public string Warranty { get; set; }
    }
}
