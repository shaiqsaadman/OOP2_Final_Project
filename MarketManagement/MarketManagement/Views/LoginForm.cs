using MarketManagement.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagement.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //new Views.AdminForm().Show();
            string username = textBoxUsername.Text;
            string password = textBoxPass.Text;

            var resultA = AdminController.AuthenticateAdmin(username, password);
            var resultE = EmployeeController.AuthenticateEmployee(username, password);
            var resultC = CustomerController.AuthenticateCustomer(username, password);

            if (resultA !=null)
            {
                new Views.AdminForm().Show();
            }
            else if (resultE != null)
            {
                new Views.EmployeeForm().Show();
            }
            else if (resultC != null)
            {
                new Views.CustomerForm().Show();
            }

            else
                MessageBox.Show("User not Valid");
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            new Views.RegistratrionForm().Show();
        }
    }
}
