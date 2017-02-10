<%@ Page Language="C#" %>

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
                    <asp:ListItem Text="New Customer" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Edit Customer" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Delete Customer" Value="3"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="AccountDDL" runat="server" Width="200px" OnSelectedIndexChanged="AccountDDL_SelectedIndexChanged">
                    <asp:ListItem Text="Account Management" Value="0"></asp:ListItem>
                    <asp:ListItem Text="New Account" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Edit Account" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Delete Account" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Deposit" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Withdraw" Value="5"></asp:ListItem>
                    <asp:ListItem Text="Fund Transfer" Value="6"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="StatmentDDL" runat="server" Width="200px" OnSelectedIndexChanged="StatmentDDL_SelectedIndexChanged">
                    <asp:ListItem Text="Statments" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Balance Enquiry" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Mini Statement" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Customized Statement" Value="3"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>  
            <tr>
                <td>
                    <!--Output Area-->
                </td>
                <td>
                    <h3>New Customer</h3>
                    <table>
                        <tr>
                            <td>
                                First Name:
                            </td>
                            <td>
                                <asp:TextBox ID="CusFirstName" runat="server" Width="128px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Last Name:
                            </td>
                            <td>
                                <asp:TextBox ID="CusLastName" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Gender:
                            </td>
                            <td>
                                <asp:TextBox ID="CusGender" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Date of Birth:
                            </td>
                            <td>
                                <asp:TextBox ID="CusDateOfBirth" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Address:
                            </td>
                            <td>
                                <asp:TextBox ID="CusAddress" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                City:
                            </td>
                            <td>
                                <asp:TextBox ID="CusCity" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                State:
                            </td>
                            <td>
                                <asp:TextBox ID="CusState" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                PIN Code:
                            </td>
                            <td>
                                <asp:TextBox ID="CusPIN" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Phone Number:
                            </td>
                            <td>
                                <asp:TextBox ID="CusPhone" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Email Address:
                            </td>
                            <td>
                                <asp:TextBox ID="CusEmail" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Submit" Test="Submit" runat="server" />
                            </td>
                            <td>
                                <asp:Button ID="Reset" Test="Reset" runat="server" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Logout" Text="Logout" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
