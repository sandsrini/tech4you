using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tech4you.Models
{
    public partial class Customizedlaptop
    {
        public int Cuslaptopid { get; set; }
        public string Cuslaptopname { get; set; }
        public string Cusbrandname { get; set; }
        public decimal Cusprice { get; set; }
        public string Cusantivirus { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Length must be greater than 5 and less than 30", MinimumLength = 3)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter your name")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Processorid { get; set; }
        public int Displayid { get; set; }
        public int Osid { get; set; }
        public int Storagetypeid { get; set; }
        public int Warrantyid { get; set; }
        public int Quantity { get; set; }
        public decimal? Grandtotal { get; set; }
        public DateTime? Purchasedate { get; set; }
        public string Invoiceid { get; set; }

        public virtual Displaytbl Display { get; set; }
        public virtual Ostbl Os { get; set; }
        public virtual Processortbl Processor { get; set; }
        public virtual Storagetypetbl Storagetype { get; set; }
        public virtual Warrantytbl Warranty { get; set; }
    }
}
