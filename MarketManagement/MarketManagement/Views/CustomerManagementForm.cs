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
    public partial class CustomerManagementForm : Form
    {
        public CustomerManagementForm()
        {
            InitializeComponent();
        }

        private void buttonAddC_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string username = "";
            string otp = "";

            if (textBoxCName.Text.Equals(""))
            {
                errMsg += "Customer Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxCName.Text;
            }

            if (textBoxCUName.Text.Equals(""))
            {
                errMsg += "Customer Username required.\n";
                hasErr = true;
            }
            else
            {
                username = textBoxCUName.Text;
            }

            if (textBoxCOTP.Text.Equals(""))
            {
                errMsg += "Customer OTP required.\n";
                hasErr = true;
            }
            else
            {
                otp = textBoxCOTP.Text;
            }

            if (!hasErr)
            {
                
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonUpdateC_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string username = "";

            if (textBoxCName.Text.Equals(""))
            {
                errMsg += "Customer Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxCName.Text;
            }

            if (textBoxCUName.Text.Equals(""))
            {
                errMsg += "Customer Username required.\n";
                hasErr = true;
            }
            else
            {
                username = textBoxCUName.Text;
            }

            if (!hasErr)
            {
                var customer = new
                {
                    Name = name,
                    Username = username
                };
                bool result = CustomerController.UpdateCustomer(customer);
                if (result)
                {
                    MessageBox.Show("Customer Updated");
                }
                else
                {
                    MessageBox.Show("Customer not Updated");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonDeleteC_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string username = "";

            if (textBoxCName.Text.Equals(""))
            {
                errMsg += "Customer Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxCName.Text;
            }

            if (textBoxCUName.Text.Equals(""))
            {
                errMsg += "Customer Username required.\n";
                hasErr = true;
            }
            else
            {
                username = textBoxCUName.Text;
            }

           

            if (!hasErr)
            {
                var r = CustomerController.DeleteCustomer(username);
                if (r)
                {
                    textBoxCName.Text = "";
                    textBoxCUName.Text = "";
                    MessageBox.Show("Customer deleted");
                }
                else
                {

                    MessageBox.Show("Customer not deleted");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonSrcC_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string srcC = "";

            if (textBoxSrcC.Text.Equals(""))
            {
                errMsg += "Customer Username required.\n";
                hasErr = true;
            }
            else
            {
                srcC = textBoxSrcC.Text;
            }

            if (!hasErr)
            {
                string username = srcC;
                dynamic customer = CustomerController.GetCustomer(username);
                if (customer != null)
                {
                    textBoxCName.Text = customer.Name;
                    textBoxCUName.Text = customer.Username;
                }
                else
                {

                    textBoxCName.Text = "";
                    textBoxCUName.Text = "";
                    MessageBox.Show("No customer Found");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }
    }
}
