using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Domain;

namespace Shop.Web.Controllers
{
    public class ShopController : Controller
    {

        public ActionResult Products(int? id)
        {
            ViewBag.Title = "Products";
            ViewBag.Message = "List of products:";

            List<Product> products = Infrastructure.ShopSorter.SortByNameAZ();


            // mark selected department

            if (!id.HasValue)
                products.First().Selected = true;
            else
            {
                bool selectedSet = false;

                foreach (var prod in products)
                {
                    if (prod.Id == id)
                    {
                        prod.Selected = true;
                        selectedSet = true;
                        break;
                    }
                }

                if (!selectedSet)
                    products.First().Selected = true;

            }

            return View(products);
        }

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
                    break;
            }

            return View(products);

        }
    }
}