using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    private bool managerLogin = false;
    private bool customerLogin = false;

    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
    string userID;
    string password;

    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (Page.IsPostBack)
        {
            userID = UserID.Text;
            password = Password.Text;

            dbConnection.Open();
            SqlCommand getManagerUserID = new SqlCommand("SELECT MANAGER_ID FROM CUSTOMER");
            SqlCommand getCustomerUserID = new SqlCommand("SELECT CUSTOMER_ID FROM CUSTOMER");
            SqlCommand getManagerPassword = new SqlCommand("SELECT MANAGER_PASSWORD FROM CUSTOMER");
            SqlCommand getCustomerPassword = new SqlCommand("SELECT CUSTOMER_PASSWORD FROM CUSTOMER");

            if (userID.Equals("mngr"))
            {
                if(password.Contains(""))
                {
                    managerLogin = true;
                }
                else
                {
                    Response.Write("Your User ID or Password is Incorrect!!! Please input the correct User ID or Password.");
                }
            }
            else if (userID.Equals(""))
            {
                if (password.Contains(""))
                {
                    customerLogin = true;
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
            dbConnection.Close();
        }
    }

    protected void SubmitLogin_Click(object sender, EventArgs e)
    {
        if (managerLogin)
        {
            Response.Redirect("Site Template.aspx");
        }
        else if(customerLogin)
        {
            Response.Redirect("Site Template.aspx");
        }
    }

    protected void ResetLogin_Click(object sender, EventArgs e)
    {
        UserID.Text = "";
        userID = "";
        password = "";
        Password.Text = "";
    }
}