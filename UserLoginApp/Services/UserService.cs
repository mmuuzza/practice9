using System;
using UserLoginApp.Services;
using UserLoginApp.Models;

class Program
{
    static void Main(string[] args)
    {
        // Register a new user
        UserService.RegisterUser("jane_doe", "jane.doe@example.com", "securePassword");

        // Authenticate the user
        var authenticatedUser = UserService.Authenticate("jane_doe", "securePassword");

        if (authenticatedUser != null)
        {
            Console.WriteLine($"Welcome {authenticatedUser.Username}!");
        }
        else
        {
            Console.WriteLine("Authentication failed. Invalid username or password.");
        }

        // Retrieve and display all users
        var allUsers = UserService.GetAllUsers();
        foreach (var user in allUsers)
        {
            Console.WriteLine($"Username: {user.Username}, Email: {user.Email}");
        }
    }
}