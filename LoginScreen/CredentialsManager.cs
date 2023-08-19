using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{
    public class CredentialsManager
    {
        private List<User> acceptedUsers = new List<User>
        {
            new User("Steve", "steve123"),
            new User("Vinodh", "vinodh123"),
            new User("Harvey", "harvey123"),
            new User("Patrick", "patrick123"),
        };  

        public bool Authenticate(string username, string password)
        {
            var user = acceptedUsers.Find(u => u.Username == username);
            if (user != null && user.VerifyPassword(password))
            {
                return true;
            }
            return false;
        }
    }
}
