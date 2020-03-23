using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Lab4
{
    public partial class Client
    {
            public int ClientId { get; set; }
            [MaxLength(20)]
            public string Name { get; set; }
            [MaxLength(50)]
            public string Email { get; set; }
            // 0 = inregistrare corecta; 1 = inregistrare stearsa
            //public int Deleted { get; set; }
            public ICollection<Order> Orders { get; set; }
            protected Client() { }
    }
}
