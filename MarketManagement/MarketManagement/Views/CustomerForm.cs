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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void buttonSrcSName_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            bool hasErr = false;

            string srcS = "";

            if (textBoxSrcSName.Text.Equals(""))
            {
                errMsg += "Shop Name required.\n";
                hasErr = true;
            }
            else
            {
                srcS = textBoxSrcSName.Text;
            }

            if (!hasErr)
            {
                string name = srcS;
                dynamic shop = ShopController.GetShop(name);
                if (shop != null)
                {
                    string output = string.Format("Shop Details: \n\n" +
                        "Shop Name: {0} \n" +
                        "Shop Type: {1} \n",
                        shop.Name, shop.Type);


                    RTBCForm.Text = output;
                    MessageBox.Show("Shop Found");
                }
                else
                {
                    RTBCForm.Text = "";
                    RTBCForm.Text = "";
                    MessageBox.Show("No shop Found");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }
    }
}
