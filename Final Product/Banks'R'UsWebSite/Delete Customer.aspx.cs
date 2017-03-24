using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Delete_Customer : System.Web.UI.Page
{
    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
    string cusID;
	    

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

    protected void SubmitButton(object sender, EventArgs e)
    {
        cusID = CusID.Text;
        try
        {
            dbConnection.Open();

            SqlCommand deleteCustomer = new SqlCommand("DELETE FROM CUSTOMER WHERE CUSTOMER_ID = " + cusID + ";",dbConnection);
            deleteCustomer.ExecuteNonQuery();

            dbConnection.Close();
        }
        catch(SqlException sqle)
        {
            Response.Write(sqle.Message);
        }
    }

    protected void ResetButton(object sender, EventArgs e)
    {
	    CusID.Text = "";
    }

    protected void LogoutButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}