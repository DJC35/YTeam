using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Change_Password : System.Web.UI.Page
{
    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
    bool isCustomer = false;

    string idNumber;
    string cusID;
    string managerID;
    string newPassword;

    string readCustomerIDString;
    string readManagerIDString;
    string changeManagerPasswordString;
    string changeCustomerPasswordString;

    SqlCommand changePassword;

    int[] customerIDs;
    int[] managerIDs;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CustomerDDL_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(CustomerDDL.SelectedValue);
    }

    protected void AccountDDL_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(AccountDDL.SelectedValue);
    }

    protected void StatementDDL_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(StatementDDL.SelectedValue);
    }

    protected void ChangePasswords_Click(object sender, EventArgs e)
    {
        

        idNumber = UserID.Text;
        newPassword = NewPassword.Text;

        readCustomerIDString = "SELECT CUSTOMER_ID FROM CUSTOMER;";
        readManagerIDString = "SELECT MANAGER_ID FROM MANAGER;";
        changeManagerPasswordString = "UPDATE MANAGER SET MANAGER_PASSWORD = '" + newPassword + "' WHERE MANAGER_ID = " + managerID + ";";
        changeCustomerPasswordString = "UPDATE CUSTOMER SET CUSTOMER_PASSWORD = '" + newPassword + "' WHERE CUSTOMER_ID = " + cusID + ";";

        try
        {
            SqlCommand readCustomerID = new SqlCommand(readCustomerIDString, dbConnection);
            SqlCommand readManagerID = new SqlCommand(readManagerIDString, dbConnection);
            dbConnection.Open();

            SqlDataReader readCustomerTable = readCustomerID.ExecuteReader();

            int count = 0;

            while (readCustomerTable.Read())
            {
                ++count;
            }
            customerIDs = new int[count];

            count = 0;

            while (readCustomerTable.Read())
            {
                customerIDs[count] = readCustomerTable.GetInt32(count);
                ++count;
            }

            count = 0;

            readCustomerTable.Close();

            SqlDataReader readManagerTable = readManagerID.ExecuteReader();

            while (readManagerTable.Read())
            {
                count++;
            }
            managerIDs = new int[count];

            count = 0;

            while (readManagerTable.Read())
            {
                managerIDs[count] = readManagerTable.GetInt32(count);
                count++;
            }
            
            readManagerTable.Close();

            count = 0;

            for (int i = 0; i <= customerIDs.Length; i++)
            {
                if (idNumber.Equals(customerIDs[i]))
                {
                    isCustomer = true;
                    cusID = ""+customerIDs[i];
                    break;
                }
            }
            for (int i = 0; i <= managerIDs.Length; i++)
            { 
                if (idNumber.Equals("mngr" + managerIDs[i]))
                {
                    isCustomer = false;
                    managerID = ""+managerIDs[i];
                    break;
                }
            }

            if (ConfirmNewPassword.Text.Equals(NewPassword.Text))
            {
                if (isCustomer)
                {
                    cusID = idNumber;
                    changePassword = new SqlCommand(changeCustomerPasswordString, dbConnection);
                }
                else
                {
                    managerID = idNumber;
                    changePassword = new SqlCommand(changeManagerPasswordString, dbConnection);
                }
            }
            changePassword.ExecuteNonQuery();

            dbConnection.Close();

        }
        catch(SqlException sqle)
        {
            Response.Write(sqle.Message);
        }
    }

    protected void ResetForm_Click(object sender, EventArgs e)
    {
        UserID.Text = "";
        NewPassword.Text = "";
        ConfirmNewPassword.Text = "";
    }
}