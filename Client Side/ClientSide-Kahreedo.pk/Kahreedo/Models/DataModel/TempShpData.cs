using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abcbazarbd_clientside.Models
{
    public static class TempShpData
    {
        public static int UserID { get; set; }
        public static List<OrderDetails> items { get; set; }
    }
}