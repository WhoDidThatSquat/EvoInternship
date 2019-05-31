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
        static readonly SqlConnection _connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=Shop;Trusted_Connection=True;");

        public static List<Product> SortByNameAZ()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name], description, price FROM Product Order by Name ASC", _connection);

            _connection.Open();

            var row = cmd.ExecuteReader();

            while (row.Read())
            {
                Product product = new Product
                {
                    Id = row.GetInt32(0),
                    Name = row.GetString(1),
                    Description = row.GetString(2),
                    Price = row.GetDecimal(3)
                };

                products.Add(product);
            }
            _connection.Close();

            return products;
        }

        public static List<Product> SortByNameZA()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name], description, price FROM Product Order by Name DESC", _connection);

            _connection.Open();

            var row = cmd.ExecuteReader();

            while (row.Read())
            {
                Product product = new Product
                {
                    Id = row.GetInt32(0),
                    Name = row.GetString(1),
                    Description = row.GetString(2),
                    Price = row.GetDecimal(3)
                };

                products.Add(product);
            }
            _connection.Close();

            return products;
        }

        public static List<Product> PriceL2H()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name], description, price FROM Product Order by Price ASC", _connection);

            _connection.Open();

            var row = cmd.ExecuteReader();

            while (row.Read())
            {
                Product product = new Product
                {
                    Id = row.GetInt32(0),
                    Name = row.GetString(1),
                    Description = row.GetString(2),
                    Price = row.GetDecimal(3)
                };

                products.Add(product);
            }
            _connection.Close();

            return products;
        }

        public static List<Product> PriceH2L()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name],description, price FROM Product Order by Price DESC", _connection);

            _connection.Open();

            var row = cmd.ExecuteReader();

            while (row.Read())
            {
                Product product = new Product
                {
                    Id = row.GetInt32(0),
                    Name = row.GetString(1),
                    Description = row.GetString(2),
                    Price = row.GetDecimal(3)
                };

                products.Add(product);
            }
            _connection.Close();

            return products;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT ID, [Name],description, price FROM Product ", _connection);

            _connection.Open();

            var row = cmd.ExecuteReader();

            while (row.Read())
            {
                Product product = new Product
                {
                    Id = row.GetInt32(0),
                    Name = row.GetString(1),
                    Description = row.GetString(2),
                    Price = row.GetDecimal(3)
                };

                products.Add(product);
            }
            _connection.Close();

            return products;
        }

    }
}
