using Learning01ADN.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Learning01ADN.Services.Data
{
    public class SecurityDAO
    {
        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        internal bool FindByUser(UserModel user)
        {
            bool success = false;

            string queryString = "SELECT * FROM dbo.Users WHERE username = @UserName AND password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar, 50).Value = user.UserName;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) success = true;
                    else success = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return success;
        }
    }
}