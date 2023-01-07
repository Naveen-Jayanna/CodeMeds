using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FinalYearProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SQLliteConnector objsql = new SQLliteConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
             loadRequests();
        }
        public void loadRequests()
        {
            int PharmacyId = int.Parse(Session["Pharmacy_Id"].ToString());
            DataTable tab = objsql.getHistory(PharmacyId);
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