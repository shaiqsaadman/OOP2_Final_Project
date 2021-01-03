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
    public partial class ShopManagementForm : Form
    {
        public ShopManagementForm()
        {
            InitializeComponent();
        }

        private void buttonAddS_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            
            string name = "";
            string type = "";

            

            if (textBoxSName.Text.Equals(""))
            {
                errMsg += "Shop Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxSName.Text;
            }

            if (textBoxSType.Text.Equals(""))
            {
                errMsg += "Shop type required.\n";
                hasErr = true;
            }
            else
            {
                type = textBoxSType.Text;
            }

            if (!hasErr)
            {
                MessageBox.Show("Shop Added");
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonUpdateS_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string type = "";

           

            if (textBoxSName.Text.Equals(""))
            {
                errMsg += "Shop Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxSName.Text;
            }

            if (textBoxSType.Text.Equals(""))
            {
                errMsg += "Shop type required.\n";
                hasErr = true;
            }
            else
            {
                type = textBoxSType.Text;
            }

            if (!hasErr)
            {
                var shop = new
                {
                    Name = name,
                    Type = type

                };
                bool result = ShopController.UpdateShop(shop);
                if (result)
                {
                    MessageBox.Show("Shop Updated");
                }
                else
                {
                    MessageBox.Show("Shop not Updated");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonDeleteS_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string type = "";

            if (textBoxSName.Text.Equals(""))
            {
                errMsg += "Shop Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxSName.Text;
            }

            if (textBoxSType.Text.Equals(""))
            {
                errMsg += "Shop type required.\n";
                hasErr = true;
            }
            else
            {
                type = textBoxSType.Text;
            }

            if (!hasErr)
            {
                var r = ShopController.DeleteShop(name);
                if (r)
                {
                    textBoxSName.Text = "";
                    textBoxSType.Text = "";
                    MessageBox.Show("Shop deleted");
                }
                else
                {

                    MessageBox.Show("Shop not deleted");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonSrcS_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string srcS = "";

            if (textBoxSrcS.Text.Equals(""))
            {
                errMsg += "Shop Name required.\n";
                hasErr = true;
            }
            else
            {
                srcS = textBoxSrcS.Text;
            }

            if (!hasErr)
            {
                string name = srcS;
                dynamic shop = ShopController.GetShop(name);
                if (shop != null)
                {
                    
                    textBoxSName.Text = shop.Name;
                    textBoxSType.Text = shop.Type;
                }
                else
                {
                    textBoxSName.Text = "";
                    textBoxSType.Text = "";
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
