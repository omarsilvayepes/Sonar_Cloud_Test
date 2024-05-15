// See https://aka.ms/new-console-template for more information
using TestSonnar;

Console.WriteLine("Hello, World!");

UserService userService = new UserService();

// Register user
userService.RegisterUser("john_doe", "password123","","","",DateTime.Now,"","","");

// Login user
userService.LoginUser("john_doe", "password123");