using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FinalYearProject
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        SQLliteConnector objsql = new SQLliteConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadRequests();
        }
        public void loadRequests()
        {
            int CompanyID = int.Parse(Session["Company_ID"].ToString());
            DataTable tab = objsql.getTotalTablets(CompanyID);
            if (tab.Rows.Count > 0)
            {
                gvTotal.DataSource = tab;
                gvTotal.DataBind();

            }
            else
            {
                lblMessage.Text = "No Requests Yet";
            }
        }
    }
}