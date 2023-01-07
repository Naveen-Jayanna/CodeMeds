using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;

namespace FinalYearProject
{
    public class SQLliteConnector
    {
        //string cs = "server=18.225.27.58;database=CodeMeds;user id=user;password=digitalimage";
        string cs = "server=3.129.184.97;database=codemeds;user id=root;password=swagappi@058";
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataAdapter adp = null;

        public SQLliteConnector()
        {
            con = new MySqlConnection(cs);
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
        }
        public bool getLogin(String user, String pwd)
        {
            cmd.CommandText = "select count(*) from Login where Username ='" + user + "' and Password ='" + pwd + "'";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            int result = Convert.ToInt32(tab.Rows[0][0].ToString());
            return result==1;
        }
        public int getType(String user)                     // Manufacturer = 1, Warehouse = 2 , Pharmacy = 3
        {
            cmd.CommandText = "select Type from Login where Username ='" + user + "'";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            int result = Convert.ToInt32(tab.Rows[0][0].ToString());
            return result;
        }

        public int getCompanyID(String user)                     // Manufacturer = 1, Warehouse = 2 , Pharmacy = 3
        {
            cmd.CommandText = "select Company_ID from Company where Company_Mail ='" + user + "'";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            int result = Convert.ToInt32(tab.Rows[0][0].ToString());
            return result;
        }

