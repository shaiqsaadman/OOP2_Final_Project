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
    public partial class RegistratrionForm : Form
    {
        public RegistratrionForm()
        {
            InitializeComponent();
        }

        private void SubClicked(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string username = "";
            
            string pass = "";
            string rePass = "";
           

            if (!radioButtonAdmin.Checked && !radioButtonEmployee.Checked && !radioButtonCustomer.Checked)
            {
                errMsg += "Registration Type required.\n";
                hasErr = true;
            }

            if (textBoxRName.Text.Equals(""))
            {
                errMsg += "Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxRName.Text;
            }


            if (textBoxRUsername.Text.Equals(""))
            {
                errMsg += "Username required.\n";
                hasErr = true;
            }
            else
            {
                username = textBoxRUsername.Text;
            }

            if (textBoxPass.Text.Equals(""))
            {
                errMsg += "Password required.\n";
                hasErr = true;
            }
            else
            {
                pass = textBoxPass.Text;
            }

            if (textBoxRePass.Text.Equals(""))
            {
                errMsg += "Re entering Password required.\n";
                hasErr = true;
            }
            else
            {
                rePass = textBoxRePass.Text;
            }

            if (!pass.Equals(rePass))
            {
                errMsg += "Password doesn't match\n";
                hasErr = true;
            }
            

            if (!hasErr)
            {

                string output = String.Format("Account created: \n \n" +
                "name: {0} \n" +
                "username: {1} \n" 
                , name, username);
                rTRegOutput.Text = output;

                if(radioButtonEmployee.Checked)
                {
                    dynamic employee = new
                    {
                        Name = name,
                        Username = username,
                        Password = pass
                    };
                    var result = EmployeeController.AddEmployee(employee);

                    if (result)
                        MessageBox.Show("Employee Added");
                    else
                        MessageBox.Show("Employee Not Added");
                }

                if (radioButtonAdmin.Checked)
                {
                    dynamic admin = new
                    {
                        Name = name,
                        Username = username,
                        Password = pass
                    };
                    var result = AdminController.AddAdmin(admin);

                    if (result)
                        MessageBox.Show("Admin Added");
                    else
                        MessageBox.Show("Admin Not Added");
                }

                if (radioButtonCustomer.Checked)
                {
                    dynamic customer = new
                    {
                        Name = name,
                        Username = username,
                        Password = pass
                    };
                    var result = CustomerController.AddCustomer(customer);

                    if (result)
                        MessageBox.Show("Customer Added");
                    else
                        MessageBox.Show("Customer Not Added");
                }


            }

            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void ResetClicked(object sender, EventArgs e)
        {

            textBoxRName.Text = "";
            textBoxRUsername.Text = "";
            textBoxPass.Text = "";
            textBoxRePass.Text = "";

        }
    }
}
