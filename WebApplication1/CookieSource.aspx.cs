using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            //1. using persistent cookie

            //HttpCookie hc = new HttpCookie("OurCookie");
            //hc["d1"] = txtusername.Text;
            //hc["d2"] = txtpass.Text;

            //hc.Expires = DateTime.Now.AddMinutes(2);

            //Response.Cookies.Add(hc);
            //Response.Redirect("CookieDestination.aspx");

            //2. using non persistent cookie

            Response.Cookies["un"].Value = txtusername.Text;
            Response.Cookies["pwd"].Value = txtpass.Text;

            Response.Redirect("CookieDestination.aspx");
        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {

        }
    }
}