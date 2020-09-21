using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class AdminEmployee
    {
        public AdminEmployee()
        {
            AdminLogin = new HashSet<AdminLogin>();
        }

        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string PhotoPath { get; set; }

        public virtual ICollection<AdminLogin> AdminLogin { get; set; }
    }
}
