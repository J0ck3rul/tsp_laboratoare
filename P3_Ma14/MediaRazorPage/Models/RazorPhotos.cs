using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRazorPage.Models
{
    public class RazorPhotos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Event { get; set; }
        public string Url { get; set; }
    }

    public class RazorTagsTags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhotoId { get;set; }
    }
}
