﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Web.Infrastructure
{
    public class LoginRepository
    {
        static SqlConnection _connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=eShop;Trusted_Connection=True;");

        public static User GetUserByName(string name)
        {
            SqlCommand cmd = new SqlCommand("SELECT ID, UserName, Password, role  FROM [User] WHERE UserName = @n ", _connection);
            cmd.Parameters.Add(new SqlParameter("@n", name));
            
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            var row = cmd.ExecuteReader();

            User user = null;

            if (row.Read())
            {
                user = new User
                {
                  
                    Username = row.GetString(1),
                    Password =row.GetString(2),
                 
                };
            }

            _connection.Close();

            return user;
        }

        public static void CreateCustomer (User user)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Customer] (Name,Surname,Address,Email,Phone) VALUES (@name,@surename,@address,@email,@phone)", _connection);

            cmd.Parameters.Add(new SqlParameter("@name", user.Name));
            cmd.Parameters.Add(new SqlParameter("@surename", user.Surename));
            cmd.Parameters.Add(new SqlParameter("@address", user.Address));
            cmd.Parameters.Add(new SqlParameter("@email", user.Email));
            cmd.Parameters.Add(new SqlParameter("@phone", user.Phone));

            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            cmd.ExecuteNonQuery();

            _connection.Close();
        }

       /* public static void CreateUser(User user)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (ID,Username,Password,Role) VALUES (@id,@username,@password,@role)", _connection);

            cmd.Parameters.Add(new SqlParameter("@id", user.ID));
            cmd.Parameters.Add(new SqlParameter("@username", user.Username));
            cmd.Parameters.Add(new SqlParameter("@password", user.Password));
            cmd.Parameters.Add(new SqlParameter("@role", user.Role));
            

            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            cmd.ExecuteNonQuery();

            _connection.Close();
        }*/
    }
}
