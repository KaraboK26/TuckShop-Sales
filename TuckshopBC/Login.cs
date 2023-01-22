using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuckshopBC
{
    public partial class Login : Form
    {
        Log login = new Log("", "");
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs
            string user = txtUserName.Text;
            string pass = txtPassword.Text;
            
            if (user != String.Empty && pass != String.Empty)
            {
                foreach (User item in User.UserList)
                {
                    if (item.Username == user && item.Password == pass)
                    {
                        MessageBox.Show("You are logged in successfully");
                        MainPage mainPage = new MainPage();
                        mainPage.Show();
                    }
                    else
                    {
                        //show default login error message
                        MessageBox.Show("Login Error!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty");
            }
            
            
        }
    }
}
