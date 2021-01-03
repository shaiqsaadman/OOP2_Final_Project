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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void buttonSManage_Click(object sender, EventArgs e)
        {
            new Views.ShopManagementForm().Show();
        }

        private void buttonEManage_Click(object sender, EventArgs e)
        {
            new Views.EmployeeManagementForm().Show();
        }
    }
}
