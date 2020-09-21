using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abcbazarbd_clientside.Models
{
    public class TopSoldProduct
    {
        public Products product { get; set; }
        public int CountSold { get; set; }
    }
}