        public DataTable getTabletsByID(int id)
        {
            cmd.CommandText = "select * from Tablet_Info where Company_ID ='" + id + "'";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public String getIngredient(String tablet_name)                     
        {
            cmd.CommandText = "select Ingredients from Tablet_Info where Name ='" + tablet_name + "'";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            String result = tab.Rows[0][0].ToString();
            return result;
        }

        public String getPrice(String tablet_name)
        {
            cmd.CommandText = "select Price from Tablet_Info where Name ='" + tablet_name + "'";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            String result = tab.Rows[0][0].ToString();
            return result;
        }

        public void putTablets(String Hash, int Company_ID, String Tablet_Name, String ManuDate, String ExpDate,String Box_Hash,int num_boxes)
        {
            cmd.CommandText = String.Format("Insert INTO Tablet (Hash,Company_ID,Name,Manufacture_Date,Expiry_date,Box_Hash,Num_Boxes) VALUES ('{0}',{1},'{2}','{3}','{4}','{5}',{6})", Hash, Company_ID, Tablet_Name, ManuDate, ExpDate,Box_Hash,num_boxes);
            cmd.ExecuteNonQuery();
        }
        public void putBoxHash(String Box_Hash, int Quantity)
        {
            cmd.CommandText = String.Format("Insert INTO Box (Box_Hash,Remaining) VALUES ('{0}',{1})", Box_Hash, Quantity);
            cmd.ExecuteNonQuery();
        }
        public int getPharmacyId(String user)                     
        {
            cmd.CommandText = "select Pharmacy_Id from Pharmacy where Pharmacy_mail ='" + user + "'";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            int result = Convert.ToInt32(tab.Rows[0][0].ToString());
            return result;
        }
        public DataTable getTablets()
        {
            cmd.CommandText = "select * from Tablet_Info ";
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            String result = tab.Rows[0][0].ToString();
            return tab;
        }
        public void putRequest(int PharmacyId, String Tablet_Name, int Quantity,int Company_ID)
        {
            cmd.CommandText = String.Format("Insert INTO Request (Pharmacy_Id,Tablet_Name,Quantity,Company_ID) VALUES ({0},'{1}',{2},{3})", PharmacyId, Tablet_Name, Quantity, Company_ID);
            cmd.ExecuteNonQuery();
        }

        public DataTable getRequests(int CompanyID)
        {
            cmd.CommandText = String.Format("Select Request_Id,Pharmacy_Id,Tablet_Name,Quantity from Request where Company_ID={0} AND Status=0", CompanyID);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        
        }
        public DataTable getTablets(int CompanyID)
        {
            cmd.CommandText = String.Format("Select Name,Manufacture_Date,Expiry_Date from Tablet where Company_ID={0}", CompanyID);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;

        }

        public int getCompanyId(String name)
        {
            cmd.CommandText = String.Format("Select Company_ID from Tablet_Info where Name ='{0}'", name);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            int result = Convert.ToInt32(tab.Rows[0][0].ToString());
            return result;
        
        }

        public DataTable getRequestsbyPharID(int pharid)
        {
            cmd.CommandText = String.Format("Select Tablet_Name,Quantity from Request where Pharmacy_ID={0} AND Status=0", pharid);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;

        }

        public int get_Tablet_Quantity(String name)
        {
            cmd.CommandText = String.Format("Select Remaining from Tablets_Remaining where Name ='{0}'", name);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            int result = Convert.ToInt32(tab.Rows[0][0].ToString());
            return result;

        }

        public void change_quantity(String Tablet_Name, int Quantity)
        {
            cmd.CommandText = String.Format("Update Tablets_Remaining Set Remaining = {0} Where Name = '{1}'",Quantity, Tablet_Name);
            cmd.ExecuteNonQuery();
        }

        public void Update_Status(int Request_ID)
        {
            cmd.CommandText = String.Format("Update Request Set Status = 1 Where Request_Id = '{0}'", Request_ID);
            cmd.ExecuteNonQuery();
        }

        public DataTable getHistory(int pharid)
        {
            cmd.CommandText = String.Format("Select * from Request where Pharmacy_Id={0}", pharid);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;

        }
        public DataTable getTabletsByWareId(int pharid)
        {
            cmd.CommandText = String.Format("select * from Tablet_Info where Company_ID={0}", pharid);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;

        }

        public void putRequestToCompany(int CompanyID, String Warehouse_Name, String Tablet_Name, int Quantity)
        {
            cmd.CommandText = String.Format("Insert INTO Request_To_Company (Company_ID,Warehouse_Name,Tablet_Name,Quantity) VALUES ({0},'{1}','{2}',{3})", CompanyID, Warehouse_Name, Tablet_Name, Quantity);
            cmd.ExecuteNonQuery();
        }


        public DataTable getRequestsToCompany(int CompanyID)
        {
            cmd.CommandText = String.Format("select * from Request_To_Company where Company_ID={0} AND Status = 0", CompanyID);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;

        }

        public void update_Remaining(String Tablet_Name, int Quantity)
        {
            cmd.CommandText = String.Format("UPDATE Tablets_Remaining SET Remaining = Remaining + {0} WHERE NAME = '{1}' ", Quantity, Tablet_Name);
            cmd.ExecuteNonQuery();
        }
        public void change_status(int Request_ID)
        {
            cmd.CommandText = String.Format("UPDATE Request_To_Company SET Status = 1 WHERE Request_ID = {0} ",Request_ID);
            cmd.ExecuteNonQuery();
        }

        public DataTable getResponse(String Warehouse_Name)
        {
            cmd.CommandText = String.Format("select * from Request_To_Company where Warehouse_Name='{0}'", Warehouse_Name);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable getTotalTablets(int Company_ID)
        {
            cmd.CommandText = String.Format("select * from Tablets_Remaining where Company_ID={0}", Company_ID);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;
        }

        public DataTable make_Batch_Hash(String Tablet_Name)
        {
            cmd.CommandText = String.Format("select * from Tablet where Name='{0}' AND Status = 0", Tablet_Name);
            adp = new MySqlDataAdapter(cmd);
            DataTable tab = new DataTable();
            adp.Fill(tab);
            return tab;

        }

        public void new_tablet_remaining(int QR_ID, int Quantity)
        {
            cmd.CommandText = String.Format("UPDATE Tablet SET Num_Boxes = {1} WHERE QR_ID = {0} ", QR_ID,Quantity);
            cmd.ExecuteNonQuery();
        }

        public void putBatchHash(String Box_Hash, String Contains)
        {
            cmd.CommandText = String.Format("Insert INTO Batch (Hash,Contains) VALUES ('{0}','{1}')", Box_Hash, Contains);
            cmd.ExecuteNonQuery();
        }

        public void Change_tablet_quantity(String QR_ID)
        {
            cmd.CommandText = String.Format("UPDATE Tablet SET Num_Boxes = 0, STATUS=1 WHERE QR_ID IN ({0}) ", QR_ID);
            cmd.ExecuteNonQuery();
        }
     
        
    }
}