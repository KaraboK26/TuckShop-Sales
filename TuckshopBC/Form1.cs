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
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != String.Empty && txtLastName.Text != String.Empty && txtUserName.Text != String.Empty && txtPassword.Text != String.Empty && txtConfirmPassword.Text != String.Empty && txtConfirmPassword.Text == txtPassword.Text)
            {               
                User user = new User(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, txtConfirmPassword.Text);
                User.AddUserToList(user);
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Fields cannot be empty!! or password don't match");
            }
        }
    }
}
