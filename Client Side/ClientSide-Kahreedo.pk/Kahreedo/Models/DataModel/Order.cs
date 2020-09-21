using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int? PaymentId { get; set; }
        public int? ShippingId { get; set; }
        public int? Discount { get; set; }
        public int? Taxes { get; set; }
        public int? TotalAmount { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? Dispatched { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public bool? Shipped { get; set; }
        public DateTime? ShippingDate { get; set; }
        public bool? Deliver { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Notes { get; set; }
        public bool? CancelOrder { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ShippingDetails Shipping { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
