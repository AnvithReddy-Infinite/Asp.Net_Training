using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Viewstate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            ViewState["uname"] = txtusername.Text;
            ViewState["pass"] = txtpass.Text;
            txtusername.Text = "";
            txtpass.Text = string.Empty;
        }


        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            // lblmessage.Text = "Your Name is : " + ViewState["uname"].ToString() +
            //      "and your password is : " + ViewState["pass"].ToString();

            //or
            //string u, p;
            //u = ViewState["uname"].ToString();
            //p = ViewState["pass"].ToString();

            //lblmessage.Text = "Your Name is : " + u +
            //    "and your password is : " + p;

            //let us check if data retained by viewstate can travel to other page/s
            Response.Redirect("TestForm.aspx");

        }
    }
}
