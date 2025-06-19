using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Product
    {
        public string CodeProduct { get; set; }
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
