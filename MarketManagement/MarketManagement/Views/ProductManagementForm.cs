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
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();
        }

        private void buttonAddP_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string type = "";

            if (textBoxPName.Text.Equals(""))
            {
                errMsg += "Product Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxPName.Text;
            }

            if (textBoxPType.Text.Equals(""))
            {
                errMsg += "Product type required.\n";
                hasErr = true;
            }
            else
            {
                type = textBoxPType.Text;
            }

            

            if (!hasErr)
            {
                MessageBox.Show("Product Added");
            }
            else
            {
                MessageBox.Show(errMsg);
            }

        }

        private void buttonUpdateP_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string type = "";

            if (textBoxPName.Text.Equals(""))
            {
                errMsg += "Product Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxPName.Text;
            }

            if (textBoxPType.Text.Equals(""))
            {
                errMsg += "Product type required.\n";
                hasErr = true;
            }
            else
            {
                type = textBoxPType.Text;
            }

            if (!hasErr)
            {
                var product = new
                {
                    Name = name,
                    Type = type

                };
                bool result = ProductController.UpdateProduct(product);
                if (result)
                {
                    MessageBox.Show("Product Updated");
                }
                else
                {
                    MessageBox.Show("Product not Updated");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void buttonDeleteP_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            bool hasErr = false;

            string name = "";
            string type = "";

            if (textBoxPName.Text.Equals(""))
            {
                errMsg += "Product Name required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxPName.Text;
            }

            if (textBoxPType.Text.Equals(""))
            {
                errMsg += "Product type required.\n";
                hasErr = true;
            }
            else
            {
                type = textBoxPType.Text;
            }


            if (!hasErr)
            {
                var r = ProductController.DeleteProduct(name);
                if (r)
                {
                    textBoxPName.Text = "";
                    textBoxPType.Text = "";
                    MessageBox.Show("Product deleted");
                }
                else
                {

                    MessageBox.Show("Product not deleted");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }

        private void buttonSrcP_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            bool hasErr = false;

            string srcP = "";

            if (textBoxSrcP.Text.Equals(""))
            {
                errMsg += "Product Name required.\n";
                hasErr = true;
            }
            else
            {
                srcP = textBoxSrcP.Text;
            }

            if (!hasErr)
            {
                string name = srcP;
                dynamic product = ProductController.GetProduct(name);
                if (product != null)
                {

                    textBoxPName.Text = product.Name;
                    textBoxPType.Text = product.Type;
                }
                else
                {
                    textBoxPName.Text = "";
                    textBoxPType.Text = "";
                    MessageBox.Show("No product Found");
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }
        }
    }
}
