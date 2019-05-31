using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Role { get; set; }
    }
}
