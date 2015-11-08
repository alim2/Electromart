using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EntityLayer
{
    public class ProductInfo
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string ArrivalDate { get; set; }
        public string Info { get; set; }
        SqlDataAdapter Adapter { get; set; }
    }
}
