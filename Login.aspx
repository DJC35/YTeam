<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
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
                    <asp:RequiredFieldValidator ID = "ValidateUserID" ControlToValidate = "UserID" runat = "server" ErrorMessage = "**UserID is Required!**" />
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <asp:TextBox ID="Password" runat = "server"/>
                    <asp:RequiredFieldValidator ID = "ValidatePassword" ControlToValidate = "Password" runat = "server" ErrorMessage = "**Password is Required!**" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="SubmitLogin" Text="Login" runat = "server" />
                </td>
                <td>
                    <asp:Button ID="ResetLogin" Text="Reset" runat = "server" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
