using System;
using System.Diagnostics;
using BCrypt;
using BCrypt.Net;

namespace LoginScreen
{
    public class User
    {
        public string Username { get; private set; }
        public string PasswordHash { get; set; }

        public User(String username, String password) { 
            Username = username;
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
            
        }

        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, PasswordHash);
        }
    }
}
