using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class QueryStringDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            //lblname.Text = Request.QueryString["username"];
            //lblpass.Text = Request.QueryString["password"];

            //2 option
            string temp;
            temp = "Name :" + (Request.QueryString["QS1"].ToString());

            temp += " Password :" + Request.QueryString["QS2"].ToString();

            lblname.Text = temp;
        }
    }
}