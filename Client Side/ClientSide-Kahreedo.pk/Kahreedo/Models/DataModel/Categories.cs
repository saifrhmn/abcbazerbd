using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class Categories
    {
        public Categories()
        {
            GenPromoRight = new HashSet<GenPromoRight>();
            Products = new HashSet<Products>();
            SubCategory = new HashSet<SubCategory>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<GenPromoRight> GenPromoRight { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<SubCategory> SubCategory { get; set; }
    }
}
