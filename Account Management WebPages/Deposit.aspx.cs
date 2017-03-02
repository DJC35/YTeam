using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Deposit : Page
{
    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
    int accountNum;
    int amount;
    int bankAmount;

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

    protected void Reset_Click(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        accountNum = int.Parse(AccountNumber.Text);
        amount = int.Parse(Amount.Text);

        SqlCommand select = new SqlCommand("SELECT ACCOUNT_BALANCE FROM ACCOUNT WHERE ACCOUNT_ID = " + accountNum);
        try
        {
            dbConnection.Open();
            select.ExecuteNonQuery();
            SqlDataReader reader = select.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                bankAmount = reader.GetInt32(0);
                
                bankAmount += amount;
                SqlCommand update = new SqlCommand("UPDATE ACCOUNT SET ACCOUNT_BALANCE=" + bankAmount + " WHERE ACCOUNT_ID =" + accountNum);
                update.ExecuteNonQuery();
                
            }
            dbConnection.Close();
        }
        catch (SqlException sqle)
        {
            Response.Write(sqle.Message);
        }
    }
}