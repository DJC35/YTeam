using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class BalanceEnquiry : System.Web.UI.Page
{
    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us ;Integrated Security=true");
    int accountNumber;
    Decimal accountBalance;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CustomerDDL_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(CustomerDDL.SelectedValue);
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        accountNumber = int.Parse(AccountNumber.Text);
        SqlCommand insert = new SqlCommand("SELECT ACCOUNT_BALANCE FROM ACCOUNT WHERE ACCOUNT_ID = " + accountNumber + ";",  dbConnection);
        try
        {
            dbConnection.Open();
            SqlDataReader rd = insert.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read(); // read first row
                accountBalance = rd.GetDecimal(0);
            }
            dbConnection.Close();
        }
        catch (SqlException sqla)
        {
            Response.Write(sqla.Message);
        }
        Output.Text = "Account Balance : $" + accountBalance;
    }
    protected void Reset_Click(object sender, EventArgs e)
    {
        AccountNumber.Text = "";
        Output.Text = "";
    }

    protected void LogoutButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}
