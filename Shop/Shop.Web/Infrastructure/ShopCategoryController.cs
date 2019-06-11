using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
namespace Shop.Web.Infrastructure
{
    public class ShopCategoryController : Controller
    {
        static readonly SqlConnection _connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=eShop;Trusted_Connection=True;");

        public static List<Product> Catgory()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name], description, price, imageRefPath FROM Product Order by Name ASC", _connection);

            _connection.Open();

            var row = cmd.ExecuteReader();

            while (row.Read())
            {
                Product product = new Product
                {
                    Id = row.GetInt32(0),
                    Name = row.GetString(1),
                    Description = row.GetString(2),
                    Price = row.GetDecimal(3),
                    ImageRefPath = row.GetString(4)
                };

                products.Add(product);
            }
            _connection.Close();

            return products;
        }
    }
}