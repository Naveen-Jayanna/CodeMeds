using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FinalYearProject
{
    public partial class PharRequests : System.Web.UI.Page
    {
        SQLliteConnector objsql = new SQLliteConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadRequests();
        }

        public void loadRequests()
        {
            int pharid = Convert.ToInt32(Session["Pharmacy_Id"].ToString());
            DataTable tab = objsql.getRequestsbyPharID(pharid);
            if (tab.Rows.Count > 0)
            {
                gvRequests.DataSource = tab;
                gvRequests.DataBind();

            }
            else
            {
                lblMessage.Text = "No Requests Yet";
            }
        }
    }
}