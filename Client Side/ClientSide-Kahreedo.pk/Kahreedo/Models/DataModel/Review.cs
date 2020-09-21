using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Review1 { get; set; }
        public int? Rate { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}
