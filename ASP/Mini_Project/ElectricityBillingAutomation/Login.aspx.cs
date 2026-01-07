using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBillingAutomation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string adminUser = txtAdminUser.Text.Trim();
            string adminPass = txtAdminPass.Text.Trim();

            if (adminUser == "anvith" && adminPass == "anvith123")
            {
                Session["AdminUser"] = adminUser;
                Response.Redirect("AddElectricityBill.aspx");
            }

            else
            {
                lblLoginMsg.ForeColor = System.Drawing.Color.Red;
                lblLoginMsg.Text = "Invalid username or password.";
            }
        }

    }
}