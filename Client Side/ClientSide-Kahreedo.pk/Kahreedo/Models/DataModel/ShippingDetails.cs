using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class ShippingDetails
    {
        public ShippingDetails()
        {
            Order = new HashSet<Order>();
        }

        public int ShippingId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
