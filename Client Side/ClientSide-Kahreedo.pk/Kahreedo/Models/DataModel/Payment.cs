using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Order = new HashSet<Order>();
        }

        public int PaymentId { get; set; }
        public int Type { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? PaymentDateTime { get; set; }

        public virtual PaymentType TypeNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
