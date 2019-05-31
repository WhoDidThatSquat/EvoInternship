using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Infrastructure
{
    public class ShopRepository
    {
        static SqlConnection _connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=eShop;Trusted_Connection=True;");

        public static User GetUserByName(string name)
        {
            SqlCommand cmd = new SqlCommand("SELECT ID, UserName, Password, Email  FROM [User] WHERE UserName = @n ", _connection);
            cmd.Parameters.Add(new SqlParameter("@n", name));

            _connection.Open();

            var row = cmd.ExecuteReader();

            User user = null;

            if (row.Read())
            {
                user = new User
                {
                  
                    UserName = row.GetString(1),
                    Password =row.GetString(2),
                    Role = row.GetString(3)
                };
            }

            _connection.Close();

            return user;
        }

        public static void Membership (User user)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [eShop] (Forename,Surename,Address,Email,Phone,Password,RegistrationDate) VALUES (@forename,@surename,@address,@email,@phone, @password, @RegistrationDate)", _connection);

            cmd.Parameters.Add(new SqlParameter("@forename", user.Forename));
            cmd.Parameters.Add(new SqlParameter("@surename", user.Surename));
            cmd.Parameters.Add(new SqlParameter("@address", user.Address));
            cmd.Parameters.Add(new SqlParameter("@email", user.Email));
            cmd.Parameters.Add(new SqlParameter("@phone", user.Phone));
            cmd.Parameters.Add(new SqlParameter("@password", user.Password));
          

            _connection.Open();

            cmd.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
