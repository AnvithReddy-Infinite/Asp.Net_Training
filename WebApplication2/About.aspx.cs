using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Txtname.Text = "Welcome to ASP.Net !!";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Txtname.Text = "Hello People !!";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Txtname.Text);
        }
    }
}