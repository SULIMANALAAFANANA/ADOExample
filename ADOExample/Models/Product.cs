using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADOExample.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }
        public string Remarks { get; set; }
    }
}
