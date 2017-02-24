using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class NewAccount : System.Web.UI.Page
{

    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us ;Integrated Security=true");
    int cusID;
    int deposit;
    int accountID;
    string accountType;
    Random rand = new Random();

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

    protected void StatmentDDL_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(StatmentDDL.SelectedValue);
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        cusID = int.Parse(CustomerID.Text);
        accountType = AccountType.SelectedValue;
        deposit = int.Parse(IntialDeposit.Text);
        accountID = rand.Next(1, 99999);
        SqlCommand insert = new SqlCommand("INSERT INTO ACCOUNT VALUES(" + accountID + ", " + cusID + ", " + deposit + ", '" + accountType + "');", dbConnection);
        try
        {
            dbConnection.Open();
            insert.ExecuteNonQuery();
            dbConnection.Close();
        }
        catch(SqlException sqla)
        {
            Response.Write(sqla.Message);
        }
    }
}