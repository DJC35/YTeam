using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Edit_Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
    string cusID;
        string cusFName;
        string cusLName;
        string cusGender;
        string cusDOB;
        string cusAddress;
        string cusCity;
        string cusState;
        int cusPINCode;
        string cusPhoneAC;
        string cusPhoneCO;
        string cusPhoneLine;
        string cusEmail;
        string cusPassword;
	string cusID;
	
        if (Page.IsPostBack)
        {
	    cusID = CusID.Text;
            cusFName = CusFirstName.Text;
            cusLName = CusLastName.Text;
            cusGender = CusGender.SelectedValue;
            cusDOB = CusDateOfBirth.ToString();
            cusAddress = CusAddress.Text;
            cusCity = CusCity.Text;
            cusState = CusState.Text;
            cusPINCode = Int32.Parse(CusPIN.Text);
            cusPhoneAC = CusPhoneAC.Text;
            cusPhoneCO = CusPhoneCO.Text;
            cusPhoneLine = CusPhoneLine.Text;
            cusEmail = CusEmail.Text;
            cusPassword = CusPassword.Text;
        }
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
	dbConnection.Open();

		SqlCommand editCustomer = new SqlCommand("UPDATE CUSTOMER SET "
		+ "CUSTOMER_ADDRESS = " + cusAddress + ","
		+ "CUSTOMER_CITY = " + cusCity + ","
		+ "CUSTOMER_STATE = " + cusState + ","
		+ "CUSTOMER_PIN = " + cusPINCode + ","
		+ "CUSTOMER_AREACODE = " + cusPhoneAC +","
		+ "CUSTOMER_CO = " + cusPhoneCO + ","
		+ "CUSTOMER_Line = " + cusPhoneLine + ","
		+ "CUSTOMER_EMAIL = " + cusEmail + ","
		+ "WHERE CUSTOMER_ID = " + cusID +";");

    	    dbConnection.Close();
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
	CusPassword.Text = "";
    }
}