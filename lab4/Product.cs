using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab4
{
    public partial class Product
    {
        public int productId { get; set; }
        [MaxLength(20)]
        public ICollection<Order> Orders { get; set; }

        protected Product() { }
    }
}
