using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace FinalYearProject
{
    public partial class WarehouseRequests : System.Web.UI.Page
    {
        SQLliteConnector objsql = new SQLliteConnector();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadRequests();
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


            DataTable tab = objsql.getRequests(cid);
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

        protected void btnGrant_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            int qty=Convert.ToInt32(gvr.Cells[3].Text);
            int Request_ID = Convert.ToInt32(gvr.Cells[0].Text);
            String Tablet_name = gvr.Cells[2].Text;
            int Present_Quantity = objsql.get_Tablet_Quantity(Tablet_name);

            if (qty <= Present_Quantity)
            {
                objsql.change_quantity(Tablet_name, Present_Quantity - qty);
                DataTable dt_Tablets = objsql.make_Batch_Hash(Tablet_name);
                String Hash_value = "";
                String calculate_Hash = "";
                List<String> Hash_contains = new List<String>();
                List<int> Tablet_ID = new List<int>();
                int required_quantity = qty;
                if (dt_Tablets.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_Tablets.Rows.Count; i++)
                    {
                        if (required_quantity == 0)
                            break;
                        int tablet_count = int.Parse(dt_Tablets.Rows[i]["Num_Boxes"].ToString());
                        if (tablet_count > 0)
                        {
                            if (required_quantity >= tablet_count)
                            {
                                required_quantity -= tablet_count;
                                String hash = dt_Tablets.Rows[i]["Box_Hash"].ToString();
                                Hash_contains.Add(hash);
                                for (int j = 0; j < tablet_count; j++)
                                    calculate_Hash += hash;
                                Tablet_ID.Add(int.Parse(dt_Tablets.Rows[i]["QR_ID"].ToString()));
                            }
                            else
                            {
                                String hash = dt_Tablets.Rows[i]["Box_Hash"].ToString();
                                Hash_contains.Add(hash);
                                int qr_id = int.Parse(dt_Tablets.Rows[i]["QR_ID"].ToString());
                                for (int j = 0; j < tablet_count; j++)
                                    calculate_Hash += hash;
                                objsql.new_tablet_remaining(qr_id,tablet_count-required_quantity);
                            }
                        }
                    }
                }

                Hash_value = string.Join(",", Hash_contains.ToArray());
                String QR_ID = string.Join(",", Tablet_ID.ToArray());
                String get_hash = generatehash(calculate_Hash).ToString();
                objsql.putBatchHash(get_hash, Hash_value);
                objsql.Update_Status(Request_ID);
                objsql.Change_tablet_quantity(QR_ID);
                Response.Redirect("WarehouseRequests.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Not enough quantity in the warehouse. Request for more')", true);
            }

        }
        protected long generatehash(String str)
        {
            ArrayList ascii = new ArrayList();
            char[] letters = str.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                ascii.Add((int)letters[i]);
            }
            int[] ret = new int[ascii.Count];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = int.Parse(ascii[i].ToString());
            }
            return calculate_hashcode(ret);
        }

        public static long calculate_hashcode(int[] ret)
        {
            long a = 1, b = 0;
            for (int i = 0; i < ret.Length; i++)
                b = (b + (a = (a + ret[i]) % (ret[i] = 65521))) % ret[i];
            return b << 16 | a;
        }      

       
    }
}