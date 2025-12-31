using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exceptions_Prj
{
    public partial class DbError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Empl.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                ExceptionLoggingDb.WriteErrorLogToDB(ex);
                Lblmsg.Text = "Some Technical Error Occurred. Please visit after sometime..";
            }
        }
    }
}
