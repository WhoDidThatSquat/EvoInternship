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
        public ActionResult CreateUser(string forename, string surename, string address, string email, int phone, string password)
        {
            User user = new User { Forename = forename, Surename = surename, Address = address, Email = email, Phone = phone, Password = password };

            ShopRepository.Membership(user);

            return RedirectToAction("Index");

        }
    }
}