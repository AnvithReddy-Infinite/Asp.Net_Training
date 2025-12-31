using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webservice_Client
{
    public partial class ClientForm : System.Web.UI.Page
    {
        Infinite_Reference.Web_Infinite_ServicesSoapClient client =
            new Infinite_Reference.Web_Infinite_ServicesSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnhello_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.HelloWorld();
        }

        protected void Btnsayhello_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.SayHello(txtname.Text);
        }

        protected void Btnsq_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.Squareroot(Convert.ToSingle(txtfnum.Text)).ToString();
        }
    }
}
