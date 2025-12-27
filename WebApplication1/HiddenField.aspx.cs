using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txtusername.Text;
            HiddenField2.Value = txtpass.Text;
            txtusername.Text = string.Empty;
            txtpass.Text = string.Empty;

        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            // lblmessage.Text = HiddenField1.Value +"  " + HiddenField2.Value;

            //to check if data can travel to other page/s using hidden field

            Response.Redirect("TestForm.aspx");
        }
    }
}