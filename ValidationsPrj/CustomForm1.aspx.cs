using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationsPrj
{
    public partial class CustomForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello");
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
                return;
            }

            int num = Convert.ToInt32(args.Value);

            if (num <= 1)
            {
                args.IsValid = false;
                return;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    args.IsValid = false;
                    return;
                }
            }

            args.IsValid = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblmsg.Text = "Data Validated..., saving now";
                lblmsg.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblmsg.Text = "Validation Failed.., not saving";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
