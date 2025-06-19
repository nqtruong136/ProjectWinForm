using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public partial class Product
    {
        public string CodeProduct { get; set; }
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public int TotalPrice { get; set; }
        
    }
}
