using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalYearProject
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SQLliteConnector objsql = new SQLliteConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadRequest();
            }

        }

        private void loadRequest()
        {
            int WarehouseId = int.Parse(Session["Warehouse_Id"].ToString());
            ddlTablets.DataSource = objsql.getTabletsByWareId(WarehouseId);
            ddlTablets.DataTextField = "Name";
            ddlTablets.DataValueField = "Name";
            ddlTablets.DataBind();
            ddlTablets.Items.Insert(0, "Select One");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int WarehouseId = int.Parse(Session["Warehouse_Id"].ToString());
            String Tablet_name = ddlTablets.Text;
            int Quantity = int.Parse(tbQuantity.Text);
            if (Quantity <= 0)
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('QUANTITY SHOULD BE POSITIVE')", true);
                tbQuantity.Text = "";
                loadRequest();
            }
            else
            {
                int Company_ID;
                Company_ID = WarehouseId;
                String warehouse_name = Session["Warehouse_Name"].ToString();
                objsql.putRequestToCompany(Company_ID, warehouse_name, Tablet_name, Quantity);
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('REQUEST SUCCESSFUL')", true);
                tbQuantity.Text = "";
                loadRequest();
            }
        }
    }
}