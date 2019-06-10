using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Web.Infrastructure;

namespace Shop.Web.Controllers
{
    public class MembershipController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(string forename, string surename, string address, string email, int phone, string password)
        {
            User user = new User { Name = forename, Surename = surename, Address = address, Email = email, Phone = phone, Password = password };

            LoginRepository.CreateCustomer(user);

            return RedirectToAction("Index");

        }
       /*   
        
        public ActionResult CreateUser(string username, string password )
        {
            User user = new User { Username = username,  Password = password};

            LoginRepository.CreateUser(user);


        }
        */
        
    }
}