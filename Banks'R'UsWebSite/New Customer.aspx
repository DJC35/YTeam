<%@ Page Language="C#" AutoEventWireup="true" CodeFile="New Customer.aspx.cs" Inherits="New_Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    .auto-style7 {
        height: 26px;
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
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="AccountDDL" runat="server" Width="200px" OnSelectedIndexChanged="AccountDDL_SelectedIndexChanged">
                    <asp:ListItem Text="Account Management" Value="0"></asp:ListItem>
                    <asp:ListItem Text="New Account" Value="New Account.aspx"></asp:ListItem>
                    <asp:ListItem Text="Edit Account" Value="Edit Account.aspx"></asp:ListItem>
                    <asp:ListItem Text="Delete Account" Value="Delete Account.aspx"></asp:ListItem>
                    <asp:ListItem Text="Deposit" Value="Deposit.aspx"></asp:ListItem>
                    <asp:ListItem Text="Withdraw" Value="Withdraw.aspx"></asp:ListItem>
                    <asp:ListItem Text="Fund Transfer" Value="Fund Transfer.aspx"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="StatementDDL" runat="server" Width="200px" OnSelectedIndexChanged="StatementDDL_SelectedIndexChanged">
                    <asp:ListItem Text="Statements" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Balance Enquiry" Value="Balance Enquiry.aspx"></asp:ListItem>
                    <asp:ListItem Text="Mini Statement" Value="Mini Statement.aspx"></asp:ListItem>
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
                                <asp:DropDownList ID="CusGender" runat="server">
                                    <asp:ListItem Selected="True" Value="M">Male</asp:ListItem>
                                    <asp:ListItem Value="F">Female</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Date of Birth:
                            </td>
                            <td>
                                <asp:Calendar ID="CusDateOfBirth" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="#CC9966" />
                                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                    <SelectorStyle BackColor="#FFCC66" />
                                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                </asp:Calendar>
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
                            <td class="auto-style7">
                                State:
                            </td>
                            <td class="auto-style7">
                                <asp:TextBox ID="CusState" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                PIN Code:
                            </td>
                            <td>
                                <asp:TextBox ID="CusPIN" runat="server" />
                                <!-- ^need to ignore until click button-->
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Phone Number:
                            </td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="CusPhoneAC" runat="server" />
                                        </td>
                                        <td>
                                            -
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CusPhoneCO" runat="server" />
                                        </td>
                                        <td>
                                            -
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CusPhoneLine" runat="server" />
                                        </td>
                                    </tr>
                                </table>
                                
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
                                Password:
                            </td>
                            <td>
                                <asp:TextBox ID="CusPassword" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Submit" Text="Submit" runat="server" OnClick="SubmitButton"/>
                            </td>
                            <td>
                                <asp:Button ID="Reset" Text="Reset" runat="server" OnCLick="ResetButton"/>
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
