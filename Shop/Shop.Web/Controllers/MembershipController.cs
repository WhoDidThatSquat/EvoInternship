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

        [HttpPost]
        public ActionResult CreateUser(int id, string username, string password , string role)
        {
            User user = new User { ID = id, Username = username,  Password = password, Role = role };

            LoginRepository.CreateUser(user);

            return RedirectToAction("Index");

        }
        */
    }
}