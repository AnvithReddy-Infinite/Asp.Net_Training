using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBillingAutomation
{
    public partial class AddElectricityBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUser"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                string consumerNumber = txtConsumerNumber.Text.Trim();
                string consumerName = txtConsumerName.Text.Trim();
                int unitsConsumed = Convert.ToInt32(txtUnitsConsumed.Text.Trim());

                BillValidator validator = new BillValidator();
                string validationMsg = validator.ValidateUnitsConsumed(unitsConsumed);

                if (!string.IsNullOrEmpty(validationMsg))
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = validationMsg;
                    return;
                }

                ElectricityBill bill = new ElectricityBill();
                bill.ConsumerNumber = consumerNumber;   
                bill.ConsumerName = consumerName;
                bill.UnitsConsumed = unitsConsumed;

                ElectricityBoard board = new ElectricityBoard();
                board.CalculateBill(bill);

                board.AddBill(bill);

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Electricity bill added successfully.";

                txtConsumerNumber.Text = "";
                txtConsumerName.Text = "";
                txtUnitsConsumed.Text = "";
            }
            catch (FormatException ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = ex.Message;
            }
            catch (Exception)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Unexpected error occurred. Please try again.";
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