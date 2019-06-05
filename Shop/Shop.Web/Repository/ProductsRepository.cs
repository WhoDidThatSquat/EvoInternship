using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Repository
{
    public class ProductsRepository
    {
        static SqlConnection _connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=eShop;Trusted_Connection=True;");
        public static Product GetProduct(int id)
        {
            Product product = null;

            SqlCommand cmd = new SqlCommand("SELECT Id, categoryid, name, description, price, brand, model FROM [Product] WHERE id=@id",   _connection);
            cmd.Parameters.Add(new SqlParameter("@id", id));

            _connection.Open();

            var row = cmd.ExecuteReader();

            if(row.Read());
            {

                product=new Product
                {
                    ID = row.GetInt32(0),
                    CategoryID = row.GetInt32(1),
                    Name = row.GetString(2),
                    Description = row.GetString(3),
                
                Brand = row.GetString(5),
                    Model = row.GetString(6),
                };
            }

            _connection.Close();

            return product;


        }
    }
}
