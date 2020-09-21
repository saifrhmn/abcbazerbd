using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class Roles
    {
        public Roles()
        {
            AdminLogin = new HashSet<AdminLogin>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AdminLogin> AdminLogin { get; set; }
    }
}
