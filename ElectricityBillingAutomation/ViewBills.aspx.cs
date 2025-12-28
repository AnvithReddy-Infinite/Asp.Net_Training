using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBillingAutomation
{
    public partial class ViewBills : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUser"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void btnGetBills_Click(object sender, EventArgs e)
        {
            try
            {
                int lastN = Convert.ToInt32(txtLastN.Text.Trim());

                ElectricityBoard board = new ElectricityBoard();
                var billList = board.Generate_N_BillDetails(lastN);

                gvBills.DataSource = billList;
                gvBills.DataBind();

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Bill details retrieved successfully.";
            }
            catch (Exception)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please enter a valid number.";
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }


    }
}