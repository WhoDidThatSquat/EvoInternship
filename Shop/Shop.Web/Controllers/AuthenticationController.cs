using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Web.Infrastructure;


namespace Shop.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpPost]
        public ActionResult Login(string userName, string password,string Role)
        {
            User user  = LoginRepository.GetUserByName(userName);

            if (user == null || user.Password.ToString() != password)
            {
                HttpContext.Session.Set("name", null);
                ViewBag.message = "Parola sau Nume incorect!";

                return View("Login");
            }
            else
            {
              
                HttpContext.Session.Set("user",null);
                return RedirectToAction("Index", "Home");
              
            }
        }

        public ActionResult Login()
        {
            return View();
        }
       
    }
}
