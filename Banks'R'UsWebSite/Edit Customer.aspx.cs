using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Edit_Customer : System.Web.UI.Page
{
    SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
    string cusID;
    string cusAddress;
    string cusCity;
    string cusState;
    int cusPINCode;
    string cusPhoneAC;
    string cusPhoneCO;
    string cusPhoneLine;
    string cusEmail;

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
        cusAddress = CusAddress.Text;
        cusCity = CusCity.Text;
        cusState = CusState.Text;
        cusPINCode = Int32.Parse(CusPIN.Text);
        cusPhoneAC = CusPhoneAC.Text;
        cusPhoneCO = CusPhoneCO.Text;
        cusPhoneLine = CusPhoneLine.Text;
        cusEmail = CusEmail.Text;

        try
        {
            dbConnection.Open();

            SqlCommand editCustomer = new SqlCommand("UPDATE CUSTOMER SET "
            + "CUSTOMER_ADDRESS = '" + cusAddress + "',"
            + "CUSTOMER_CITY = '" + cusCity + "',"
            + "CUSTOMER_STATE = '" + cusState + "',"
            + "CUSTOMER_PIN = '" + cusPINCode + "',"
            + "CUSTOMER_AREACODE = '" + cusPhoneAC + "',"
            + "CUSTOMER_CO = '" + cusPhoneCO + "',"
            + "CUSTOMER_Line = '" + cusPhoneLine + "',"
            + "CUSTOMER_EMAIL = '" + cusEmail + "' "
            + "WHERE CUSTOMER_ID = '" + cusID + "';", dbConnection);

            editCustomer.ExecuteNonQuery();
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
	    CusAddress.Text = "";
	    CusCity.Text = "";
	    CusState.Text = "";
	    CusPIN.Text = "";
	    CusPhoneAC.Text = "";
	    CusPhoneCO.Text = "";
	    CusPhoneLine.Text = "";
	    CusEmail.Text = "";
    }
}