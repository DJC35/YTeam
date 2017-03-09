using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class FundTransfer : System.Web.UI.Page
{
    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us ;Integrated Security=true");
    int payerID;
    int payeeID;
    int amount;

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
        payerID = int.Parse(PayersAccountNumber.Text);
        payeeID = int.Parse(PayeesAccountNumber.Text);
        amount = int.Parse(Amount.Text);

        SqlCommand subtraction = new SqlCommand("UPDATE ACCOUNT SET ACCOUNT_BALANCE = ACCOUNT_BALANCE - " + amount + " WHERE ACCOUNT_ID = " + payerID + "; ", dbConnection);
        SqlCommand addition = new SqlCommand("UPDATE ACCOUNT SET ACCOUNT_BALANCE = ACCOUNT_BALANCE + " + amount + " WHERE ACCOUNT_ID = " + payeeID + "; ", dbConnection);

        try
        {
            dbConnection.Open();
            subtraction.ExecuteNonQuery();
            addition.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch (SqlException sqla)
        {
            Response.Write(sqla.Message);
        }
    }

    protected void Reset_Click(object sender, EventArgs e)
    {
        PayersAccountNumber.Text = "";
        PayeesAccountNumber.Text = "";
        Amount.Text = "";
    }
}