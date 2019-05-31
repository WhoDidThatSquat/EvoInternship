using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public bool Selected { get; set; }
        public int Id { get; set; }
        public int CategoryId {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal? Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
       
    }
}
