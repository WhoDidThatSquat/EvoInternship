using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Infrastructure
{
    public class Promos
    {
        static SqlConnection _connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=eShop;Trusted_Connection=True;");
    

        public static List<Product> GetProducts()
        {
           

            _connection.Open();
            
            
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT Product.ID, Product.Name ,Product.description, Product.price, Product.brand, Product.model, Product.link, Promotions.Discount FROM Product, Promotions Where [Product].id IN ( [Promotions].IDPromotion) ", _connection);
            var row = cmd.ExecuteReader();
           
            while (row.Read())
            {
                Product product = new Product
                {
                    Id = row.GetInt32(0),
                    Name = row.GetString(1),
                    Description = row.GetString(2),
                    Price = row.GetDecimal(3),
                    Brand=row.GetString(4),
                    Model = row.GetString(5),
                    ImageRefPath= row.GetString(6),
                    Discount=row.GetInt32(7)
                };
                products.Add(product);
                
            }
            _connection.Close();

            
            return products;
        }


       





    }





}
