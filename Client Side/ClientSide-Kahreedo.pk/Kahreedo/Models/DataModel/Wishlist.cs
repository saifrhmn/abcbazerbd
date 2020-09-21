using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class Wishlist
    {
        public int WishlistId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}
