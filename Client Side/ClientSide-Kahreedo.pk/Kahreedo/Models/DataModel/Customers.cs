using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Order = new HashSet<Order>();
            RecentlyViews = new HashSet<RecentlyViews>();
            Review = new HashSet<Review>();
            Wishlist = new HashSet<Wishlist>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Organization { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string AltEmail { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Picture { get; set; }
        public string Status { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? Created { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<RecentlyViews> RecentlyViews { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
