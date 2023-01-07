using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Collections.Generic; 

namespace FinalYearProject
{
    public partial class Manufacturer : System.Web.UI.Page
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
            int CompanyID = int.Parse(Session["Company_ID"].ToString());
            ddlTablets.DataSource = objsql.getTabletsByID(CompanyID);
            ddlTablets.DataTextField = "Name";
            ddlTablets.DataValueField = "Name";
            ddlTablets.DataBind();
            ddlTablets.Items.Insert(0, "Select One");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int CompanyID = int.Parse(Session["Company_ID"].ToString());
            String Tablet_name = ddlTablets.Text;
            int Quantity = int.Parse(tbQuantity.Text);
            if (Quantity % 20 != 0)
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('PLEASE CHECK THE AMOUNT OF QUANTITY ENTERED')", true);
                tbQuantity.Text = "";
                loadRequest();
            }
            else
            {
                createHash(CompanyID, Tablet_name,Quantity);
                //String Box_Input = "";
                //for (int i = 0; i < Quantity; i++)
                //    Box_Input += hash;
                //String Box_Hash = generatehash(Box_Input).ToString();
                //int num_boxes = Quantity / 20;
                //objsql.putBoxHash(Box_Hash, num_boxes, hash);
                //ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('SUCCESSFULLY GENERATED')", true);
                //tbQuantity.Text = "";
                //loadRequest();
            }

        }

        protected void createHash(int CompanyID, String Tablet_name,int Quantity)
        {
            //Generate the HashCode for the tablet
            Random rand = new Random();
            String temp = "Tablet Name-" + Tablet_name;
            String Ingredient = objsql.getIngredient(Tablet_name);
            String Price = "Price = " + objsql.getPrice(Tablet_name);
            int yr;
            String Manu_date =  (rand.Next(30) + 1) + "-" + (rand.Next(11) + 1) + "-" + (yr = rand.Next(10) + 2019);
            String Exp_date =  (rand.Next(30) + 1) + "-" + (rand.Next(11) + 1) + "-" + (yr + 1 + rand.Next(5));
            String Pkg_no = "" + rand.Next(100000);
            temp = temp + "==" + "Manufacture Date : " + Manu_date + "==" + "Expiry Date : " + Exp_date + "==" + Ingredient + "==" + "Package Number = " + Pkg_no + "==" + Price + "\n";
            String hash = generatehash(temp).ToString();


            //Generate the HashCode for the Box
            String Box_Input = "";
            for (int i = 0; i < Quantity; i++)
                Box_Input += hash;
            String Box_Hash = generatehash(Box_Input).ToString();
            int num_boxes = Quantity / 20;
            objsql.putBoxHash(Box_Hash, num_boxes);
            objsql.update_Remaining(Tablet_name,num_boxes);
            objsql.putTablets(hash, CompanyID, Tablet_name, Manu_date, Exp_date,Box_Hash,num_boxes);
            //tbQuantity.Text = temp + "=================" + hash;
            ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('SUCCESSFULLY GENERATED')", true);
            tbQuantity.Text = "";
            loadRequest();
        }

        protected long generatehash(String str)
        {
            ArrayList ascii = new ArrayList();
            char[] letters = str.ToCharArray();
            for (int i = 0; i < letters.Length; i++) {
                ascii.Add((int)letters[i]);
            }
            int[] ret = new int[ascii.Count];
            for (int i=0; i < ret.Length; i++) {
                ret[i] = int.Parse(ascii[i].ToString());
            }
            return calculate_hashcode(ret);
    }

        public static long calculate_hashcode(int[] ret) {
        long a = 1, b = 0;
        for (int i = 0; i < ret.Length; i++ )
            b = (b + (a = (a + ret[i]) % (ret[i] = 65521))) % ret[i];
        return b << 16 | a;
    }      
    }
}