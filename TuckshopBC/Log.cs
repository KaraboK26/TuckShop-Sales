using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TuckshopBC
{
    internal class Log
    {
        string Username, Password;

        public Log(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }


        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validate integer
        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //clear user inputs
        private void ClearTexts(string username, string password)
        {
            username = String.Empty;
            password = String.Empty;
        }

        //method to check if eligible to be logged in
        internal bool IsLoggedIn(string user, string pass)
        {
            //check user name empty
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the user name!");
                return false;
            }
            //check user name is valid type
            else if (StringValidator(user) == true)
            {
                MessageBox.Show("Enter only text here");
                ClearTexts(user, pass);
                return false;
            }
            //check user name is correct
            else
            {
                if (Username != user)
                {
                    MessageBox.Show("User name is incorrect!");
                    ClearTexts(user, pass);
                    return false;
                }
                //check password is empty
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Enter the passowrd!");
                        return false;
                    }
                    //check password is valid
                    else if (IntegerValidator(pass) == true)
                    {
                        MessageBox.Show("Enter only integer here");
                        return false;
                    }
                    //check password is correct
                    else if (Password != pass)
                    {
                        MessageBox.Show("Password is incorrect");
                        return false;
                    }
                    {
                        return true;
                    }
                }
            }
        }
    }
}
