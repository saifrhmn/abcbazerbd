using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
            RecentlyViews = new HashSet<RecentlyViews>();
            Review = new HashSet<Review>();
            Wishlist = new HashSet<Wishlist>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? OldPrice { get; set; }
        public string UnitWeight { get; set; }
        public string Size { get; set; }
        public decimal? Discount { get; set; }
        public int? UnitInStock { get; set; }
        public int? UnitOnOrder { get; set; }
        public bool? ProductAvailable { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
        public bool? AddBadge { get; set; }
        public string OfferTitle { get; set; }
        public string OfferBadgeClass { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public string Note { get; set; }

        public virtual Categories Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<RecentlyViews> RecentlyViews { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
