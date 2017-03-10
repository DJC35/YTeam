using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class CustomizedStatement : Page
{

    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us ;Integrated Security=true");
    int accountNumber;
    int numberOfTransactions;
    int minValue;
    DateTime prom;
    DateTime tooo;

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
        accountNumber = int.Parse(AccountNumber.Text);
        numberOfTransactions = int.Parse(NumberOfTransactions.Text);
        minValue = int.Parse(MinimumTransactionValue.Text);
        prom = DateTime.Parse(From.Text);
        tooo = DateTime.Parse(To.Text);
        SqlCommand insert = new SqlCommand("SELECT * FROM TRANSACTION WHERE ACCOUNT_ID = " + accountNumber + " AND TRANSACTION_DATE BETWEEN" + prom + " AND " + tooo + "AND TRANSACTION_AMOUNT >= " + minValue +");", dbConnection);
        try
        {
            dbConnection.Open();
            SqlDataReader rd = insert.ExecuteReader();
            if (rd.HasRows)
            {
                    while (rd.Read())
                    {
                    if (numberOfTransactions != 0)
                    {
                        string tranNum = rd.GetString(0);
                        DateTime date = rd.GetDateTime(1);
                        string tranAmount = rd.GetString(2);
                        string tranType = rd.GetString(3);
                        string accountID = rd.GetString(4);
                        numberOfTransactions--;
                    }
                    }
                }
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