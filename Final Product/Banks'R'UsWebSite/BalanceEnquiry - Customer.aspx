<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BalanceEnquiry - Customer.aspx.cs" Inherits="BalanceEnquiry" %>

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
                <td class="auto-style4">
                    <asp:DropDownList ID="CustomerDDL" runat="server" Width="200px" OnSelectedIndexChanged="CustomerDDL_SelectedIndexChanged">
                    <asp:ListItem Text="Statements" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Balance Enquiry" Value="BalanceEnquiry - Customer.aspx"></asp:ListItem>
                    <asp:ListItem Text="Mini Statement" Value="MiniStatement - Customer.aspx"></asp:ListItem>
                    <asp:ListItem Text="Customized Statement" Value="Customized Statement - Customer.aspx"></asp:ListItem>
                    <asp:ListItem Text="Change Password" Value="Change Password - Customer.aspx"></asp:ListItem>
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
                    <h3>Balance Enquiry</h3>
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
