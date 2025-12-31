using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Security_Form_Prj
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(txtlogin.Text, txtpass.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtlogin.Text, false);
            }
            else
            {
                Lblmsg.Text = "Invalid User Name or Password";
            }
        }
    }
}