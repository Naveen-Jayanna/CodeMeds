using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FinalYearProject
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SQLliteConnector objsql = new SQLliteConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadRequests();
        }
        public void loadRequests()
        {
            String Warehouse_name = Session["Warehouse_Name"].ToString();
            DataTable tab = objsql.getResponse(Warehouse_name);
            if (tab.Rows.Count > 0)
            {
                gvHistory.DataSource = tab;
                gvHistory.DataBind();

            }
            else
            {
                lblMessage.Text = "No Requests Yet";
            }
        }
    }
}