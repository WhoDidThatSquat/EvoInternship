using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web
{
    public class Product
    {
        public int ID { get; set; }
        public int  CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
