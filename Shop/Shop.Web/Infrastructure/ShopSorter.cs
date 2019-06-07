using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;

namespace Shop.Web.Infrastructure
{
    public class ShopSorter
    {
        static readonly SqlConnection _connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=eShop;Trusted_Connection=True;");

        public static List<Product> SortByNameAZ()
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

        public static List<Product> SortByNameZA()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name], description, price, imageRefPath FROM Product Order by Name DESC", _connection);

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

        public static List<Product> PriceL2H()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name], description, price, imageRefPath FROM Product Order by Price ASC", _connection);

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

        public static List<Product> PriceH2L()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name],description, price, imageRefPath FROM Product Order by Price DESC", _connection);

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

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name],description, price, imageRefPath FROM Product ", _connection);

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
        public static Product ShowItem(int id)
        {
            Product product = null;
            SqlCommand cmd = new SqlCommand("SELECT id, name, description, price, model, brand, imageRefPath FROM Product where id = @id  ", _connection);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            _connection.Open();
            var row = cmd.ExecuteReader();
            if (row.Read())
            {
                product = new Product
                {
                    Id = row.GetInt32(0),
                    Name = row.GetString(1),
                    Description = row.GetString(2),
                    Price = row.GetDecimal(3),
                    Model = row.GetString(4),
                    Brand = row.GetString(5),
                    ImageRefPath = row.GetString(6)
                };

            }
            _connection.Close();
            return product;
        }

    }
}
