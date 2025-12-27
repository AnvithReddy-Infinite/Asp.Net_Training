using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetValidationAssignment
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProducts.Items.Add("Select Product");
                ddlProducts.Items.Add("Wireless Mouse");
                ddlProducts.Items.Add("USB Keyboard");
                ddlProducts.Items.Add("Headphones");
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = ddlProducts.SelectedItem.Text;

            if (selectedProduct == "Wireless Mouse")
            {
                imgProduct.ImageUrl = "~/Images/mouse.jpg";
            }
            else if (selectedProduct == "USB Keyboard")
            {
                imgProduct.ImageUrl = "~/Images/keyboard.jpg";
            }
            else if (selectedProduct == "Headphones")
            {
                imgProduct.ImageUrl = "~/Images/headphones.jpg";
            }
            else
            {
                imgProduct.ImageUrl = "";
            }

            lblProductPrice.Text = "";
        }

        protected void btnShowPrice_Click(object sender, EventArgs e)
        {
            string selectedProduct = ddlProducts.SelectedItem.Text;

            if (selectedProduct == "Wireless Mouse")
            {
                lblProductPrice.Text = "Price: ₹799";
            }
            else if (selectedProduct == "USB Keyboard")
            {
                lblProductPrice.Text = "Price: ₹999";
            }
            else if (selectedProduct == "Headphones")
            {
                lblProductPrice.Text = "Price: ₹1499";
            }
            else
            {
                lblProductPrice.Text = "Please select a product to view price.";
            }
        }



    }
}