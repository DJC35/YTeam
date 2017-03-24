<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customized Statement.aspx.cs" Inherits="Customized_Statement" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title>Banks'R'Us</title>    
<style type="text/css">
        .auto-style1 {
            width: 99px;
            height: 77px;
        }
        .auto-style2 {
            height: 77px;
            width: 285px;
        }
        .auto-style3 {
            height: 77px;
            width: 323px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style6 {
            height: 77px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style6">
        <table style="width: 100%; height: 25px;">
            <tr>
                <td class="auto-style1">Banks&#39;R&#39;US</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="CustomerDDL" runat="server" Width="200px" OnSelectedIndexChanged="CustomerDDL_SelectedIndexChanged">
                    <asp:ListItem Text="Customer Management" Value="0"></asp:ListItem>
                    <asp:ListItem Text="New Customer" Value="New Customer.aspx"></asp:ListItem>
                    <asp:ListItem Text="Edit Customer" Value="Edit Customer.aspx"></asp:ListItem>
                    <asp:ListItem Text="Delete Customer" Value="Delete Customer.aspx"></asp:ListItem>
                    <asp:ListItem Text="Change Password" Value="Change Password.aspx"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="AccountDDL" runat="server" Width="200px" OnSelectedIndexChanged="AccountDDL_SelectedIndexChanged">
                    <asp:ListItem Text="Account Management" Value="0"></asp:ListItem>
                    <asp:ListItem Text="New Account" Value="NewAccount.aspx"></asp:ListItem>
                    <asp:ListItem Text="Edit Account" Value="EditAccount.aspx"></asp:ListItem>
                    <asp:ListItem Text="Delete Account" Value="DeleteAccount.aspx"></asp:ListItem>
                    <asp:ListItem Text="Deposit" Value="Deposit.aspx"></asp:ListItem>
                    <asp:ListItem Text="Withdraw" Value="Withdraw.aspx"></asp:ListItem>
                    <asp:ListItem Text="Fund Transfer" Value="FundTransfer.aspx"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="StatementDDL" runat="server" Width="200px" OnSelectedIndexChanged="StatementDDL_SelectedIndexChanged">
                    <asp:ListItem Text="Statements" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Balance Enquiry" Value="BalanceEnquiry.aspx"></asp:ListItem>
                    <asp:ListItem Text="Mini Statement" Value="MiniStatement.aspx"></asp:ListItem>
                    <asp:ListItem Text="Customized Statement" Value="Customized Statement.aspx"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="GoToPage" Text="Go" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <!--Output Area-->
                </td>
                <td>
                    <h3>Customized Statment</h3>
                    <table>
                        <tr>
                            <td>
                                Account Number
                            </td>
                            <td>
                                <input id="AccountNumber" type="text" />
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                From
                            </td>
                            <td>
                                <input id="From" type="text" /><input id="calanderRevel" type="button" value="Revel" />
                                <asp:Calendar ID="CalendarFrom" runat="server" Visible="False"></asp:Calendar>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                To
                            </td>
                            <td>
                                <input id="To" type="text" /><input id="calanderReveal" type="button" value="Reveal" />
                                <asp:Calendar ID="CalendarTo" runat="server" Visible="False"></asp:Calendar>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Minimum Transaction Value
                            </td>
                            <td>
                                <input id="MinimumTransactionValue" type="text" /> 
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Number Of Transactions
                            </td>
                            <td>
                                <input id="NumberOfTransactions" type="text" />
                            </td>
                        </tr>                                                
                        <tr>
                            <td>
                                <input id="Submit" type="button" value="Submit" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <input id="Reset" type="button" value="Reset" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Logout" Text="Logout" runat="server"  OnClick="LogoutButton_Click"/>
                </td>
            </tr>
        </table>
        </div>
        </form>
</body>
</html>
