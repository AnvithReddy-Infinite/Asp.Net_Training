using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            //1. using prsistent cookie to receive data

            //HttpCookie rc = Request.Cookies["OurCookie"];

            //lblname.Text = rc.Name + " " + rc.Value;   
            // lblpass.Text = rc["d2"];

            //2. using non persistent cookie

            lblname.Text = Request.Cookies["un"].Value.ToString();
            lblpass.Text = Request.Cookies["pwd"].Value.ToString();
        }
    }
}