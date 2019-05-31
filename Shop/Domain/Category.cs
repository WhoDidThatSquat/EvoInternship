using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models
{
    public class CategoriesViewModel
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
    }
}
