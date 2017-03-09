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
    float amount;
    int bankAmount;
    int transactionNum;
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

    protected void StatementDDL_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(StatementDDL.SelectedValue);
    }

    protected void Reset_Click(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        accountNum = int.Parse(AccountNumber.Text);
        amount = float.Parse(Amount.Text);
        transactionNum = rand.Next(1, 99999);

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
                
                bankAmount += (int)amount;
                SqlCommand update = new SqlCommand("UPDATE ACCOUNT SET ACCOUNT_BALANCE=" + bankAmount + " WHERE ACCOUNT_ID =" + accountNum);
                SqlCommand filling = new SqlCommand("INSERT INTO BANK_TRANSACTION VALUES (" + transactionNum + ", " + "CURDATE(), " + amount + ", " + "Deposit, " + accountNum + ");", dbConnection);
                update.ExecuteNonQuery();
                filling.ExecuteNonQuery();
            }
            dbConnection.Close();
        }
        catch (SqlException sqle)
        {
            Response.Write(sqle.Message);
        }
    }
}
