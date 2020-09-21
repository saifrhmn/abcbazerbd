using System;
using System.Collections.Generic;

namespace abcbazarbd_clientside.Models
{
    public partial class AdminLogin
    {
        public int LoginId { get; set; }
        public int EmpId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? RoleType { get; set; }
        public string Notes { get; set; }

        public virtual AdminEmployee Emp { get; set; }
        public virtual Roles RoleTypeNavigation { get; set; }
    }
}
