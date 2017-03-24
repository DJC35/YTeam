using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class DeleteAccount : System.Web.UI.Page
{
    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us ;Integrated Security=true");
    int accountID;
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

    protected void Submit_Click(object sender, EventArgs e)
    {
        accountID = int.Parse(AccountNumber.Text);
        SqlCommand delete = new SqlCommand("DELETE FROM ACCOUNT WHERE ACCOUNT_ID =" + accountID + "; " , dbConnection);
        try
        {
            dbConnection.Open();
            delete.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch (SqlException sqla)
        {
            Response.Write(sqla.Message);
        }
    }

    protected void Reset_Click(object sender, EventArgs e)
    {
        AccountNumber.Text = "";
    }
}