using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web
{
    public class User
    {
        public bool Selected { get; set; }
        public string UserName { get; set; }
        public string  Password { get; set; }
        public string Role { get; set; }
        public string Forename { get; set; }
        public string Surename { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string RegistrationDate { get; set; }

    }
}
