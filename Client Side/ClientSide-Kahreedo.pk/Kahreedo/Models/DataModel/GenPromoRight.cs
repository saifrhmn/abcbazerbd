using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class GenPromoRight
    {
        public int PromoRightId { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
        public string OfferTag { get; set; }
        public string Title { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Categories Category { get; set; }
    }
}
