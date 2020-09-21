using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class GenMainSlider
    {
        public int MainSliderId { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
        public string OfferTag { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BtnText { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
