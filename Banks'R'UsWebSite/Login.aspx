<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Banks'R'Us Login</title>    
</head>
<body>
    <form id="form1" runat="server"> 
        <h1>Welcome to Banks'R'Us!</h1>
        <table>
            <tr>
                <td>
                     User ID:
                </td>
                <td>
                    <asp:TextBox ID="UserID" runat = "server"/>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <asp:TextBox ID="Password" runat = "server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="SubmitLogin" Text="Login" runat = "server" OnClick="SubmitLogin_Click" />
                </td>
                <td>
                    <asp:Button ID="ResetLogin" Text="Reset" runat = "server" OnClick="ResetLogin_Click"/>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
