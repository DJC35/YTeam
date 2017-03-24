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
    int depositNum;
    int withdrawNum;
    DateTime date = DateTime.Now;
    Random rand1 = new Random();
    Random rand2 = new Random();

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
        depositNum = rand1.Next(1, 99999);
        withdrawNum = rand2.Next(1, 99999);

        SqlCommand subtraction = new SqlCommand("UPDATE ACCOUNT SET ACCOUNT_BALANCE = ACCOUNT_BALANCE - " + amount + " WHERE ACCOUNT_ID = " + payerID + "; ", dbConnection);
        SqlCommand subtractionFilling = new SqlCommand("INSERT INTO BANK_TRANSACTION VALUES(" + "'" + rand1 + "'" + ", " + "'" + date + "'" + ", " + "'" + amount + "'" + ", " + "'FTSENT', " + "'" + withdrawNum + "'" + ");", dbConnection);
        SqlCommand additionFilling = new SqlCommand("INSERT INTO BANK_TRANSACTION VALUES(" + "'" + rand2 + "'" + ", " + "'" + date + "'" + ", " + "'" + amount + "'" + ", " + "'FTRECIEVE', " + "'" + withdrawNum + "'" + ");", dbConnection);
        SqlCommand addition = new SqlCommand("UPDATE ACCOUNT SET ACCOUNT_BALANCE = ACCOUNT_BALANCE + " + amount + " WHERE ACCOUNT_ID = " + payeeID + "; ", dbConnection);

        try
        {
            dbConnection.Open();
            subtraction.ExecuteNonQuery();
            subtractionFilling.ExecuteNonQuery();
            addition.ExecuteNonQuery();
            additionFilling.ExecuteNonQuery();
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
