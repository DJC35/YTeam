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
    string output;
    int count = 1;
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
        Output.Text = "";
        output = "";
        accountNumber = int.Parse(AccountNumber.Text);
        numberOfTransactions = int.Parse(NumberOfTransactions.Text);
        minValue = int.Parse(MinimumTransactionValue.Text);
        prom = DateTime.Parse(From.Text);
        tooo = DateTime.Parse(To.Text);
        SqlCommand insert = new SqlCommand("SELECT TOP "+ numberOfTransactions +" * FROM BANK_TRANSACTION WHERE ACCOUNT_ID = " + accountNumber + " AND TRANSACTION_DATE BETWEEN '" + prom + "' AND '" + tooo + "' AND TRANSACTION_AMOUNT >= " + minValue +";", dbConnection);
        
        try
        {
            dbConnection.Open();
            SqlDataReader rd = insert.ExecuteReader();
            if (rd.Read())
            {
                output += ("<table width='100%' border='1'");
                output += ("<tr><th>Transaction_Num</th><th>Date</th><th>Transaction_Amount</th><th>Transacton_Type</th><th>Account_ID</th></tr>");
                    do
                    {
                        output += ("<tr>");
                        output += ("<td>" + rd["Transaction_Num"] + "</td>");
                        output += ("<td>" + rd["Transaction_Date"] + "</td>");
                        output += ("<td>$" + rd["Transaction_Amount"] + "</td>");
                        output += ("<td>" + rd["Transaction_Type"] + "</td>");
                        output += ("<td>" + rd["Account_ID"] + "</td>");
                        output += ("</tr>");
                        count++;
                    }
                    while (rd.Read());
                
                output += ("</table>");
            }
            else
                output += ("You Have No Transactions");
            rd.Close();

        }
        catch (SqlException sqla)
        {
            Response.Write(sqla.Message);
        }
        Output.Text = output;
        dbConnection.Close();

    }
    protected void Reset_Click(object sender, EventArgs e)
    {
        AccountNumber.Text = "";
        Output.Text = "";
        output = "";
    }
}