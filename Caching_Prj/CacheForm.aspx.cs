using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;

namespace Caching_Prj
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetProductsByName("All");

                // Caching
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(30));
                Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);
                Response.Cache.VaryByParams["None"] = true;
            }

            lblmsg.Text = "This Page is cached at : " + DateTime.Now.ToString();
        }

        private void GetProductsByName(string productname)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Infinite;Integrated Security=True"))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("spGetProductByName", con))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Productname", productname);

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
            }
        }

        protected void DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductsByName(DDL.SelectedValue);
        }
    }
}
