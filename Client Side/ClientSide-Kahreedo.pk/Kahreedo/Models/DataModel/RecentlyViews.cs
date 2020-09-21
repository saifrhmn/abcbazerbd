using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class RecentlyViews
    {
        public int RviewId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime ViewDate { get; set; }
        public string Note { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}
