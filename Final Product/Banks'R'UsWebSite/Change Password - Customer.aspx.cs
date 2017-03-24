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

    string userID;
    string newPassword;
    string password;

    string getID;
    string changeCustomerPasswordString;
    SqlCommand changePassword;

    object[] dbID;
    object[] dbPass;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void CustomerDDL_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(CustomerDDL.SelectedValue);
    }

    protected void ChangePasswords_Click(object sender, EventArgs e)
    {
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
        userID = UserID.Text;
        password = OldPassword.Text;
        newPassword = NewPassword.Text;

        try
        {
            dbConnection.Open();
            SqlCommand getCustomerUserID = new SqlCommand("SELECT CUSTOMER_ID FROM CUSTOMER WHERE CUSTOMER_ID = " + userID + ";", dbConnection);
            SqlCommand getNumIDs;
            SqlCommand changePassword;
            SqlCommand getPassword;
            SqlDataReader getID;
            SqlDataReader getPass;

           
            getNumIDs = new SqlCommand("SELECT COUNT(*) FROM CUSTOMER;", dbConnection);
           
            int numRows = (int)getNumIDs.ExecuteScalar();

            getID = getCustomerUserID.ExecuteReader();

            dbID = new object[numRows];
            dbPass = new object[numRows];

            while (getID.Read())
            {
                getID.GetValues(dbID);
            }
            getID.Close();
            for (int i = 0; i <= numRows; ++i)
            {
                if (userID.Equals(dbID[i].ToString()))
                {
                    changePassword = new SqlCommand("UPDATE CUSTOMER SET CUSTOMER_PASSWORD = '" + newPassword +
                        "' WHERE CUSTOMER_ID = " + dbID[i] + ";", dbConnection);

                    getPassword = new SqlCommand("SELECT CUSTOMER_PASSWORD FROM CUSTOMER WHERE CUSTOMER_ID = " + dbID[i] + ";", dbConnection);
                    getPass = getPassword.ExecuteReader();
                    while (getPass.Read())
                    {
                        getPass.GetValues(dbPass);
                    }
                    getPass.Close();

                    if (password.Contains(dbPass[i].ToString()) && ConfirmNewPassword.Text.Equals(newPassword))
                    {
                        changePassword.ExecuteNonQuery();
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        Response.Write("Your User ID or Password is Incorrect!!! Please input the correct User ID or Password.");
                    }
                }
                else
                {
                    Response.Write("Your User ID or Password is Incorrect!!! Please input the correct User ID or Password.");
                }
            }

            dbConnection.Close();
        }
        catch (SqlException sqle)
        {
            Response.Write(" Exception: " + sqle.Message);
        }
        catch (IndexOutOfRangeException ioore)
        {
            Response.Write(" Exception: " + ioore.Message);
        }
        catch (NullReferenceException nre)
        {
            Response.Write(" Exception: " + nre.Message);
        }
        catch (InvalidOperationException ioe)
        {
            Response.Write(" Exception: " + ioe.Message);
        }


    }

    protected void ResetForm_Click(object sender, EventArgs e)
    {
        UserID.Text = "";
        OldPassword.Text = "";
        NewPassword.Text = "";
        ConfirmNewPassword.Text = "";
    }

    protected void LogoutButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}