using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuckshopBC
{
    internal class User
    {
        public static List<User> UserList = new List<User>();

        public string Firstname;
        public string LastName;
        public string Username;
        public string Password;
        public string ConfirmPassword;

        public User(string firstname, string lastName, string username, string password, string confirmPassword)
        {
            this.Firstname = firstname;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }

        public static void AddUserToList(User user)
        {
            UserList.Add(user);
        }

    }
}
