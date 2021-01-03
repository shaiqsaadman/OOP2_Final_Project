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
    public partial class EmployeeManagementForm : Form
    {
        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        private void buttonAddE_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string username = "";
            string otp = "";

            if (textBoxEName.Text.Equals(""))
            {
                errMsg += "Employee Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxEName.Text;
            }

            if (textBoxEUName.Text.Equals(""))
            {
                errMsg += "Employee Username required.\n";
                hasErr = true;
            }
            else
            {
                username = textBoxEUName.Text;
            }
            if (textBoxEOTP.Text.Equals(""))
            {
                errMsg += "Employee OTP required.\n";
                hasErr = true;
            }
            else
            {
                otp = textBoxEOTP.Text;
            }

            if (!hasErr)
            {
                MessageBox.Show("Employee Added");
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void buttonUpdateE_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string username = "";

            if (textBoxEName.Text.Equals(""))
            {
                errMsg += "Employee Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxEName.Text;
            }

            if (textBoxEUName.Text.Equals(""))
            {
                errMsg += "Employee Username required.\n";
                hasErr = true;
            }
            else
            {
                username = textBoxEUName.Text;
            }
            

            if (!hasErr)
            {
                var employee = new
                {
                    Name = name,
                    Username = username
                };
                bool result = EmployeeController.UpdateEmployee(employee);
                if(result)
                {
                    MessageBox.Show("Employee Updated");
                }
                else
                {
                    MessageBox.Show("Employee not Updated");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonDeleteE_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string username = "";

            if (textBoxEName.Text.Equals(""))
            {
                errMsg += "Employee Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxEName.Text;
            }

            if (textBoxEUName.Text.Equals(""))
            {
                errMsg += "Employee Username required.\n";
                hasErr = true;
            }
            else
            {
                username = textBoxEUName.Text;
            }
            

            if (!hasErr)
            {
                var r = EmployeeController.DeleteEmployee(username);
                if(r)
                {
                    textBoxEName.Text = "";
                    textBoxEUName.Text = "";
                    MessageBox.Show("Employee deleted");
                }
                else
                {
                    
                    MessageBox.Show("Employee not deleted");
                }
                    
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonSrcE_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string srcE = "";

            if (textBoxSrcE.Text.Equals(""))
            {
                errMsg += "Employee Username required.\n";
                hasErr = true;
            }
            else
            {
                srcE = textBoxSrcE.Text;
            }

            if (!hasErr)
            {
                string username = srcE;
                dynamic employee = EmployeeController.GetEmployee(username);
                if (employee != null)
                {
                    textBoxEName.Text = employee.Name;
                    textBoxEUName.Text = employee.Username;
                }
                else
                {
                    
                    textBoxEName.Text = "";
                    textBoxEUName.Text = "";
                    MessageBox.Show("No employee Found");
                }

            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }
    }
}
