using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FinalYearProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SQLliteConnector objsql = new SQLliteConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadRequests();
            }
        }

        public void loadRequests()
        {
            String Name = Session["Warehouse_Name"].ToString();
            int cid;
            if (Name.Equals("Warehouse1"))
            {
                cid = 1;
            }
            else
                cid = 2;


            DataTable tab = objsql.getTablets(cid);
            if (tab.Rows.Count > 0)
            {
                gvRequests.DataSource = tab;
                gvRequests.DataBind();

            }
            else 
            {
                lblMessage.Text = "No Tablets Generated Yet";
            }
        }
    }
}