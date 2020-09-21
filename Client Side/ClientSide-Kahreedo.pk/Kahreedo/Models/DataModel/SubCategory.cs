using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Products = new HashSet<Products>();
        }

        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public bool? IsActive { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
