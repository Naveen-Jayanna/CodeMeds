using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalYearProject
{
    public partial class login : System.Web.UI.Page
    {
        SQLliteConnector objsql = new SQLliteConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String encode = Encode_Pass(tbpassword.Text);
            if (objsql.getLogin(tbemail.Text, encode))          // Manufacturer = 1, Warehouse = 2 , Pharmacy = 3
            {
                int type = objsql.getType(tbemail.Text);
                if (type == 1)
                {
                    Session["Company_ID"] = objsql.getCompanyID(tbemail.Text);
                    Response.Redirect("ManuHome.aspx");
                }
                else if (type == 2)
                {
                    String name = tbemail.Text;
                    String ware_name = name.Split('@')[0];
                    Session["Warehouse_Name"] = ware_name;
                    if (ware_name.Equals("Warehouse1"))
                        Session["Warehouse_Id"] = 1;
                    else
                        Session["Warehouse_Id"] = 2;
                    Response.Redirect("WareHome.aspx");
                }
                else
                {
                    Session["Pharmacy_Id"] = objsql.getPharmacyId(tbemail.Text);
                    Response.Redirect("PharHome.aspx");
                }
            }
            else {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Invalid user')", true);
            }
        }
        private string Encode_Pass(string p)          // Encode the password using simple code found online :P Database contains the encoded password
        {
            try
            {
                byte[] encData_byte = new byte[p.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(p);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            } 
        }
    }
}