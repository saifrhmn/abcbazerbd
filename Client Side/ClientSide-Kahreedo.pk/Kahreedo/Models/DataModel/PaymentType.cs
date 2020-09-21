using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            Payment = new HashSet<Payment>();
        }

        public int PayTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
    }
}
