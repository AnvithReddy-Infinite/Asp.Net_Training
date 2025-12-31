using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navigation_Prj
{
    public partial class RedirectVsTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            Context.Items.Add("Name", Txtname.Text);
            Context.Items.Add("Email", Txtmail.Text);

            //  Response.Write(Context.Items["Name"].ToString() + " "+
            //      Context.Items["Email"].ToString());

            //navigation options
            //1. redirect
            // Response.Redirect("Page1.aspx"); //this resource is in the same application and server

            //Response.Redirect("https://www.google.com");  //resource in some other server

            //2. server.transfer
            //  Server.Transfer("Page1.aspx");

            // Server.Transfer("https://www.google.com"); cannot move between servers

            //3. server.execute

            Server.Execute("page1.aspx");

            Response.Write("I am back"); // comes back after the executing the second pahe/resource to
            // continue with the first
        }
    }
}