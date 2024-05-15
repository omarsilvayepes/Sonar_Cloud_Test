using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSonnar
{
    internal class UserService
    {
        public bool RegisterUser(string username, string password,
            string email, string firstName, string lastName,
            DateTime dateOfBirth, string p, string postalCode,
            string gender)
        {
            string u1344 = username;
            string unusedVar = "This variable is never used";

            // Duplicate code for user registration
            // Validation logic

            var isvalid=IsValid(username, password,
            email, firstName, lastName,
            dateOfBirth, p, postalCode,
            gender);

            if (string.IsNullOrEmpty(u1344) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Username and password are required.");
                return false;
            }

            // User registration logic
            Console.WriteLine($"User '{username}' registered successfully.");
            return true;

            // Unreachable code
            if (username == "guest")
            {
                Console.WriteLine("This is unreachable code and will never be executed.");
                return false;
            }

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

        public bool IsValid(string username, string password,
            string email, string firstName, string lastName,
            DateTime dateOfBirth, string p, string postalCode,
            string gender)
        {
            if (!string.IsNullOrEmpty(username)){
                if (!string.IsNullOrEmpty(password))
                {
                    if (!string.IsNullOrEmpty(email))
                    {
                        if (!string.IsNullOrEmpty(firstName))
                        {
                            if (!string.IsNullOrEmpty(lastName))
                            {
                                if (!string.IsNullOrEmpty(p))
                                    if (!string.IsNullOrEmpty(postalCode))
                                    {
                                        if (!string.IsNullOrEmpty(gender))
                                        {
                                            if (dateOfBirth.Day > 0)
                                            {
                                                if (dateOfBirth.DayOfWeek > 0)
                                                {
                                                    return true;
                                                }
                                            }
                                        }
                                    }
                            }
                        }
                    }
                }
            }
            return false;
        }

    }
    

}
