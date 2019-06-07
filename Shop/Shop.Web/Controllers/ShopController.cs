using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Domain;
using System.Data.SqlClient;

namespace Shop.Web.Controllers
{
    public class ShopController : Controller
    {

       

        public ActionResult Index(string sortby)
        {

            List<Product> products = new List<Product>();

            switch (sortby)
            {
                case "name-a-z":
                    products = Infrastructure.ShopSorter.SortByNameAZ();
                    break;
                case "name-z-a":
                    products = Infrastructure.ShopSorter.SortByNameZA();
                    break;
                case "price-l-h":
                    products = Infrastructure.ShopSorter.PriceL2H();
                    break;
                case "price-h-l":
                    products = Infrastructure.ShopSorter.PriceH2L();
                    break;

                default:
                    products = Infrastructure.ShopSorter.GetProducts();
                    break;

            }
            return View(products);
            

        }
        
        public ActionResult SingleShop(int id)
        {
            
            ViewBag.Message = "SingleShop";
            Product product = Infrastructure.ShopSorter.ShowItem(id);
            return View(product);
     
        }
    }
}