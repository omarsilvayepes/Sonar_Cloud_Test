using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSonnar
{
    internal class UserService
    {
        public bool RegisterUser(string username, string password)
        {
            // Duplicate code for user registration
            // Validation logic
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Username and password are required.");
                return false;
            }

            // User registration logic
            Console.WriteLine($"User '{username}' registered successfully.");
            return true;
        }

        public bool LoginUser(string username, string password)
        {
            // Duplicate code for user login
            // Validation logic
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Username and password are required.");
                return false;
            }

            // User login logic
            Console.WriteLine($"User '{username}' logged in successfully.");
            return true;
        }

    }
    

}
