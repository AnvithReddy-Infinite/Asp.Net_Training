using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class QueryStringSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnredirect_Click(object sender, EventArgs e)
        {
            //Response.Redirect("QueryStringDestination.aspx?username=" + txtusername.Text +
            //    "&password=" + txtpass.Text);

            //2 option

            string url;
            url = "QueryStringDestination.aspx?QS1=" + Server.UrlEncode(txtusername.Text);
            url += "&QS2=" + txtpass.Text;
            Response.Redirect(url);

        }
    }
}