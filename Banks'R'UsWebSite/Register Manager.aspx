<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register Manager.aspx.cs" Inherits="Register_Manager" %>

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
                <td>
                    <asp:Button ID="GoToLogin" Text="Login" runat="server" OnClick="GoToLogin_Click"/>
                </td>
            </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                Your ID:
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="ManagerData" runat="server" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <h3>New Manager</h3>
                    <table>
                        <tr>
                            <td>
                                First Name:
                            </td>
                            <td>
                                <asp:TextBox ID="ManagerFirstName" runat="server" Width="128px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Last Name:
                            </td>
                            <td>
                                <asp:TextBox ID="ManagerLastName" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Email Address:
                            </td>
                            <td>
                                <asp:TextBox ID="ManagerEmail" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Password:
                            </td>
                            <td>
                                <asp:TextBox ID="ManagerPassword" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Submit" Text="Submit" runat="server" OnClick="SubmitButton"/>
                            </td>
                            <td>
                                <asp:Button ID="Reset" Text="Reset" runat="server" OnClick="ResetButton"/>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

