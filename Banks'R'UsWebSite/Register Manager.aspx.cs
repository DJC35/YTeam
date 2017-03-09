using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Register_Manager : System.Web.UI.Page
{
    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
    string managerFName;
    string managerLName;
    string managerEmail;
    string managerPassword;
    int managerID;
    Random rnd = new Random();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton(object sender, EventArgs e)
    {

        managerFName = ManagerFirstName.Text;
        managerLName = ManagerLastName.Text;
        managerEmail = ManagerEmail.Text;
        managerPassword = ManagerPassword.Text;
        managerID = rnd.Next(1, 999);

        try
        {
            dbConnection.Open();

            SqlCommand insertNewCustomer = new SqlCommand("INSERT INTO MANAGER VALUES("
                + managerID + ",'"
                + managerFName + "','"
                + managerLName + "','"
                + managerEmail + "','"
                + managerPassword
                + "');", dbConnection);

            insertNewCustomer.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch (SqlException sqle)
        {
            Response.Write(sqle.Message);
        }
        ManagerData.Text = "Here is your randomized UserID:\n mngr" + managerID;
    }
    protected void ResetButton(object sender, EventArgs e)
    {
        ManagerFirstName.Text = "";
        ManagerLastName.Text = "";
        ManagerEmail.Text = "";
        ManagerPassword.Text = "";
    }

    protected void GoToLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}