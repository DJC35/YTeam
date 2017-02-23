using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete_Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
	SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=ITP262_Banks_R_Us;Integrated Security=true");
if (Page.IsPostBack)
        {
	    cusID = CusID.Text;
		
	    
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

        SqlCommand deleteCustomer = new SqlCommand("DELETE * WHERE CUSTOMER_ID = " + cusID + ";");

	    dbConnection.Close();
    }

    protected void ResetButton(object sender, EventArgs e)
    {
	CusID.Text = "";
    }
}