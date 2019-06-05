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
        
        public ActionResult SingleShop()
        {
           /* Product product = null;
            static SqlConnection _connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=eShop;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("SELECT id, name, description, price, model, brand FROM Product where id = @ ", _connection);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            _connection.Open();
            var row = cmd.ExecuteReader();
            if (row.Read())
            {
                product = new Product
                {
                    Id = row
                }
            }*/
            return View();
        }
    }
}