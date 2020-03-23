using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab4
{
    public partial class Order
    {
        public int OrderId { get; set; }
        [MaxLength(20)]
        public ICollection<Client> Clients { get; set; }

        protected Order() { }
    }
}
