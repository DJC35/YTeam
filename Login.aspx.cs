using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{    
    string userID;
    string userIDPrefix;
    string password;
    object[] dbID;
    object[] dbPass;
    string addOnMessage;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitLogin_Click(object sender, EventArgs e)
    {
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
        userID = UserID.Text;
        userIDPrefix = UserIDPrefix.Text;
        password = Password.Text;
        try
        {
            dbConnection.Open();
            SqlCommand getManagerUserID = new SqlCommand("SELECT MANAGER_ID FROM MANAGER WHERE MANAGER_ID = " + userID + ";", dbConnection);
            SqlCommand getCustomerUserID = new SqlCommand("SELECT CUSTOMER_ID FROM CUSTOMER WHERE CUSTOMER_ID = " + userID + ";",dbConnection);
            SqlCommand getNumIDs;
            SqlCommand getPassword;
            SqlDataReader getID;
            SqlDataReader getPass;
        
            if (userIDPrefix.Contains("mngr"))
            {
                getNumIDs = new SqlCommand("SELECT COUNT(*) FROM MANAGER;", dbConnection);
            }
            else
            {
                getNumIDs = new SqlCommand("SELECT COUNT(*) FROM CUSTOMER;", dbConnection);
            }
            int numRows = (int)getNumIDs.ExecuteScalar();

            if (userIDPrefix.Contains("mngr"))
            {
                getID = getManagerUserID.ExecuteReader();
            }
            else
            {
                getID = getCustomerUserID.ExecuteReader();
            }
            dbID = new object[numRows];
            dbPass = new object[numRows];
            while (getID.Read())
            {
                getID.GetValues(dbID);
            }
            getID.Close();
            for (int i = 0; i <= numRows; ++i)
            {

                //dbID[i] = getID.GetInt32(i);
                if ((userIDPrefix.Contains("mngr")) && (userID.Equals(dbID[i].ToString())))
                {
                    getPassword = new SqlCommand("SELECT MANAGER_PASSWORD FROM MANAGER WHERE MANAGER_ID = " + dbID[i] + ";",dbConnection);
                    getPass = getPassword.ExecuteReader();
                    while (getPass.Read())
                    {
                        getPass.GetValues(dbPass);
                    }
                    getPass.Close();

                    if (password.Contains(dbPass[i].ToString()))
                    {
                        Response.Redirect("New Customer.aspx");
                    }
                    else
                    {
                        Response.Write("Your User ID or Password is Incorrect!!! Please input the correct User ID or Password.");
                    }
                    
                }
                else if (userID.Equals(dbID[i].ToString()))
                {
                    getPassword = new SqlCommand("SELECT CUSTOMER_PASSWORD FROM CUSTOMER WHERE CUSTOMER_ID = " + dbID[i] + ";",dbConnection);
                    getPass = getPassword.ExecuteReader();
                    while (getPass.Read())
                    {
                        getPass.GetValues(dbPass);
                    }
                    getPass.Close();
                    if (password.Contains(dbPass[i].ToString()))
                    {
                        Response.Redirect("Customized Statement.aspx");
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

    protected void ResetLogin_Click(object sender, EventArgs e)
    {
        UserID.Text = "";
        UserIDPrefix.Text = "";
        Password.Text = "";
        userIDPrefix = "";
        userID = "";
        password = "";
    }
}