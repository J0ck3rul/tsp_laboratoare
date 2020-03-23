using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab4
{
    public partial class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        [MaxLength(20)]
        public int quantity { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }

        protected OrderDetails() { }
    }
}
